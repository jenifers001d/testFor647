using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace testConvertOrPresentJson
{
    public partial class MainForm : Form
    {

        string resourcePath = null;
        string indexPath = null;
        string saveResultPath = null;

        List<Dictionary<string, string>> resultListDict; // Create global result list in type of list of dictionaries
        int limit;              // Create document starting index variable
        int currentPage;
        int totalPage;
        bool queryIsPhrase = false;

        public MainForm()
        {
            InitializeComponent();
            queryDisplayBox.Text = "Display final queries:\r\n";
        }

        private void resourceBrowerBtn_Click(object sender, EventArgs e)
        {
            if (resourceBrowserDialog.ShowDialog() == DialogResult.OK) {
                resourcePath = resourceBrowserDialog.SelectedPath;
                resourceDir.Text = resourceBrowserDialog.SelectedPath;
            }
        }

        private void indexBrowerBtn_Click(object sender, EventArgs e)
        {
            if (indexBrowserDialog.ShowDialog() == DialogResult.OK) {
                indexPath = indexBrowserDialog.SelectedPath;
                indexDir.Text = indexBrowserDialog.SelectedPath;
            }
        }

        private void buildIndexBtn_Click(object sender, EventArgs e)
        {
            if (indexPath != null && resourcePath != null) {
                Program.BuildIndex_Click(resourcePath, indexPath);
            }
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxQueryInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            queryDisplayBox.Text = "Display final queries:\r\n";
            if (TextBoxQueryInput != null)
            {
                string queries;
                if (!queryIsPhrase){ // If queries is regarded as tokens
                    queries = TextBoxQueryInput.Text;
                }
                else{ // If queries is regarded as a phrase (As Is)
                    queries = "\"" + TextBoxQueryInput.Text + "\"";
                }

                //resultTextBox.Text = Program.SearchIndex_Click(TextBoxQueryInput.Text, IndexDirSearch.Text);

                //[Sam] Put the result into ListView               
                resultListDict = Program.SearchIndex_Click(queries, IndexDirSearch.Text);

                string q = Program.DisplayProcessedQueries(queries);
                queryDisplayBox.Text += q;

                limit = 0;               
                totalPage = Convert.ToInt32(Math.Ceiling((double)resultListDict.Count / 10));
                if (totalPage == 0)
                {
                    currentPage = 0;
                }
                else {
                    currentPage = 1;
                }
                Console.WriteLine(resultListDict.Count);
                Console.WriteLine(totalPage);
                pageLabel.Text = "Page " + currentPage + " of " + totalPage;
                if (totalPage > 1) { // If page is more than 1, enable next button
                    nextBtn.Enabled = true;
                }
                ViewData(limit, resultListDict);
                saveResultBtn.Enabled = true;
            }
        }

        private void IndexDirSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void IndexBrowseSearchBtn_Click(object sender, EventArgs e)
        {
            if (indexBrowserSearchDialog.ShowDialog() == DialogResult.OK)
            {
                indexPath = indexBrowserSearchDialog.SelectedPath;
                IndexDirSearch.Text = indexBrowserSearchDialog.SelectedPath;
            }
        }

        private void resultListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (resultListView.Items.Count != 0)
            {
                Console.WriteLine(resultListView.SelectedItems);
                Console.WriteLine(resultListView.SelectedItems.Count);
                if (resultListView.SelectedItems.Count > 0)
                {
                    Console.WriteLine("hihi 1");

                    Console.WriteLine(resultListView.SelectedItems[0]);
                    Console.WriteLine("hihi 2");
                    Console.WriteLine(resultListView.SelectedItems[0].Checked);
                    Console.WriteLine(resultListView.SelectedItems[0].Index);
                    Console.WriteLine(resultListView.SelectedItems[0].ListView);
                    Console.WriteLine(resultListView.SelectedItems[0].Selected);
                    Console.WriteLine(resultListView.SelectedItems[0].Text);



                    int rank = Int32.Parse(resultListView.SelectedItems[0].Text);
                    //var popform = new Form();
                    //popform.ShowDialog();
                    MessageBox.Show(resultListDict[rank - 1]["text"], "Entire Passage");
                }
            }
            */
        }

        //[Sam] Present the result of the first ten rank on ListView 
        public void ViewData(int limit, List<Dictionary<string, string>> resultListDict)    // Create global method for viewing the data
        {
            resultListView.Items.Clear();
            resultListView.Controls.Clear();        // Clear current listview
            int end = 0;
            if (resultListDict.Count - limit < 10)      // Check if it's the last results less than 10
            {
                end = limit + (resultListDict.Count % 10);  // Get the modulus
            }
            else
            {
                end = limit + 10;
            }
            for (int i = limit; i < end; i++)     // Loop through current 10 results
            {
                // Add result details into the listview
                ListViewItem lvi = new ListViewItem(new[] { resultListDict[i]["rank"], resultListDict[i]["passId"], resultListDict[i]["score"],
                    resultListDict[i]["title"], resultListDict[i]["url"], resultListDict[i]["text"] });
                resultListView.Items.Add(lvi);
            }
        }

        private void resultListView_DoubleClick(object sender, EventArgs e)
        {
            if (resultListView.Items.Count != 0)
            {
                Console.WriteLine(resultListView.SelectedItems);
                Console.WriteLine(resultListView.SelectedItems.Count);
                if (resultListView.SelectedItems.Count > 0)
                {
                    int rank = Int32.Parse(resultListView.SelectedItems[0].Text);
                    Form newForm = new EntirePassage( resultListDict[rank - 1]["text"] );
                    newForm.ShowDialog();
                    //MessageBox.Show(resultListDict[rank - 1]["text"], "Entire Passage");
                }
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (!nextBtn.Enabled) // If next button is unable, enable next button
            {
                nextBtn.Enabled = true;
            }

            limit = --currentPage * 10 - 10;
            pageLabel.Text = "Page " + currentPage + " of " + totalPage;
            ViewData(limit, resultListDict);
            if (currentPage == 1)  // If there is no previous results, disable previous button
            {
                prevBtn.Enabled = false;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (!prevBtn.Enabled) // If previous button is unable, enable previous button
            { 
                prevBtn.Enabled = true;
            }

            limit = currentPage++ * 10;
            pageLabel.Text = "Page " + currentPage + " of " + totalPage;
            ViewData(limit, resultListDict);
            if ( resultListDict.Count -limit <= 10)  // If there is no next 10 results, disable next button
            {
                nextBtn.Enabled = false;    
            }
        }

        private void queryOptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryIsPhrase = !queryIsPhrase;
        }

        private void saveResultBtn_Click(object sender, EventArgs e)
        {
            saveResultPath = null;
            saveResultDialog.FileName = "";
            saveResultDialog.Filter = "Text File | *.txt";           
            //string resourcePathForQrel = @"H:\jsonDir";           // for save qrel file for trac_eval
            if (saveResultDialog.ShowDialog() == DialogResult.OK)
            {
                saveResultPath = saveResultDialog.FileName;
                // New results should be appended to the end of an existing results file.
                FileStream fs = new FileStream(saveResultPath, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                //StreamWriter writer = new StreamWriter(saveResultPath, append: true);
                Program.SaveResultBtn_Click(sw, resultListDict.Count, resultListDict);
                Program.Dos2Unix(saveResultPath);


                // for save qrel file for trac_eval
                /*
                string PATH = @"C:\Users\n10347054\Desktop\qrel.txt";
                Program.CreateQrelFile(resourcePathForQrel, PATH);
                Program.Dos2Unix(PATH);
                */
                // for save qrel file for trac_eval


                //ConvertBtn.Enabled = true;
            }
        }
    }
}
