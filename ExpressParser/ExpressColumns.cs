using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using ColumnData;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Forms;
using ScrapySharp.Html;
using ScrapySharp.Network;

namespace ExpressParser
{
    public class ExpressColumns
    {
        #region Members

        public Column[] Columns { private set; get; }
        public int Count { private set; get; }

        private const string Url = @"http://express.com.pk/epaper/index.aspx?Date=";
        private const string DataUrl = @"http://express.com.pk/images";
        private const string PaperName = "Express";

        #endregion


        public IEnumerable<Column> GetColumnsByDate(DateTime date)
        {
            var div = ExtractDiv(Url + date.ToString("yyyyMMdd")); //<div>
            var a = div.ChildNodes; //node collection of <a>
            Count = a.Count;

            var columns = new Column[Count];

            for (var i = 0; i < Count; i++)
            {
                var column = ExtractColumnDetail(a[i]);
                columns[i] = column;
            }
            return columns;
        }

        public Column FindColumn(string writerName, DateTime date)
        {
            var cols = GetColumnsByDate(date);
            foreach (var column in cols)
            {
                if (column.WriterName == writerName)
                {
                    return column;
                }
            }
            return null;
        }

        public string SaveColumnToFolder(string targetfolder, Column column)
        {
            var webClient = new WebClient();
            string location = String.Format("{0}\\{1}\\{2}\\",
                                  targetfolder,
                                  column.PaperName,
                                  column.WriterName);

            //append date before filename
            string filename = column.Date.ToString("yyyyMMdd") + "-" + column.ArticleImageName;

            string filepath = location + filename;
            if (!Directory.Exists(location))
                Directory.CreateDirectory(location);

            webClient.DownloadFile(column.ArticleImageUrl, filepath);

            //return the fullpath to saved file
            return filepath;
        }
        
        #region Parse Functions

        private static Column ExtractColumnDetail(HtmlNode a)
        {
            var column = new Column();
            string newsId = null;
            string date = null;

            var dateandIdString = a.GetAttributeValue("onClick", "");
            ExtractDateAndId(dateandIdString, ref newsId, ref date);

            column.PaperName = PaperName;
            column.WriterName = ExtractWriterName(a.FirstChild.GetAttributeValue("src", ""));
            column.Date = DateTime.ParseExact(date, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            column.Id = newsId;
            column.ArticleImageName = newsId + "-2.gif";
            column.TitleImageName = newsId + "-1.jpg";
            column.TitleImageUrl = String.Format("{0}/NP_LHE/{1}/Sub_Images/{2}", DataUrl, date, column.TitleImageName);
            column.ArticleImageUrl = String.Format("{0}/NP_LHE/{1}/Sub_Images/{2}", DataUrl, date, column.ArticleImageName);
            //http://express.com.pk/images/NP_LHE/20101108/Sub_Images/1101094268-1.jpg
            return column;
        }


        private static void ExtractDateAndId(string text, ref string newsId, ref string date)
        {
            //NewWindow('/epaper/PoPupwindow.aspx?newsID=1101094273&Issue=NP_LHE&Date=20101108','story','750','2901','0','center')
            var array = text.Split(new char[] { '&', '=', '\'' });
            newsId = array[2];
            date = array[6];
            //newsId = text.Substring(text.IndexOf("newsID=") + 7, 10);
            //date = text.Substring(text.IndexOf("Date=") + 5, 8);
        }

        private static string ExtractWriterName(string text)
        {
            //../images/Cowes_Jee.gif
            text = text.Remove(0, 10);
            text = text.Remove(text.Length - 4);
            text = text.Replace('_', ' ');
            return text;
        }

        private static HtmlNode ExtractDiv(string url)
        {
            HtmlNode htmlNode = null ;
            var htmlWeb = new HtmlWeb();
            var htmlDocument = htmlWeb.Load(url); //"https://www.express.com.pk/epaper/Index.aspx?Issue=NP_ISB"
            htmlNode = htmlDocument.GetElementbyId("Express_Menu1_columns");
            htmlDocument.LoadHtml(htmlNode.OuterHtml);

            return htmlNode;
        }

        private static string GetAttribValue(HtmlNode node, string val)
        {
            return node != null && node.Attributes[val] != null ? node.Attributes[val].Value : null;
        }

        #endregion
    }
}