using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Search;
using FieldInvertState = Lucene.Net.Index.FieldInvertState;

namespace testConvertOrPresentJson
{
    public class NewSimilarity : DefaultSimilarity
    {
        /// <summary>Implemented as <c>sqrt(freq)</c>. </summary>
        public override float Tf(float freq)
        {
            /*
             * 1. Add the log is to dampen the vital of term which with a quite high frequency.
             * 2. Add 1 is for the situation as TF is 1(log(1)=0), after we added 1 in this algorithm that it can help to discriminate TF=0 and TF=1 
             */
            return (float)(Math.Log(freq) + 1);
            //return (float) System.Math.Sqrt(freq); // Default similarity
        }

        /// <summary>Implemented as <c>log(numDocs/(docFreq+1)) + 1</c>. </summary>
        public float idf(long docFreq, long numDocs)
        {
            return (float)(Math.Log(numDocs / (double)(docFreq + 1)) + 1.0);
        }

    }
}
