using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersismCSharp.leap
{
    class Year
    {
        internal static bool IsLeap(int year)
        {
            if (year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
