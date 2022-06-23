using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock
{
    class textCheck
    {
        public static bool emptyCheck(string t1)
        {
            bool situation;
            if (t1 == string.Empty)
            {
                situation = false;
            }
            else
            {
                situation = true;
            }
            return situation;
        }
        public static bool emptyCheck(string t1, string t2)
        {
            bool situation;
            if (t1 == string.Empty || t2 == string.Empty)
            {
                situation = false;
            }
            else
            {
                situation = true;
            }
            return situation;
        }
        public static bool emptyCheck(string t1, string t2, string t3, string t4, string t5, string t6, string t7)
        {
            bool situation;
            if (t1 == string.Empty || t2 == string.Empty || t3 == string.Empty || t4 == string.Empty || t5 == string.Empty || t6 == string.Empty || t6 == string.Empty || t7 == string.Empty)
            {
                situation = false;
            }
            else
            {
                situation = true;
            }
            return situation;
        }
    }
}
