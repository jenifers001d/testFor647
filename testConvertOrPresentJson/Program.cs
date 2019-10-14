using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testConvertOrPresentJson
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void BuildIndex_Click(string sourcePath, string indexPath) {
            LuceneIndexSearch mySearch = new LuceneIndexSearch();
            mySearch.CreateIndex(indexPath);
            mySearch.IndexText(sourcePath);
            mySearch.CleanUpIndexer();
        }

        //public static string SearchIndex_Click(string queryText, string indexPath)
        public static List<Dictionary<string, string>> SearchIndex_Click(string queryText, string indexPath)
        {
            LuceneIndexSearch mySearch = new LuceneIndexSearch();
            mySearch.CreateSearcher(indexPath);
            mySearch.CreateParser();
            return mySearch.SearchIndext(queryText);

        }
    }
}
