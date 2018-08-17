using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.IO;
using System.Net;
using HtmlAgilityPack;
using ColumnData;

namespace JangParser
{
    public class JangColumns
    {
        private const string PaperName = @"Jang";
        //"http://www.jang.com.pk/jang/dec2008-daily/29-12-2008/editorial.htm"
        private const string Url = @"http://www.jang.com.pk/jang/";


        public IEnumerable<Column> GetColumnsByDate(DateTime date)
        {
            /*
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
             * */
            return null;
        }

        public HtmlNode ExtractTable(string url)
        {
            var htmlWeb = new HtmlWeb();
            var htmlDocument = htmlWeb.Load(url);
            ////row[cell/data[@Type='Boolean' and text()='1']]
            //table[tr/td/p/a[@href='idaria.htm']]
            var a = htmlDocument.DocumentNode.SelectNodes("//table[tbody/tr/td/a[@href='idaria.htm']]");

            return null;
        }

    }
}
