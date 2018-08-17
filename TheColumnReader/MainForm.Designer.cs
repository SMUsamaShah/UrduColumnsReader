using System;

namespace TheColumnReader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.getColumnListButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.archiveDataGrid = new System.Windows.Forms.DataGridView();
            this.Writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.readButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ColumnListComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveAllButton = new System.Windows.Forms.Button();
            this.loadArchiveButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zoomPercentSelect = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getColumnListButton
            // 
            this.getColumnListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getColumnListButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.getColumnListButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getColumnListButton.BackgroundImage")));
            this.getColumnListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.getColumnListButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getColumnListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getColumnListButton.Location = new System.Drawing.Point(206, 52);
            this.getColumnListButton.Name = "getColumnListButton";
            this.getColumnListButton.Size = new System.Drawing.Size(81, 23);
            this.getColumnListButton.TabIndex = 1;
            this.getColumnListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.getColumnListButton.UseVisualStyleBackColor = false;
            this.getColumnListButton.Click += new System.EventHandler(this.GetColumnListButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CausesValidation = false;
            this.dateTimePicker.CustomFormat = "dd MMMM,  yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(6, 52);
            this.dateTimePicker.MinDate = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(194, 23);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.CloseUp += new System.EventHandler(this.dateTimePicker_CloseUp);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // archiveDataGrid
            // 
            this.archiveDataGrid.AllowUserToAddRows = false;
            this.archiveDataGrid.AllowUserToDeleteRows = false;
            this.archiveDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.archiveDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.archiveDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archiveDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.archiveDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.archiveDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.archiveDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.archiveDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Writer,
            this.Date,
            this.Paper,
            this.ImagePath});
            this.archiveDataGrid.Location = new System.Drawing.Point(6, 22);
            this.archiveDataGrid.MultiSelect = false;
            this.archiveDataGrid.Name = "archiveDataGrid";
            this.archiveDataGrid.ReadOnly = true;
            this.archiveDataGrid.RowHeadersVisible = false;
            this.archiveDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archiveDataGrid.Size = new System.Drawing.Size(281, 444);
            this.archiveDataGrid.TabIndex = 0;
            this.archiveDataGrid.SelectionChanged += new System.EventHandler(this.ArchiveDataGrid_SelectionChanged);
            // 
            // Writer
            // 
            this.Writer.FillWeight = 60F;
            this.Writer.HeaderText = "Writer";
            this.Writer.Name = "Writer";
            this.Writer.ReadOnly = true;
            this.Writer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Date
            // 
            this.Date.FillWeight = 40F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Paper
            // 
            this.Paper.FillWeight = 30F;
            this.Paper.HeaderText = "Paper";
            this.Paper.Name = "Paper";
            this.Paper.ReadOnly = true;
            this.Paper.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ImagePath
            // 
            this.ImagePath.HeaderText = "filepath";
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(165, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 796);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 593);
            this.panel1.TabIndex = 0;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // readButton
            // 
            this.readButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.readButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.readButton.Location = new System.Drawing.Point(206, 81);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(81, 25);
            this.readButton.TabIndex = 3;
            this.readButton.Text = "Show";
            this.readButton.UseVisualStyleBackColor = false;
            this.readButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "                 ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.ColumnListComboBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.saveAllButton);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.getColumnListButton);
            this.groupBox1.Controls.Add(this.readButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browse by Date";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Express"});
            this.comboBox3.Location = new System.Drawing.Point(6, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(281, 24);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.Text = "Express";
            // 
            // ColumnListComboBox
            // 
            this.ColumnListComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ColumnListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ColumnListComboBox.Enabled = false;
            this.ColumnListComboBox.FormattingEnabled = true;
            this.ColumnListComboBox.Location = new System.Drawing.Point(6, 81);
            this.ColumnListComboBox.Name = "ColumnListComboBox";
            this.ColumnListComboBox.Size = new System.Drawing.Size(194, 24);
            this.ColumnListComboBox.Sorted = true;
            this.ColumnListComboBox.TabIndex = 2;
            this.ColumnListComboBox.Text = "Select Writer";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Location = new System.Drawing.Point(87, 111);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 25);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // saveAllButton
            // 
            this.saveAllButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveAllButton.Location = new System.Drawing.Point(6, 111);
            this.saveAllButton.Name = "saveAllButton";
            this.saveAllButton.Size = new System.Drawing.Size(75, 25);
            this.saveAllButton.TabIndex = 4;
            this.saveAllButton.Text = "Save All";
            this.saveAllButton.UseVisualStyleBackColor = false;
            this.saveAllButton.Click += new System.EventHandler(this.saveAllButton_Click);
            // 
            // loadArchiveButton
            // 
            this.loadArchiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadArchiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadArchiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadArchiveButton.Location = new System.Drawing.Point(6, 472);
            this.loadArchiveButton.Name = "loadArchiveButton";
            this.loadArchiveButton.Size = new System.Drawing.Size(84, 26);
            this.loadArchiveButton.TabIndex = 1;
            this.loadArchiveButton.Text = "Refresh";
            this.loadArchiveButton.UseVisualStyleBackColor = true;
            this.loadArchiveButton.Click += new System.EventHandler(this.LoadArchiveButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.zoomPercentSelect);
            this.splitContainer1.Panel2.Controls.Add(this.titleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.zoomOutButton);
            this.splitContainer1.Panel2.Controls.Add(this.zoomInButton);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(871, 665);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 12;
            this.splitContainer1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.archiveDataGrid);
            this.groupBox2.Controls.Add(this.loadArchiveButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 504);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Viewed Columns";
            // 
            // zoomPercentSelect
            // 
            this.zoomPercentSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomPercentSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.zoomPercentSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.zoomPercentSelect.FormattingEnabled = true;
            this.zoomPercentSelect.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400"});
            this.zoomPercentSelect.Location = new System.Drawing.Point(254, 636);
            this.zoomPercentSelect.Name = "zoomPercentSelect";
            this.zoomPercentSelect.Size = new System.Drawing.Size(55, 21);
            this.zoomPercentSelect.TabIndex = 1;
            this.zoomPercentSelect.SelectedIndexChanged += new System.EventHandler(this.ZoomPercent_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(53, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(171, 21);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Asad Ullah Jahn Barq";
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomOutButton.BackgroundImage")));
            this.zoomOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoomOutButton.Location = new System.Drawing.Point(315, 635);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(22, 23);
            this.zoomOutButton.TabIndex = 2;
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zoomInButton.BackgroundImage")));
            this.zoomInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zoomInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoomInButton.Location = new System.Drawing.Point(226, 635);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(22, 23);
            this.zoomInButton.TabIndex = 1;
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionSpeedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionSpeedToolStripMenuItem
            // 
            this.connectionSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dialUpToolStripMenuItem,
            this.dSLToolStripMenuItem});
            this.connectionSpeedToolStripMenuItem.Name = "connectionSpeedToolStripMenuItem";
            this.connectionSpeedToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.connectionSpeedToolStripMenuItem.Text = "Connection Speed";
            // 
            // dialUpToolStripMenuItem
            // 
            this.dialUpToolStripMenuItem.Name = "dialUpToolStripMenuItem";
            this.dialUpToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dialUpToolStripMenuItem.Text = "Dial Up";
            // 
            // dSLToolStripMenuItem
            // 
            this.dSLToolStripMenuItem.Checked = true;
            this.dSLToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dSLToolStripMenuItem.Name = "dSLToolStripMenuItem";
            this.dSLToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dSLToolStripMenuItem.Text = "DSL";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(0, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(47, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 717);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "The Column Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getColumnListButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView archiveDataGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loadArchiveButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paper;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagePath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button saveAllButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ToolStripMenuItem connectionSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSLToolStripMenuItem;
        private System.Windows.Forms.ComboBox ColumnListComboBox;
        private System.Windows.Forms.ComboBox zoomPercentSelect;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

