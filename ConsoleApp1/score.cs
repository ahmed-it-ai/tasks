using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class score
    {public static void sum (int[] num,int sld)
        {
            int test = 0;

            for (int x1 = 0; x1 < num.Length; x1++)
            {
                test = num[x1];
                for (int x = 0; x < num.Length; x++)
                {
                    if (test + num[x] == sld)
                    {
                        Console.WriteLine(test + " " + num[x]);
                    }
                }
            }
        }
    }
}
