using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_coding_challenge.Codewars
{
    public class day2
    {
        public static string Likes(string[] name)
        {
            string result = "";
            int numb = name.Length - 2;

            switch (name.Length)
            {
                case 0:
                    result = "no one likes this";
                    break;
                case 1:
                    result = $"{name[0]} likes this";
                    break;
                case 2:
                    result = $"{name[0]} and {name[1]} like this";
                    break;
                case 3:
                    result = $"{name[0]}, {name[1]} and {name[2]} like this";
                    break;
                case int i when i > 3:
                    result = $"{name[0]}, {name[1]} and {numb} others like this";
                    break;
            }

            return result;
           
        }

        public static int AreaOrPerimeter(int l, int w)
        {
            int result = 0;
            // code goes here
            if (l == w)
            {
                result = l * w;
            }
            else
            {
                result = (2 * l) + (2 * w);
            }

            return result;
        }
    }
}
