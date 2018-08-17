using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace ColumnData
{
    public class Column
    {
        public string WriterName { get; set; }
        public DateTime Date { get; set; }
        public string PaperName { get; set; }
        public string Id { get; set; }
        public string ArticleImageName { get; set; }
        public string ArticleImageUrl { get; set; }
        public Image ArticleImage { get; set; }
        public string TitleImageName { get; set; }
        public string TitleImageUrl { get; set; }
        public Image TitleImage { get; set; }

        public Column(string writerName, DateTime date, string paperName, string id, string articleImageName, string articleImageUrl, Image articleImage, string titleImageName, string titleImageUrl, Image titleImage)
        {
            WriterName = writerName;
            Date = date;
            PaperName = paperName;
            Id = id;
            ArticleImageName = articleImageName;
            ArticleImageUrl = articleImageUrl;
            ArticleImage = articleImage;
            TitleImageName = titleImageName;
            TitleImageUrl = titleImageUrl;
            TitleImage = titleImage;
        }

        public Column()
        {
            WriterName = "";
            Date = DateTime.Today;
            PaperName = "";
            Id = "";
            ArticleImageName = "";
            ArticleImageUrl = "";
            ArticleImage = null;
            TitleImageName = "";
            TitleImageUrl = "";
            TitleImage = null;
        }

        public override string ToString()
        {
            return string.Format("{0}", WriterName);
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

        public string SaveThisToFolder(string targetfolder)
        {
            var webClient = new WebClient();
            string location = String.Format("{0}\\{1}\\{2}\\",
                                  targetfolder,
                                  this.PaperName,
                                  this.WriterName);

            //append date before filename
            string filename = this.Date.ToString("yyyyMMdd") + "-" + this.ArticleImageName;

            string filepath = location + filename;
            if (!Directory.Exists(location))
                Directory.CreateDirectory(location);

            webClient.DownloadFile(this.ArticleImageUrl, filepath);

            //return the fullpath to saved file
            return filepath;
        }
    }
}
