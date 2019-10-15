using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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


        public static void SaveResultBtn_Click(StreamWriter sw, int resultCount, List<Dictionary<string, string>> resultListDict)
        {
            // first column haven't decided what it is and what we can display
            for (int i = 0; i < resultListDict.Count; i++)
            {
                sw.WriteLine("00" + resultCount.ToString() + "\tQ0" + "\t" + resultListDict[i]["passId"] +
                    "   \t" + (i + 1) + "\t" + resultListDict[i]["score"] + "    \tn10104844_n10347054_n10501266_team");
            }

            sw.Dispose();
            sw.Close();
        }

        public static void Dos2Unix(string fileName)
        {
            const byte CR = 0x0D;
            const byte LF = 0x0A;
            byte[] data = File.ReadAllBytes(fileName);

            using (FileStream fileStream = File.OpenWrite(fileName))
            {
                BinaryWriter bw = new BinaryWriter(fileStream);
                int position = 0;
                int index = 0;
                do
                {
                    index = Array.IndexOf<byte>(data, CR, position);
                    if ((index >= 0) && (data[index + 1] == LF))
                    {
                        // Write before the CR
                        bw.Write(data, position, index - position);
                        // from LF
                        position = index + 1;
                    }
                }
                while (index > 0);
                bw.Write(data, position, data.Length - position);
                fileStream.SetLength(fileStream.Position);
            }
        }

    }
}
