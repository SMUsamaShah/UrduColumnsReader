using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System;
using System.Windows.Forms;
using ColumnData;
using ExpressParser;
using System.IO;


namespace TheColumnReader
{
    public partial class MainForm : Form
    {
        private Image _img;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshColumnGrid();
            dateTimePicker.MaxDate = DateTime.Now;
        }

        private void GetColumnListButton_Click(object sender, EventArgs e)
        {
            GetColumnList();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = @"Loading.....";
            if (ColumnListComboBox.SelectedItem == null) return;

            var col = (Column)ColumnListComboBox.SelectedItem;
            
            //string filepath = new Column().SaveColumnToFolder(Environment.CurrentDirectory, col);
            string filepath = col.SaveThisToFolder(Environment.CurrentDirectory);

            pictureBox1.ImageLocation = filepath;
            archiveDataGrid.Rows.Insert(0, new string[]
                                                     {
                                                         col.WriterName, col.Date.ToString("yyyy-MM-dd"),
                                                         col.PaperName, filepath
                                                     });
            toolStripStatusLabel1.Text = @"Completed";
        }

        private void LoadArchiveButton_Click(object sender, EventArgs e)
        {         
            RefreshColumnGrid();
        }
        /*
        private void ArchiveDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.ImageLocation = (string)archiveDataGrid.SelectedRows[0].Cells["ImagePath"].Value;
            //pictureBox1.ImageLocation = 
            
        }*/

        private void ArchiveDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if(archiveDataGrid.SelectedRows.Count!= 0)
            pictureBox1.ImageLocation = (string)archiveDataGrid.SelectedRows[0].Cells["ImagePath"].Value;
        }
              
        private void saveAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ColumnListComboBox.Items.Count; i++)
            {
                ColumnListComboBox.SelectedIndex = i;
                ReadButton_Click(sender,e);
            }
        }

        private void dateTimePicker_CloseUp(object sender, EventArgs e)
        {
            ColumnListComboBox.Items.Clear();
            GetColumnListButton_Click(sender, e);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //ColumnListComboBox.Items.Clear();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void splitContainer1_Paint(object sender, PaintEventArgs e)
        {
            var control = sender as SplitContainer;
            //paint the three dots'
            Point[] points = new Point[3];
            var pointRect = Rectangle.Empty;
            var w = control.Width;
            var h = control.Height;
            var d = control.SplitterDistance;
            var sW = control.SplitterWidth;

            //calculate the position of the points'
            if (control.Orientation == Orientation.Horizontal)
            {
                points[0] = new Point((w / 2), d + (sW / 2));
                points[1] = new Point(points[0].X - 10, points[0].Y);
                points[2] = new Point(points[0].X + 10, points[0].Y);
                pointRect = new Rectangle(points[1].X - 2, points[1].Y - 2,
                    25, 5);
            }
            else
            {
                points[0] = new Point(d + (sW / 2), (h / 2));
                points[1] = new Point(points[0].X, points[0].Y - 10);
                points[2] = new Point(points[0].X, points[0].Y + 10);
                pointRect = new Rectangle(points[1].X - 2, points[1].Y - 2,
                    5, 25);
            }

            foreach (Point p in points)
            {
                p.Offset(-2, -2);
                e.Graphics.FillEllipse(SystemBrushes.ControlDark,
                    new Rectangle(p, new Size(3, 3)));

                p.Offset(1, 1);
                e.Graphics.FillEllipse(SystemBrushes.ControlLight,
                    new Rectangle(p, new Size(3, 3)));
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FormSearch s = new FormSearch();
            s.Show();

        }


        // picturebox settings

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string filepath = pictureBox1.ImageLocation;
            _img = Image.FromFile(filepath);
            string[] directories = filepath.Split(Path.DirectorySeparatorChar);
            string writername = directories[directories.Length - 2];
            titleLabel.Text = writername;
            Zoom(1);
        }

        private void ZoomPercent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;

            switch (combo.SelectedIndex)
            {
                case 0:
                    pictureBox1.Size = pictureBox1.Image.Size;
                    AdjustPictureBoxPosition();
                    break;
                case 1:
                    Zoom(2);
                    break;
                case 2:
                    Zoom(3);
                    break;
                case 3:
                    Zoom(4);
                    break;
            }
        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            ZoomInOut(false);
            AdjustPictureBoxPosition();
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            ZoomInOut(true);
            AdjustPictureBoxPosition();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            AdjustPictureBoxPosition();
        }
        

        //functions
        #region Functions
        private void Zoom(int scale)
        {
            pictureBox1.Width = _img.Width * scale;
            pictureBox1.Height = _img.Height * scale;
        }
        private void AdjustPictureBoxPosition()
        {
            if (pictureBox1.Image != null)
                pictureBox1.Location = new Point((panel1.Width - pictureBox1.Image.Width) / 2 -8, 0);
        }
        private void RefreshColumnGrid()
        {
            archiveDataGrid.Rows.Clear();
            string[] papers = Directory.GetDirectories(Environment.CurrentDirectory);
            foreach (var paper in papers)
            {
                //DirectoryInfo paperInfo = new DirectoryInfo(paper);
                string[] columnists = Directory.GetDirectories(paper);
                foreach (var columnist in columnists)
                {
                    string[] files = Directory.GetFiles(columnist, "*.gif");
                    foreach (string filepath in files)
                    {
                        //.\Express\Saad Ullah Jahn Burq\20101113-1101097865-2.gif
                        string[] directories = filepath.Split(Path.DirectorySeparatorChar);
                        string filename = Path.GetFileName(filepath);
                        string writername = directories[directories.Length - 2];
                        string papername = directories[directories.Length - 3];
                        string[] date = filename.Split('-');

                        archiveDataGrid.Rows.Add(new string[]
                                                     {
                                                         writername, date[0].Insert(4,"-").Insert(7,"-"),
                                                         papername, filepath
                                                     });

                    }
                }
            }
            archiveDataGrid.Sort(archiveDataGrid.Columns["Date"], ListSortDirection.Descending);
        }
        private void GetColumnList()
        {
            ColumnListComboBox.Items.Clear();
            var expresColumns = new ExpressColumns();
            var columns = expresColumns.GetColumnsByDate(dateTimePicker.Value);

            foreach (var column in columns)
            {
                ColumnListComboBox.Items.Add(column);
            }
            ColumnListComboBox.Text = @"Select Writer";
            ColumnListComboBox.Enabled = true;
        }
        private void ZoomInOut(bool zoom)
        {
            int zoomRatio = 10; // percent
            int widthZoom = pictureBox1.Width * zoomRatio / 100;
            int heightZoom = pictureBox1.Height * zoomRatio / 100;

            if (zoom)
            {
                widthZoom *= -1;
                heightZoom *= -1;
            }

            pictureBox1.Width += widthZoom;
            pictureBox1.Height += heightZoom;
        }

        #endregion
    }
}
