using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq; // for save qrel file for trac_eval

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

        public static string DisplayProcessedQueries(string queries) {
            LuceneIndexSearch mySearch = new LuceneIndexSearch();
            string q = mySearch.DisplayQueries(queries).ToString();
            string[] delimiters = { "passage_text:", " passage_text:" };
            string[] finalQueries = q.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            string fQ = "";
            foreach (string query in finalQueries) {
                fQ += query + ", ";
            }
            return fQ;
        }

        public static void SaveResultBtn_Click(StreamWriter sw, int resultCount, List<Dictionary<string, string>> resultListDict)
        {
            // first column haven't decided what it is and what we can display
            for (int i = 0; i < resultListDict.Count; i++)
            {
                Console.WriteLine(resultListDict[i]["queryId"]);
                string t = String.Format("{0,-7} Q0   {1,-10} {2,-6} {3,-12:F10} n10104844_n10347054_n10501266_team", 
                    resultListDict[i]["queryId"], resultListDict[i]["passId"], (i + 1), resultListDict[i]["score"]);
                //sw.WriteLine(resultListDict[i]["queryId"] + "\tQ0" + "\t" + resultListDict[i]["passId"] +
                //    "   \t" + (i + 1) + "\t" + resultListDict[i]["score"] + "    \tn10104844_n10347054_n10501266_team");
                sw.WriteLine(t);
            }

            sw.Dispose();
            sw.Close();
        }

        public static void CreateQrelFile(string resourcePath, string qrelPath)  // for save qrel file for trac_eval
        { 

            FileStream fs1 = new FileStream(resourcePath + "/collection.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            JArray jArr = JArray.Parse(sr.ReadToEnd());

            FileStream fs2 = new FileStream(qrelPath, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);

            string queryId;
            foreach (var item in jArr)
            {
                JToken passages = item["passages"];
                queryId = item["query_id"].ToString();
                foreach (var p in passages)
                {
                    int isSelected = Int32.Parse(p["is_selected"].ToString());
                    if (isSelected == 1) {
                        string id = p["passage_ID"].ToString();
                        sw.WriteLine(queryId + " 0 " + id + " " + isSelected);
                    }
                    
                }
            }

            sw.Dispose();
            sr.Dispose();
            sw.Close();
            sr.Close();
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
