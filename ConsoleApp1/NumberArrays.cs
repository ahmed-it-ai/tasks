using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NumberArrays
    {
        public static void WriteArrey(int[] num)
        {
            for (int x = 0; x < num.Length; x++)
            {
                Console.Write(" " + num[x]);
            }
        }
        public static int[] GetArrayFromUser()
        {
            int[] num = new int[10];            
            int loop = 0;
            int m;
            do
            {
                try
                {
                    Console.Write("inter Number :");
                    m = int.Parse(Console.ReadLine());
                    num[loop] = m;
                    loop++;
                }
                catch
                {
                    if (num.Length <= loop) 
                    {
                        Console.WriteLine("THE Index is 10");
                       // t = false;
                    } 
                    else 
                    {
                        Console.WriteLine("Index End");
                        //t = false;
                        break;
                    }
                    
                }
            } while (true);

            return num;
        }


    }
}
