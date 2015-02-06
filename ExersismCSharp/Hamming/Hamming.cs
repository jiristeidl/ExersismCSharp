using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersismCSharp.Hamming
{
    class Hamming
    {
        internal static int Compute(string originalStrand, string newStrand)
        {
            int differences = 0;
            if (!originalStrand.Equals(newStrand))
            {
                for (int i = 0; i < originalStrand.Length; i++)
                {
                    if (!originalStrand[i].Equals(newStrand[i]))
                    {
                        differences++;
                    }
                }
            }
            return differences;
        }
    }
}
