using System;
using System.Drawing;

namespace Column
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
    }
}
