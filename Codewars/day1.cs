using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_coding_challenge.Codewars
{
    public class day1
    {
        public static int Grow(int[] x)
        {
            int result = 1;
            foreach (var i in x)
            {
                result *= i;
            }
            return result;
        }
    }
}
