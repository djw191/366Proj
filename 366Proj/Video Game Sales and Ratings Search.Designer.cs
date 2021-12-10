namespace _366Proj
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.view = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.resultsPage = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Platform = new System.Windows.Forms.CheckedListBox();
            this.ESRB_Rating = new System.Windows.Forms.CheckedListBox();
            this.VGChartzScore = new System.Windows.Forms.TrackBar();
            this.Metascore = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.favorite = new System.Windows.Forms.CheckBox();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.searchResultBox = new System.Windows.Forms.TextBox();
            this.resultSearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPagePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.resultsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VGChartzScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Metascore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPagePanel
            // 
            this.mainPagePanel.ColumnCount = 3;
            this.mainPagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainPagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPagePanel.Controls.Add(this.searchBox, 1, 1);
            this.mainPagePanel.Controls.Add(this.search, 1, 2);
            this.mainPagePanel.Controls.Add(this.label1, 1, 0);
            this.mainPagePanel.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.mainPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPagePanel.Location = new System.Drawing.Point(0, 0);
            this.mainPagePanel.Name = "mainPagePanel";
            this.mainPagePanel.RowCount = 5;
            this.mainPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPagePanel.Size = new System.Drawing.Size(984, 636);
            this.mainPagePanel.TabIndex = 1;
            this.mainPagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(101, 111);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(781, 44);
            this.searchBox.TabIndex = 0;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search.AutoSize = true;
            this.search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search.Cursor = System.Windows.Forms.Cursors.Default;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(427, 161);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(128, 47);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Video Game Sales and Rating Search Tool";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.view, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.edit, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.add, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(101, 256);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(781, 312);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // view
            // 
            this.view.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.view.AutoSize = true;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(219, 187);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(343, 47);
            this.view.TabIndex = 2;
            this.view.Text = "View Your Reviews";
            this.view.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit.AutoSize = true;
            this.edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(219, 132);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(343, 47);
            this.edit.TabIndex = 1;
            this.edit.Text = "Edit an Existing Game";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(219, 77);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(343, 47);
            this.add.TabIndex = 0;
            this.add.Text = "Add a New Game";
            this.add.UseVisualStyleBackColor = true;
            // 
            // resultsPage
            // 
            this.resultsPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsPage.ColumnCount = 2;
            this.resultsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.resultsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.resultsPage.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.resultsPage.Controls.Add(this.resultsGrid, 1, 1);
            this.resultsPage.Controls.Add(this.button1, 0, 0);
            this.resultsPage.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.resultsPage.Location = new System.Drawing.Point(0, 0);
            this.resultsPage.Name = "resultsPage";
            this.resultsPage.RowCount = 2;
            this.resultsPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resultsPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.resultsPage.Size = new System.Drawing.Size(984, 636);
            this.resultsPage.TabIndex = 2;
            this.resultsPage.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Platform, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ESRB_Rating, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.VGChartzScore, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Metascore, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.favorite, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 503);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minimum Metascore";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Platform
            // 
            this.Platform.CheckOnClick = true;
            this.Platform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Platform.FormattingEnabled = true;
            this.Platform.Items.AddRange(new object[] {
            "PC",
            "PS2",
            "DS",
            "PS",
            "XBL",
            "PSN",
            "PS3",
            "PSP",
            "PS4",
            "X360",
            "Wii",
            "GBA",
            "GB",
            "SNES",
            "3DS",
            "NS",
            "NES",
            "XOne",
            "PSV",
            "And",
            "XB",
            "GEN",
            "DSiW",
            "SAT",
            "GC",
            "OSX",
            "DC",
            "VC",
            "2600",
            "WW",
            "PCE",
            "WiiU",
            "N64",
            "Linux",
            "MS",
            "GG",
            "3DO",
            "SCD",
            "WS",
            "NG",
            "Int",
            "Lynx",
            "DSi",
            "5200",
            "AJ",
            "PCFX",
            "WinP",
            "BRW",
            "NGage",
            "7800",
            "iOS",
            "GIZ",
            "Arc",
            "C64",
            "Amig",
            "MSD",
            "Ouya",
            "VB",
            "Mob",
            "ACPC",
            "ZXS",
            "iQue",
            "GBC",
            "AST",
            "MSX",
            "CDi",
            "ApII",
            "TG16",
            "S32X",
            "FMT",
            "CD32",
            "C128",
            "BBCM",
            "Aco"});
            this.Platform.Location = new System.Drawing.Point(3, 3);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(234, 190);
            this.Platform.TabIndex = 1;
            this.Platform.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Platform_ItemCheck);
            // 
            // ESRB_Rating
            // 
            this.ESRB_Rating.CheckOnClick = true;
            this.ESRB_Rating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ESRB_Rating.FormattingEnabled = true;
            this.ESRB_Rating.Items.AddRange(new object[] {
            "E",
            "M",
            "E10",
            "T",
            "RP",
            "EC",
            "AO",
            "KA"});
            this.ESRB_Rating.Location = new System.Drawing.Point(3, 199);
            this.ESRB_Rating.Name = "ESRB_Rating";
            this.ESRB_Rating.Size = new System.Drawing.Size(234, 124);
            this.ESRB_Rating.TabIndex = 2;
            this.ESRB_Rating.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ESRB_Rating_ItemCheck);
            // 
            // VGChartzScore
            // 
            this.VGChartzScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VGChartzScore.LargeChange = 1;
            this.VGChartzScore.Location = new System.Drawing.Point(3, 364);
            this.VGChartzScore.Name = "VGChartzScore";
            this.VGChartzScore.Size = new System.Drawing.Size(234, 29);
            this.VGChartzScore.TabIndex = 3;
            this.VGChartzScore.ValueChanged += new System.EventHandler(this.VGChartzScore_ValueChanged);
            // 
            // Metascore
            // 
            this.Metascore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Metascore.Location = new System.Drawing.Point(3, 434);
            this.Metascore.Maximum = 100;
            this.Metascore.Name = "Metascore";
            this.Metascore.Size = new System.Drawing.Size(234, 29);
            this.Metascore.TabIndex = 6;
            this.Metascore.ValueChanged += new System.EventHandler(this.Metascore_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum VGChartz Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favorite
            // 
            this.favorite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.favorite.AutoSize = true;
            this.favorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite.Location = new System.Drawing.Point(73, 472);
            this.favorite.Name = "favorite";
            this.favorite.Size = new System.Drawing.Size(94, 24);
            this.favorite.TabIndex = 9;
            this.favorite.Text = "Favorited";
            this.favorite.UseVisualStyleBackColor = true;
            // 
            // resultsGrid
            // 
            this.resultsGrid.AllowUserToAddRows = false;
            this.resultsGrid.AllowUserToDeleteRows = false;
            this.resultsGrid.AllowUserToResizeColumns = false;
            this.resultsGrid.AllowUserToResizeRows = false;
            this.resultsGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.resultsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGrid.GridColor = System.Drawing.SystemColors.Window;
            this.resultsGrid.Location = new System.Drawing.Point(249, 130);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.ReadOnly = true;
            this.resultsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsGrid.Size = new System.Drawing.Size(732, 503);
            this.resultsGrid.TabIndex = 3;
            this.resultsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsGrid_CellClick);
            this.resultsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.searchResultBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.resultSearchButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(249, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(732, 121);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // searchResultBox
            // 
            this.searchResultBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultBox.Location = new System.Drawing.Point(50, 38);
            this.searchResultBox.Name = "searchResultBox";
            this.searchResultBox.Size = new System.Drawing.Size(484, 44);
            this.searchResultBox.TabIndex = 1;
            this.searchResultBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resultSearchBox_KeyDown);
            // 
            // resultSearchButton
            // 
            this.resultSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultSearchButton.Location = new System.Drawing.Point(588, 38);
            this.resultSearchButton.Name = "resultSearchButton";
            this.resultSearchButton.Size = new System.Drawing.Size(141, 45);
            this.resultSearchButton.TabIndex = 2;
            this.resultSearchButton.Text = "Search";
            this.resultSearchButton.UseVisualStyleBackColor = true;
            this.resultSearchButton.Click += new System.EventHandler(this.resultSearch_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "<- Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 636);
            this.Controls.Add(this.resultsPage);
            this.Controls.Add(this.mainPagePanel);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 675);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BGSaRST - Video Game Sales and Rating Search Tool";
            this.mainPagePanel.ResumeLayout(false);
            this.mainPagePanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.resultsPage.ResumeLayout(false);
            this.resultsPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VGChartzScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Metascore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPagePanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TableLayoutPanel resultsPage;
        private System.Windows.Forms.TextBox searchResultBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox Platform;
        private System.Windows.Forms.CheckedListBox ESRB_Rating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar VGChartzScore;
        private System.Windows.Forms.TrackBar Metascore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox favorite;
        private System.Windows.Forms.DataGridView resultsGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button resultSearchButton;
        private System.Windows.Forms.Button button1;
    }
}

