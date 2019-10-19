namespace testConvertOrPresentJson
{
    partial class EntirePassage
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
            this.entirePassageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entirePassageBox
            // 
            this.entirePassageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.entirePassageBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.entirePassageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entirePassageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entirePassageBox.Location = new System.Drawing.Point(12, 5);
            this.entirePassageBox.Multiline = true;
            this.entirePassageBox.Name = "entirePassageBox";
            this.entirePassageBox.ReadOnly = true;
            this.entirePassageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.entirePassageBox.Size = new System.Drawing.Size(544, 244);
            this.entirePassageBox.TabIndex = 0;
            // 
            // EntirePassage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(556, 249);
            this.Controls.Add(this.entirePassageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EntirePassage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntirePassage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entirePassageBox;
    }
}