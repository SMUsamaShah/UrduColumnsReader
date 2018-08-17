using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ColumnData;
using ExpressParser;

namespace TheColumnReader
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            fromDateTimePicker.MaxDate = DateTime.Now;
            fromDateTimePicker.MaxDate = DateTime.Now;

            string[] papers = Directory.GetDirectories(Environment.CurrentDirectory);
            foreach (var paper in papers)
            {
                //DirectoryInfo paperInfo = new DirectoryInfo(paper);
                string[] columnists = Directory.GetDirectories(paper);

                for (int i = 0; i < columnists.Length; i++)
                {
                    columnists[i] = Path.GetFileName(columnists[i]);
                }

                writerComboBox.DataSource = columnists;
            }
        }

        private void searchSaveButton_Click(object sender, EventArgs e)
        {
            if (writerComboBox.Text == null)
                return;

            writerComboBox.Enabled = false;//lock for editing

            var startDate = fromDateTimePicker.Value;
            var endDate = toDateTimePicker.Value;

            int foundCount = 0;
            var ec = new ExpressColumns();

            for (DateTime dt = startDate; dt < endDate; dt=dt.AddDays(1))
            {
                var column = ec.FindColumn(writerComboBox.Text, dt);
                if (column != null)
                {
                    foundCount++;
                    this.Text = string.Format("Found: {0}", foundCount);
                    column.SaveThisToFolder(Environment.CurrentDirectory);
                }
            }

            writerComboBox.Enabled = true;//unlock
        }
    }
}
