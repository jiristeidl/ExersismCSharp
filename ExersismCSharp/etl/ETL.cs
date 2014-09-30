using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersismCSharp.etl
{
    class ETL
    {
        internal static Dictionary<string,int> Transform(Dictionary<int, IList<string>> oldData)
        {
            var newData = new Dictionary<string, int>();
            foreach(var valueLettersPair in oldData)
            {
                foreach (var letter in valueLettersPair.Value)
                {
                    newData.Add(letter.ToLower(), valueLettersPair.Key);
                }
            }
            return newData;
        }
    }
}
