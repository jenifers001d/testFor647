namespace testConvertOrPresentJson
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
            this.label1 = new System.Windows.Forms.Label();
            this.resourceBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.resourceDir = new System.Windows.Forms.TextBox();
            this.resourceBrowerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.indexDir = new System.Windows.Forms.TextBox();
            this.indexBrowerBtn = new System.Windows.Forms.Button();
            this.indexBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buildIndexBtn = new System.Windows.Forms.Button();
            this.LabelQuery = new System.Windows.Forms.Label();
            this.TextBoxQueryInput = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LabelIndexForSearch = new System.Windows.Forms.Label();
            this.IndexDirSearch = new System.Windows.Forms.TextBox();
            this.IndexBrowseSearchBtn = new System.Windows.Forms.Button();
            this.indexBrowserSearchDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.resultListView = new System.Windows.Forms.ListView();
            this.resultRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultPassId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.queryOptComboBox = new System.Windows.Forms.ComboBox();
            this.saveResultBtn = new System.Windows.Forms.Button();
            this.saveResultDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.queryDisplayBox = new System.Windows.Forms.TextBox();
            this.AmountL = new System.Windows.Forms.Label();
            this.AmountN = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select  Resource  Directory";
            // 
            // resourceDir
            // 
            this.resourceDir.Location = new System.Drawing.Point(44, 52);
            this.resourceDir.Name = "resourceDir";
            this.resourceDir.Size = new System.Drawing.Size(278, 24);
            this.resourceDir.TabIndex = 1;
            // 
            // resourceBrowerBtn
            // 
            this.resourceBrowerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceBrowerBtn.Location = new System.Drawing.Point(344, 49);
            this.resourceBrowerBtn.Name = "resourceBrowerBtn";
            this.resourceBrowerBtn.Size = new System.Drawing.Size(75, 21);
            this.resourceBrowerBtn.TabIndex = 2;
            this.resourceBrowerBtn.Text = "Brower";
            this.resourceBrowerBtn.UseVisualStyleBackColor = true;
            this.resourceBrowerBtn.Click += new System.EventHandler(this.resourceBrowerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select  Index  Directory";
            // 
            // indexDir
            // 
            this.indexDir.Location = new System.Drawing.Point(491, 52);
            this.indexDir.Name = "indexDir";
            this.indexDir.Size = new System.Drawing.Size(278, 24);
            this.indexDir.TabIndex = 4;
            // 
            // indexBrowerBtn
            // 
            this.indexBrowerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexBrowerBtn.Location = new System.Drawing.Point(790, 49);
            this.indexBrowerBtn.Name = "indexBrowerBtn";
            this.indexBrowerBtn.Size = new System.Drawing.Size(75, 21);
            this.indexBrowerBtn.TabIndex = 5;
            this.indexBrowerBtn.Text = "Brower";
            this.indexBrowerBtn.UseVisualStyleBackColor = true;
            this.indexBrowerBtn.Click += new System.EventHandler(this.indexBrowerBtn_Click);
            // 
            // buildIndexBtn
            // 
            this.buildIndexBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildIndexBtn.Location = new System.Drawing.Point(344, 93);
            this.buildIndexBtn.Name = "buildIndexBtn";
            this.buildIndexBtn.Size = new System.Drawing.Size(238, 27);
            this.buildIndexBtn.TabIndex = 7;
            this.buildIndexBtn.Text = "Index";
            this.buildIndexBtn.UseVisualStyleBackColor = true;
            this.buildIndexBtn.Click += new System.EventHandler(this.buildIndexBtn_Click);
            // 
            // LabelQuery
            // 
            this.LabelQuery.AutoSize = true;
            this.LabelQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuery.Location = new System.Drawing.Point(28, 199);
            this.LabelQuery.Name = "LabelQuery";
            this.LabelQuery.Size = new System.Drawing.Size(78, 16);
            this.LabelQuery.TabIndex = 8;
            this.LabelQuery.Text = "Enter Query";
            // 
            // TextBoxQueryInput
            // 
            this.TextBoxQueryInput.Location = new System.Drawing.Point(31, 218);
            this.TextBoxQueryInput.Name = "TextBoxQueryInput";
            this.TextBoxQueryInput.Size = new System.Drawing.Size(278, 22);
            this.TextBoxQueryInput.TabIndex = 9;
            this.TextBoxQueryInput.TextChanged += new System.EventHandler(this.TextBoxQueryInput_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(340, 226);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(104, 48);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LabelIndexForSearch
            // 
            this.LabelIndexForSearch.AutoSize = true;
            this.LabelIndexForSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIndexForSearch.Location = new System.Drawing.Point(611, 163);
            this.LabelIndexForSearch.Name = "LabelIndexForSearch";
            this.LabelIndexForSearch.Size = new System.Drawing.Size(165, 16);
            this.LabelIndexForSearch.TabIndex = 11;
            this.LabelIndexForSearch.Text = "Index  Resource  Directory";
            // 
            // IndexDirSearch
            // 
            this.IndexDirSearch.Location = new System.Drawing.Point(614, 184);
            this.IndexDirSearch.Name = "IndexDirSearch";
            this.IndexDirSearch.Size = new System.Drawing.Size(278, 22);
            this.IndexDirSearch.TabIndex = 12;
            this.IndexDirSearch.TextChanged += new System.EventHandler(this.IndexDirSearch_TextChanged);
            // 
            // IndexBrowseSearchBtn
            // 
            this.IndexBrowseSearchBtn.Location = new System.Drawing.Point(907, 184);
            this.IndexBrowseSearchBtn.Name = "IndexBrowseSearchBtn";
            this.IndexBrowseSearchBtn.Size = new System.Drawing.Size(75, 21);
            this.IndexBrowseSearchBtn.TabIndex = 13;
            this.IndexBrowseSearchBtn.Text = "Brower";
            this.IndexBrowseSearchBtn.UseVisualStyleBackColor = true;
            this.IndexBrowseSearchBtn.Click += new System.EventHandler(this.IndexBrowseSearchBtn_Click);
            // 
            // resultListView
            // 
            this.resultListView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.resultRank,
            this.resultPassId,
            this.resultScore,
            this.resultTitle,
            this.resultURL,
            this.resultText});
            this.resultListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultListView.FullRowSelect = true;
            this.resultListView.GridLines = true;
            this.resultListView.Location = new System.Drawing.Point(31, 317);
            this.resultListView.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(821, 242);
            this.resultListView.TabIndex = 14;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            this.resultListView.SelectedIndexChanged += new System.EventHandler(this.resultListView_SelectedIndexChanged);
            this.resultListView.DoubleClick += new System.EventHandler(this.resultListView_DoubleClick);
            // 
            // resultRank
            // 
            this.resultRank.Text = "Rank";
            this.resultRank.Width = 50;
            // 
            // resultPassId
            // 
            this.resultPassId.Text = "Passage Id";
            this.resultPassId.Width = 82;
            // 
            // resultScore
            // 
            this.resultScore.Text = "Score";
            this.resultScore.Width = 75;
            // 
            // resultTitle
            // 
            this.resultTitle.Text = "Title";
            this.resultTitle.Width = 170;
            // 
            // resultURL
            // 
            this.resultURL.Text = "URL";
            this.resultURL.Width = 170;
            // 
            // resultText
            // 
            this.resultText.Text = "Text";
            this.resultText.Width = 420;
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prevBtn.Enabled = false;
            this.prevBtn.Location = new System.Drawing.Point(280, 590);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(110, 30);
            this.prevBtn.TabIndex = 15;
            this.prevBtn.Text = "Previous 10 hits";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nextBtn.Enabled = false;
            this.nextBtn.Location = new System.Drawing.Point(426, 590);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(110, 30);
            this.nextBtn.TabIndex = 16;
            this.nextBtn.Text = "Next 10 hits";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(677, 599);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(0, 12);
            this.pageLabel.TabIndex = 17;
            // 
            // queryOptComboBox
            // 
            this.queryOptComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryOptComboBox.FormattingEnabled = true;
            this.queryOptComboBox.Items.AddRange(new object[] {
            "Default",
            "As Is"});
            this.queryOptComboBox.Location = new System.Drawing.Point(31, 261);
            this.queryOptComboBox.Name = "queryOptComboBox";
            this.queryOptComboBox.Size = new System.Drawing.Size(75, 23);
            this.queryOptComboBox.TabIndex = 18;
            this.queryOptComboBox.Text = "Default";
            this.queryOptComboBox.SelectedIndexChanged += new System.EventHandler(this.queryOptComboBox_SelectedIndexChanged);
            // 
            // saveResultBtn
            // 
            this.saveResultBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveResultBtn.Enabled = false;
            this.saveResultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveResultBtn.Location = new System.Drawing.Point(871, 393);
            this.saveResultBtn.Name = "saveResultBtn";
            this.saveResultBtn.Size = new System.Drawing.Size(110, 85);
            this.saveResultBtn.TabIndex = 19;
            this.saveResultBtn.Text = "Save Results for trec_eval";
            this.saveResultBtn.UseVisualStyleBackColor = true;
            this.saveResultBtn.Click += new System.EventHandler(this.saveResultBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.buildIndexBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resourceDir);
            this.groupBox1.Controls.Add(this.resourceBrowerBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.indexDir);
            this.groupBox1.Controls.Add(this.indexBrowerBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 137);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Options";
            // 
            // queryDisplayBox
            // 
            this.queryDisplayBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.queryDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryDisplayBox.Location = new System.Drawing.Point(517, 218);
            this.queryDisplayBox.Multiline = true;
            this.queryDisplayBox.Name = "queryDisplayBox";
            this.queryDisplayBox.ReadOnly = true;
            this.queryDisplayBox.Size = new System.Drawing.Size(408, 65);
            this.queryDisplayBox.TabIndex = 22;
            // 
            // AmountL
            // 
            this.AmountL.AutoSize = true;
            this.AmountL.Location = new System.Drawing.Point(31, 296);
            this.AmountL.Name = "AmountL";
            this.AmountL.Size = new System.Drawing.Size(0, 12);
            this.AmountL.TabIndex = 23;
            // 
            // AmountN
            // 
            this.AmountN.AutoSize = true;
            this.AmountN.Location = new System.Drawing.Point(108, 296);
            this.AmountN.Name = "AmountN";
            this.AmountN.Size = new System.Drawing.Size(0, 12);
            this.AmountN.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 657);
            this.Controls.Add(this.AmountN);
            this.Controls.Add(this.AmountL);
            this.Controls.Add(this.queryDisplayBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveResultBtn);
            this.Controls.Add(this.queryOptComboBox);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.IndexBrowseSearchBtn);
            this.Controls.Add(this.IndexDirSearch);
            this.Controls.Add(this.LabelIndexForSearch);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TextBoxQueryInput);
            this.Controls.Add(this.LabelQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Kingsland System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog resourceBrowserDialog;
        private System.Windows.Forms.TextBox resourceDir;
        private System.Windows.Forms.Button resourceBrowerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox indexDir;
        private System.Windows.Forms.Button indexBrowerBtn;
        private System.Windows.Forms.FolderBrowserDialog indexBrowserDialog;
        private System.Windows.Forms.Button buildIndexBtn;
        private System.Windows.Forms.Label LabelQuery;
        private System.Windows.Forms.TextBox TextBoxQueryInput;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label LabelIndexForSearch;
        private System.Windows.Forms.TextBox IndexDirSearch;
        private System.Windows.Forms.Button IndexBrowseSearchBtn;
        private System.Windows.Forms.FolderBrowserDialog indexBrowserSearchDialog;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader resultText;
        private System.Windows.Forms.ColumnHeader resultURL;
        private System.Windows.Forms.ColumnHeader resultTitle;
        private System.Windows.Forms.ColumnHeader resultRank;
        private System.Windows.Forms.ColumnHeader resultScore;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.ComboBox queryOptComboBox;
        private System.Windows.Forms.Button saveResultBtn;
        private System.Windows.Forms.SaveFileDialog saveResultDialog;
        private System.Windows.Forms.ColumnHeader resultPassId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox queryDisplayBox;
        private System.Windows.Forms.Label AmountL;
        private System.Windows.Forms.Label AmountN;
    }
}

