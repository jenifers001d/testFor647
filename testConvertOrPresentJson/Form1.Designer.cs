namespace testConvertOrPresentJson
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
            this.resultScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.queryOptComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select  Resource  Directory";
            // 
            // resourceDir
            // 
            this.resourceDir.Location = new System.Drawing.Point(31, 51);
            this.resourceDir.Name = "resourceDir";
            this.resourceDir.Size = new System.Drawing.Size(278, 20);
            this.resourceDir.TabIndex = 1;
            // 
            // resourceBrowerBtn
            // 
            this.resourceBrowerBtn.Location = new System.Drawing.Point(353, 50);
            this.resourceBrowerBtn.Name = "resourceBrowerBtn";
            this.resourceBrowerBtn.Size = new System.Drawing.Size(75, 23);
            this.resourceBrowerBtn.TabIndex = 2;
            this.resourceBrowerBtn.Text = "Brower";
            this.resourceBrowerBtn.UseVisualStyleBackColor = true;
            this.resourceBrowerBtn.Click += new System.EventHandler(this.resourceBrowerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select  Index  Directory";
            // 
            // indexDir
            // 
            this.indexDir.Location = new System.Drawing.Point(31, 125);
            this.indexDir.Name = "indexDir";
            this.indexDir.Size = new System.Drawing.Size(278, 20);
            this.indexDir.TabIndex = 4;
            // 
            // indexBrowerBtn
            // 
            this.indexBrowerBtn.Location = new System.Drawing.Point(353, 121);
            this.indexBrowerBtn.Name = "indexBrowerBtn";
            this.indexBrowerBtn.Size = new System.Drawing.Size(75, 23);
            this.indexBrowerBtn.TabIndex = 5;
            this.indexBrowerBtn.Text = "Brower";
            this.indexBrowerBtn.UseVisualStyleBackColor = true;
            this.indexBrowerBtn.Click += new System.EventHandler(this.indexBrowerBtn_Click);
            // 
            // buildIndexBtn
            // 
            this.buildIndexBtn.Location = new System.Drawing.Point(193, 171);
            this.buildIndexBtn.Name = "buildIndexBtn";
            this.buildIndexBtn.Size = new System.Drawing.Size(75, 23);
            this.buildIndexBtn.TabIndex = 7;
            this.buildIndexBtn.Text = "Index";
            this.buildIndexBtn.UseVisualStyleBackColor = true;
            this.buildIndexBtn.Click += new System.EventHandler(this.buildIndexBtn_Click);
            // 
            // LabelQuery
            // 
            this.LabelQuery.AutoSize = true;
            this.LabelQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuery.Location = new System.Drawing.Point(28, 216);
            this.LabelQuery.Name = "LabelQuery";
            this.LabelQuery.Size = new System.Drawing.Size(78, 16);
            this.LabelQuery.TabIndex = 8;
            this.LabelQuery.Text = "Enter Query";
            // 
            // TextBoxQueryInput
            // 
            this.TextBoxQueryInput.Location = new System.Drawing.Point(31, 236);
            this.TextBoxQueryInput.Name = "TextBoxQueryInput";
            this.TextBoxQueryInput.Size = new System.Drawing.Size(278, 20);
            this.TextBoxQueryInput.TabIndex = 9;
            this.TextBoxQueryInput.TextChanged += new System.EventHandler(this.TextBoxQueryInput_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(426, 295);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LabelIndexForSearch
            // 
            this.LabelIndexForSearch.AutoSize = true;
            this.LabelIndexForSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIndexForSearch.Location = new System.Drawing.Point(28, 273);
            this.LabelIndexForSearch.Name = "LabelIndexForSearch";
            this.LabelIndexForSearch.Size = new System.Drawing.Size(165, 16);
            this.LabelIndexForSearch.TabIndex = 11;
            this.LabelIndexForSearch.Text = "Index  Resource  Directory";
            // 
            // IndexDirSearch
            // 
            this.IndexDirSearch.Location = new System.Drawing.Point(31, 295);
            this.IndexDirSearch.Name = "IndexDirSearch";
            this.IndexDirSearch.Size = new System.Drawing.Size(278, 20);
            this.IndexDirSearch.TabIndex = 12;
            this.IndexDirSearch.TextChanged += new System.EventHandler(this.IndexDirSearch_TextChanged);
            // 
            // IndexBrowseSearchBtn
            // 
            this.IndexBrowseSearchBtn.Location = new System.Drawing.Point(324, 295);
            this.IndexBrowseSearchBtn.Name = "IndexBrowseSearchBtn";
            this.IndexBrowseSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.IndexBrowseSearchBtn.TabIndex = 13;
            this.IndexBrowseSearchBtn.Text = "Brower";
            this.IndexBrowseSearchBtn.UseVisualStyleBackColor = true;
            this.IndexBrowseSearchBtn.Click += new System.EventHandler(this.IndexBrowseSearchBtn_Click);
            // 
            // resultListView
            // 
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.resultRank,
            this.resultScore,
            this.resultTitle,
            this.resultURL,
            this.resultText});
            this.resultListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultListView.FullRowSelect = true;
            this.resultListView.GridLines = true;
            this.resultListView.Location = new System.Drawing.Point(31, 343);
            this.resultListView.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(821, 262);
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
            this.prevBtn.Enabled = false;
            this.prevBtn.Location = new System.Drawing.Point(280, 639);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(110, 32);
            this.prevBtn.TabIndex = 15;
            this.prevBtn.Text = "Previous 10 hits";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Enabled = false;
            this.nextBtn.Location = new System.Drawing.Point(426, 639);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(110, 32);
            this.nextBtn.TabIndex = 16;
            this.nextBtn.Text = "Next 10 hits";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(677, 649);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(0, 13);
            this.pageLabel.TabIndex = 17;
            // 
            // queryOptComboBox
            // 
            this.queryOptComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryOptComboBox.FormattingEnabled = true;
            this.queryOptComboBox.Items.AddRange(new object[] {
            "Default",
            "Queries as a Phrase"});
            this.queryOptComboBox.Location = new System.Drawing.Point(341, 235);
            this.queryOptComboBox.Name = "queryOptComboBox";
            this.queryOptComboBox.Size = new System.Drawing.Size(143, 23);
            this.queryOptComboBox.TabIndex = 18;
            this.queryOptComboBox.Text = "Default";
            this.queryOptComboBox.SelectedIndexChanged += new System.EventHandler(this.queryOptComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 712);
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
            this.Controls.Add(this.buildIndexBtn);
            this.Controls.Add(this.indexBrowerBtn);
            this.Controls.Add(this.indexDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resourceBrowerBtn);
            this.Controls.Add(this.resourceDir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

