using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; // for Index Writer
using Lucene.Net.Store; // for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace testConvertOrPresentJson
{
    class LuceneIndexSearch
    {
        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        IndexSearcher searcher;
        QueryParser parser;
        Similarity mySimilarity;

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        //const string TEXT_FN = "Text";
        const string PASSAGES = "passages";
        const string TEXT_FN_PASS_TEXT = "passage_text";
        const string TEXT_FN_PASS_ID = "passage_ID";
        const string TEXT_FN_QUERY_ID = "query_id";
        const string TEXT_FN_URL = "url";

        public LuceneIndexSearch(){
            luceneIndexDirectory = null;
            writer = null;
            // SnowballAnalyzer's second var "name" is the language of stemmer
            analyzer = new Lucene.Net.Analysis.SimpleAnalyzer();
            //analyzer = new Lucene.Net.Analysis.Snowball.SnowballAnalyzer(Lucene.Net.Util.Version.LUCENE_30, "English");
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN_PASS_TEXT, analyzer);
            //mySimilarity = new NewSimilarity();
        }

        /// <summary>
        /// Creates the index at a given path
        /// </summary>
        /// <param name="indexPath">The pathname to create the index</param>
        public void CreateIndex(string indexPath)
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath + "/IndexStoredPosition");
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
            //writer.SetSimilarity(mySimilarity);
        }

        /// <summary>
        /// Indexes a given string into the index
        /// </summary>
        /// <param name="text">The text to index</param>
        public void IndexText(string resourcePath)
        {
            FileStream fs = new FileStream(resourcePath + "/collection.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //Data jsonToObj = (JsonConvert.DeserializeObject<List<Data>>(sr.ReadToEnd()))[0];
            JArray jArr = JArray.Parse(sr.ReadToEnd());
            foreach(var item in jArr)
            {
                JToken passages = item[PASSAGES];
                string queryId = item[TEXT_FN_QUERY_ID].ToString();
                foreach (var p in passages)
                {
                    string text = p[TEXT_FN_PASS_TEXT].ToString();
                    string url = p[TEXT_FN_URL].ToString();
                    string id = p[TEXT_FN_PASS_ID].ToString();
                    Lucene.Net.Documents.Field field1 = new Field(TEXT_FN_PASS_TEXT, text, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
                    Lucene.Net.Documents.Field field2 = new Field(TEXT_FN_URL, url, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
                    Lucene.Net.Documents.Field field3 = new Field(TEXT_FN_PASS_ID, id, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
                    Lucene.Net.Documents.Field field4 = new Field(TEXT_FN_QUERY_ID, queryId, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);

                    Lucene.Net.Documents.Document doc = new Document();
                    doc.Add(field1);
                    doc.Add(field2);
                    doc.Add(field3);
                    doc.Add(field4);

                    writer.AddDocument(doc);
                }
            }
            
            sr.Close();
        }

        /// <summary>
        /// Flushes the buffer and closes the index
        /// </summary>
        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }

        /// <summary>
        /// Creates the searcher object
        /// </summary>
        public void CreateSearcher(string indexPath)
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath + "/IndexStoredPosition");
            searcher = new IndexSearcher(luceneIndexDirectory);
            //searcher.Similarity = mySimilarity;
        }

        /// <summary>
        /// Initialises the parser object
        /// </summary>
        public void CreateParser()
        {
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN_PASS_TEXT, analyzer);
        }

        /// <summary>
        /// Closes the index after searching
        /// </summary>
        public void CleanUpSearch()
        {
            searcher.Dispose();
        }

        /// <summary>
        /// Searches the index for the querytext
        /// </summary>
        /// <param name="querytext">The text to search the index</param>
        //public string SearchIndext(string querytext)
        public List<Dictionary<string, string>> SearchIndext(string querytext)
        {
            List<Dictionary<string, string>> resultListDict = new List<Dictionary<string, string>>();      // Initiate a result list

            System.Console.WriteLine("Searching for " + querytext);
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            Console.WriteLine("query is " + query);
            TopDocs results = searcher.Search(query, 100);
            System.Console.WriteLine("Number of results is " + results.TotalHits);
            int rank = 0;
            // ScoreDocs : a array stores pointers of a query
            // scoreDoc : a pointer of a query points to doc_ID and score (of the doc for the query)
            //string output = "";
            if (results.TotalHits != 0) { // Check if there are results
                foreach (ScoreDoc scoreDoc in results.ScoreDocs)
                {
                    rank++;
                    Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                    string myFieldValue = doc.Get(TEXT_FN_PASS_TEXT);
                    string myURL = doc.Get(TEXT_FN_URL);
                    string passId = doc.Get(TEXT_FN_PASS_ID);
                    string score = scoreDoc.Score.ToString();
                    string queryId = doc.Get(TEXT_FN_QUERY_ID);

                    Explanation e = searcher.Explain(query, scoreDoc.Doc);

                    char delimiters = '/';
                    string[] urlSeg = myURL.Split(delimiters);

                    resultListDict.Add(new Dictionary<string, string> { { "rank", rank.ToString() }, {"passId", passId },
                        { "score", score },{ "title", urlSeg[2] }, { "url", myURL }, { "text", myFieldValue }, { "queryId", queryId } });

                    //Console.WriteLine("Rank " + rank + " text " + myFieldValue + " URL " + myURL);
                    //Console.WriteLine(e);

                }
            }
            
            return resultListDict;

        }

        /// <summary>
        /// Closes the index after searching
        /// </summary>
        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }
    }
}
