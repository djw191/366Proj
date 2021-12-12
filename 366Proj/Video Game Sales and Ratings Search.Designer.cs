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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1 = new System.Windows.Forms.Button();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.searchResultBox = new System.Windows.Forms.TextBox();
            this.resultSearchButton = new System.Windows.Forms.Button();
            this.createUserReviews_Back_Click = new System.Windows.Forms.Button();
            this.createUserReviews_Save = new System.Windows.Forms.Button();
            this.createUserReviews_Delete = new System.Windows.Forms.Button();
            this.createReviewGameTitle = new System.Windows.Forms.Label();
            this.createReviewPlatform = new System.Windows.Forms.Label();
            this.createUserReview_TextReview = new System.Windows.Forms.TextBox();
            this.createUserReviewsPanel = new System.Windows.Forms.Panel();
            this.createUserReview_score_dropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewUserReviewsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.viewUserReviews_dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.viewUserReviews_EDIT_REVIEW = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.viewUserReviews_label = new System.Windows.Forms.Label();
            this.viewUserReviews_Back = new System.Windows.Forms.Button();
            this.viewUserReviews_NEW_REVIEW = new System.Windows.Forms.Button();
            this.mainPagePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.resultsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VGChartzScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Metascore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.createUserReviewsPanel.SuspendLayout();
            this.viewUserReviewsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserReviews_dataGridView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.mainPagePanel.Size = new System.Drawing.Size(1264, 681);
            this.mainPagePanel.TabIndex = 1;
            this.mainPagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(129, 123);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1005, 44);
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
            this.search.Location = new System.Drawing.Point(567, 173);
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
            this.label1.Location = new System.Drawing.Point(317, 15);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(129, 275);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1005, 334);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // view
            // 
            this.view.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.view.AutoSize = true;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(331, 200);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(343, 47);
            this.view.TabIndex = 2;
            this.view.Text = "View Your Reviews";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click_1);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit.AutoSize = true;
            this.edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(331, 143);
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
            this.add.Location = new System.Drawing.Point(331, 86);
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
            this.resultsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.resultsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.resultsPage.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.resultsPage.Controls.Add(this.button1, 0, 0);
            this.resultsPage.Controls.Add(this.resultsGrid, 1, 1);
            this.resultsPage.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.resultsPage.Location = new System.Drawing.Point(0, 0);
            this.resultsPage.Name = "resultsPage";
            this.resultsPage.RowCount = 2;
            this.resultsPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.resultsPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.resultsPage.Size = new System.Drawing.Size(1264, 681);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 139);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(183, 539);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
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
            "WII",
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
            this.Platform.Size = new System.Drawing.Size(177, 204);
            this.Platform.TabIndex = 1;
            this.Platform.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Platform_ItemCheck);
            this.Platform.SelectedIndexChanged += new System.EventHandler(this.Platform_SelectedIndexChanged);
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
            this.ESRB_Rating.Location = new System.Drawing.Point(3, 213);
            this.ESRB_Rating.Name = "ESRB_Rating";
            this.ESRB_Rating.Size = new System.Drawing.Size(177, 134);
            this.ESRB_Rating.TabIndex = 2;
            this.ESRB_Rating.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ESRB_Rating_ItemCheck);
            // 
            // VGChartzScore
            // 
            this.VGChartzScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VGChartzScore.LargeChange = 1;
            this.VGChartzScore.Location = new System.Drawing.Point(3, 390);
            this.VGChartzScore.Name = "VGChartzScore";
            this.VGChartzScore.Size = new System.Drawing.Size(177, 31);
            this.VGChartzScore.TabIndex = 3;
            this.VGChartzScore.ValueChanged += new System.EventHandler(this.VGChartzScore_ValueChanged);
            // 
            // Metascore
            // 
            this.Metascore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Metascore.Location = new System.Drawing.Point(3, 464);
            this.Metascore.Maximum = 100;
            this.Metascore.Name = "Metascore";
            this.Metascore.Size = new System.Drawing.Size(177, 31);
            this.Metascore.TabIndex = 6;
            this.Metascore.ValueChanged += new System.EventHandler(this.Metascore_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum VGChartz Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // favorite
            // 
            this.favorite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.favorite.AutoSize = true;
            this.favorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite.Location = new System.Drawing.Point(44, 506);
            this.favorite.Name = "favorite";
            this.favorite.Size = new System.Drawing.Size(94, 24);
            this.favorite.TabIndex = 9;
            this.favorite.Text = "Favorited";
            this.favorite.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "<- Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Back_Click);
            // 
            // resultsGrid
            // 
            this.resultsGrid.AllowUserToAddRows = false;
            this.resultsGrid.AllowUserToDeleteRows = false;
            this.resultsGrid.AllowUserToResizeColumns = false;
            this.resultsGrid.AllowUserToResizeRows = false;
            this.resultsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.resultsGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.resultsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGrid.GridColor = System.Drawing.SystemColors.Window;
            this.resultsGrid.Location = new System.Drawing.Point(192, 139);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.ReadOnly = true;
            this.resultsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsGrid.Size = new System.Drawing.Size(1069, 539);
            this.resultsGrid.TabIndex = 3;
            this.resultsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsGrid_CellDoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.searchResultBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.resultSearchButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(192, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1069, 130);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // searchResultBox
            // 
            this.searchResultBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultBox.Location = new System.Drawing.Point(185, 43);
            this.searchResultBox.Name = "searchResultBox";
            this.searchResultBox.Size = new System.Drawing.Size(484, 44);
            this.searchResultBox.TabIndex = 1;
            this.searchResultBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resultSearchBox_KeyDown);
            // 
            // resultSearchButton
            // 
            this.resultSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultSearchButton.Location = new System.Drawing.Point(858, 42);
            this.resultSearchButton.Name = "resultSearchButton";
            this.resultSearchButton.Size = new System.Drawing.Size(208, 45);
            this.resultSearchButton.TabIndex = 2;
            this.resultSearchButton.Text = "Search";
            this.resultSearchButton.UseVisualStyleBackColor = true;
            this.resultSearchButton.Click += new System.EventHandler(this.resultSearch_Click);
            // 
            // createUserReviews_Back_Click
            // 
            this.createUserReviews_Back_Click.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createUserReviews_Back_Click.AutoSize = true;
            this.createUserReviews_Back_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserReviews_Back_Click.Location = new System.Drawing.Point(26, 44);
            this.createUserReviews_Back_Click.Name = "createUserReviews_Back_Click";
            this.createUserReviews_Back_Click.Size = new System.Drawing.Size(136, 47);
            this.createUserReviews_Back_Click.TabIndex = 6;
            this.createUserReviews_Back_Click.Text = "<- Back";
            this.createUserReviews_Back_Click.UseVisualStyleBackColor = true;
            this.createUserReviews_Back_Click.Click += new System.EventHandler(this.createUserReviews_Back);
            // 
            // createUserReviews_Save
            // 
            this.createUserReviews_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createUserReviews_Save.AutoSize = true;
            this.createUserReviews_Save.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.createUserReviews_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.createUserReviews_Save.Location = new System.Drawing.Point(3, 550);
            this.createUserReviews_Save.Name = "createUserReviews_Save";
            this.createUserReviews_Save.Size = new System.Drawing.Size(183, 47);
            this.createUserReviews_Save.TabIndex = 7;
            this.createUserReviews_Save.Text = "Save";
            this.createUserReviews_Save.UseVisualStyleBackColor = false;
            this.createUserReviews_Save.Click += new System.EventHandler(this.createUserReviews_Save_Click);
            // 
            // createUserReviews_Delete
            // 
            this.createUserReviews_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createUserReviews_Delete.AutoSize = true;
            this.createUserReviews_Delete.BackColor = System.Drawing.Color.IndianRed;
            this.createUserReviews_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.createUserReviews_Delete.Location = new System.Drawing.Point(3, 603);
            this.createUserReviews_Delete.Name = "createUserReviews_Delete";
            this.createUserReviews_Delete.Size = new System.Drawing.Size(183, 47);
            this.createUserReviews_Delete.TabIndex = 8;
            this.createUserReviews_Delete.Text = "Delete";
            this.createUserReviews_Delete.UseVisualStyleBackColor = false;
            this.createUserReviews_Delete.Click += new System.EventHandler(this.createUserReview_Delete_Click);
            // 
            // createReviewGameTitle
            // 
            this.createReviewGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.createReviewGameTitle.Location = new System.Drawing.Point(371, 52);
            this.createReviewGameTitle.Margin = new System.Windows.Forms.Padding(3);
            this.createReviewGameTitle.Name = "createReviewGameTitle";
            this.createReviewGameTitle.Size = new System.Drawing.Size(490, 31);
            this.createReviewGameTitle.TabIndex = 0;
            this.createReviewGameTitle.Text = "Game Title (displayed)";
            this.createReviewGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createReviewPlatform
            // 
            this.createReviewPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.createReviewPlatform.Location = new System.Drawing.Point(1056, 52);
            this.createReviewPlatform.Margin = new System.Windows.Forms.Padding(3);
            this.createReviewPlatform.Name = "createReviewPlatform";
            this.createReviewPlatform.Size = new System.Drawing.Size(202, 31);
            this.createReviewPlatform.TabIndex = 0;
            this.createReviewPlatform.Text = "Platform (displayed)";
            this.createReviewPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createUserReview_TextReview
            // 
            this.createUserReview_TextReview.AcceptsReturn = true;
            this.createUserReview_TextReview.AcceptsTab = true;
            this.createUserReview_TextReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.createUserReview_TextReview.Location = new System.Drawing.Point(192, 142);
            this.createUserReview_TextReview.Multiline = true;
            this.createUserReview_TextReview.Name = "createUserReview_TextReview";
            this.createUserReview_TextReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.createUserReview_TextReview.Size = new System.Drawing.Size(1069, 536);
            this.createUserReview_TextReview.TabIndex = 10;
            // 
            // createUserReviewsPanel
            // 
            this.createUserReviewsPanel.Controls.Add(this.createUserReview_score_dropdown);
            this.createUserReviewsPanel.Controls.Add(this.label4);
            this.createUserReviewsPanel.Controls.Add(this.createUserReview_TextReview);
            this.createUserReviewsPanel.Controls.Add(this.createReviewPlatform);
            this.createUserReviewsPanel.Controls.Add(this.createReviewGameTitle);
            this.createUserReviewsPanel.Controls.Add(this.createUserReviews_Delete);
            this.createUserReviewsPanel.Controls.Add(this.createUserReviews_Save);
            this.createUserReviewsPanel.Controls.Add(this.createUserReviews_Back_Click);
            this.createUserReviewsPanel.Location = new System.Drawing.Point(0, 0);
            this.createUserReviewsPanel.Name = "createUserReviewsPanel";
            this.createUserReviewsPanel.Size = new System.Drawing.Size(1264, 681);
            this.createUserReviewsPanel.TabIndex = 3;
            this.createUserReviewsPanel.Visible = false;
            this.createUserReviewsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createUserReviewsPanel_Paint);
            // 
            // createUserReview_score_dropdown
            // 
            this.createUserReview_score_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createUserReview_score_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.createUserReview_score_dropdown.FormattingEnabled = true;
            this.createUserReview_score_dropdown.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.createUserReview_score_dropdown.Location = new System.Drawing.Point(103, 142);
            this.createUserReview_score_dropdown.Name = "createUserReview_score_dropdown";
            this.createUserReview_score_dropdown.Size = new System.Drawing.Size(83, 39);
            this.createUserReview_score_dropdown.TabIndex = 12;
            this.createUserReview_score_dropdown.Tag = "";
            this.createUserReview_score_dropdown.SelectedIndexChanged += new System.EventHandler(this.createUserReview_score_dropdown_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(4, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Score:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewUserReviewsPanel
            // 
            this.viewUserReviewsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewUserReviewsPanel.ColumnCount = 2;
            this.viewUserReviewsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.viewUserReviewsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.viewUserReviewsPanel.Controls.Add(this.viewUserReviews_dataGridView, 1, 1);
            this.viewUserReviewsPanel.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.viewUserReviewsPanel.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.viewUserReviewsPanel.Controls.Add(this.viewUserReviews_Back, 0, 0);
            this.viewUserReviewsPanel.Location = new System.Drawing.Point(0, 0);
            this.viewUserReviewsPanel.Name = "viewUserReviewsPanel";
            this.viewUserReviewsPanel.RowCount = 2;
            this.viewUserReviewsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.viewUserReviewsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.viewUserReviewsPanel.Size = new System.Drawing.Size(1264, 681);
            this.viewUserReviewsPanel.TabIndex = 4;
            this.viewUserReviewsPanel.Visible = false;
            // 
            // viewUserReviews_dataGridView
            // 
            this.viewUserReviews_dataGridView.AllowUserToAddRows = false;
            this.viewUserReviews_dataGridView.AllowUserToDeleteRows = false;
            this.viewUserReviews_dataGridView.AllowUserToResizeColumns = false;
            this.viewUserReviews_dataGridView.AllowUserToResizeRows = false;
            this.viewUserReviews_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewUserReviews_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.viewUserReviews_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.viewUserReviews_dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewUserReviews_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewUserReviews_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.viewUserReviews_dataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.viewUserReviews_dataGridView.Location = new System.Drawing.Point(192, 139);
            this.viewUserReviews_dataGridView.Name = "viewUserReviews_dataGridView";
            this.viewUserReviews_dataGridView.ReadOnly = true;
            this.viewUserReviews_dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.viewUserReviews_dataGridView.Size = new System.Drawing.Size(1069, 539);
            this.viewUserReviews_dataGridView.TabIndex = 7;
            this.viewUserReviews_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewUserReviews_dataGridView_CellContentClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.viewUserReviews_EDIT_REVIEW, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.viewUserReviews_NEW_REVIEW, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 139);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(183, 539);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // viewUserReviews_EDIT_REVIEW
            // 
            this.viewUserReviews_EDIT_REVIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.viewUserReviews_EDIT_REVIEW.Location = new System.Drawing.Point(3, 51);
            this.viewUserReviews_EDIT_REVIEW.Name = "viewUserReviews_EDIT_REVIEW";
            this.viewUserReviews_EDIT_REVIEW.Size = new System.Drawing.Size(177, 42);
            this.viewUserReviews_EDIT_REVIEW.TabIndex = 6;
            this.viewUserReviews_EDIT_REVIEW.Text = "Edit Review";
            this.viewUserReviews_EDIT_REVIEW.UseVisualStyleBackColor = true;
            this.viewUserReviews_EDIT_REVIEW.Click += new System.EventHandler(this.viewUserReviews_EDIT_REVIEW_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Controls.Add(this.viewUserReviews_label, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(192, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1069, 130);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // viewUserReviews_label
            // 
            this.viewUserReviews_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewUserReviews_label.AutoSize = true;
            this.viewUserReviews_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.viewUserReviews_label.Location = new System.Drawing.Point(3, 0);
            this.viewUserReviews_label.Name = "viewUserReviews_label";
            this.viewUserReviews_label.Size = new System.Drawing.Size(849, 130);
            this.viewUserReviews_label.TabIndex = 0;
            this.viewUserReviews_label.Text = "Your Reviews";
            this.viewUserReviews_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewUserReviews_Back
            // 
            this.viewUserReviews_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewUserReviews_Back.AutoSize = true;
            this.viewUserReviews_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUserReviews_Back.Location = new System.Drawing.Point(26, 44);
            this.viewUserReviews_Back.Name = "viewUserReviews_Back";
            this.viewUserReviews_Back.Size = new System.Drawing.Size(136, 47);
            this.viewUserReviews_Back.TabIndex = 5;
            this.viewUserReviews_Back.Text = "<- Back";
            this.viewUserReviews_Back.UseVisualStyleBackColor = true;
            this.viewUserReviews_Back.Click += new System.EventHandler(this.viewUserReviews_Back_Click);
            // 
            // viewUserReviews_NEW_REVIEW
            // 
            this.viewUserReviews_NEW_REVIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.viewUserReviews_NEW_REVIEW.Location = new System.Drawing.Point(3, 3);
            this.viewUserReviews_NEW_REVIEW.Name = "viewUserReviews_NEW_REVIEW";
            this.viewUserReviews_NEW_REVIEW.Size = new System.Drawing.Size(177, 42);
            this.viewUserReviews_NEW_REVIEW.TabIndex = 7;
            this.viewUserReviews_NEW_REVIEW.Text = "New Review";
            this.viewUserReviews_NEW_REVIEW.UseVisualStyleBackColor = true;
            this.viewUserReviews_NEW_REVIEW.Click += new System.EventHandler(this.viewUserReviews_NEW_REVIEW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.createUserReviewsPanel);
            this.Controls.Add(this.resultsPage);
            this.Controls.Add(this.viewUserReviewsPanel);
            this.Controls.Add(this.mainPagePanel);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
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
            this.createUserReviewsPanel.ResumeLayout(false);
            this.createUserReviewsPanel.PerformLayout();
            this.viewUserReviewsPanel.ResumeLayout(false);
            this.viewUserReviewsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserReviews_dataGridView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
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
        private System.Windows.Forms.Button createUserReviews_Back_Click;
        private System.Windows.Forms.Button createUserReviews_Save;
        private System.Windows.Forms.Button createUserReviews_Delete;
        private System.Windows.Forms.Label createReviewGameTitle;
        private System.Windows.Forms.Label createReviewPlatform;
        private System.Windows.Forms.TextBox createUserReview_TextReview;
        private System.Windows.Forms.Panel createUserReviewsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel viewUserReviewsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button viewUserReviews_Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label viewUserReviews_label;
        private System.Windows.Forms.Button viewUserReviews_EDIT_REVIEW;
        private System.Windows.Forms.ComboBox createUserReview_score_dropdown;
        private System.Windows.Forms.DataGridView viewUserReviews_dataGridView;
        private System.Windows.Forms.Button viewUserReviews_NEW_REVIEW;
    }
}

