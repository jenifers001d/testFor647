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
    public partial class Form1 : Form
    {

        string resourcePath = null;
        string indexPath = null;

        List<List<string>> resultListDict; // Create global result list in type of list of dictionaries
        int limit;              // Create document starting index variable


        public Form1()
        {
            InitializeComponent();
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
                //FileStream fs = new FileStream(resourcePath+ "/collection.json", FileMode.Open,FileAccess.Read);
                //StreamReader sr = new StreamReader(fs);

                //Data jsonToObj = (JsonConvert.DeserializeObject<List<Data>>(sr.ReadToEnd()))[0];
                //JArray jArr = JArray.Parse(sr.ReadToEnd());
                //JToken o = jArr[0]["passages"][0]["passage_text"];
                //string jsonData = JsonConvert.SerializeObject(jsonToObj);
                //resultTextBox.Text =  JsonConvert.SerializeObject(jsonToObj);
                //resultTextBox.Text = o.ToString();

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
            if (TextBoxQueryInput != null)
            {
                limit = 0;

                //resultTextBox.Text = Program.SearchIndex_Click(TextBoxQueryInput.Text, IndexDirSearch.Text);

                //[Sam] Put the result into ListView
                resultListDict = Program.SearchIndex_Click(TextBoxQueryInput.Text, IndexDirSearch.Text);
                ViewData(limit, resultListDict);
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

        }

        //[Sam] Present the result of the first ten rank on ListView 
        public void ViewData(int limit, List<List<string>> resultListDict)    // Create global method for viewing the data
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
                ListViewItem lvi = new ListViewItem(new[] { resultListDict[i][0], resultListDict[i][1] });
                resultListView.Items.Add(lvi);
            }
        }
    }
}
