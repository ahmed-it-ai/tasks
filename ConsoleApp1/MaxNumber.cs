using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MaxNumber
    {

        public static int GitTop1MaxNumber (int[] num)
        {
            int MaxNumber = 0;
            for (int x =0;x<num.Length;x++)
            {
                if(MaxNumber < num[x])
                {
                    MaxNumber = num[x];
                }
            }            
            return MaxNumber;
        }
        public static int GitTop2MaxNumber(int[]num)
        {

            int MaxNumber = 0;
            int indexMaxNumber =0;
            int[] arr = num;
            for (int x = 0; x < num.Length; x++)
            {
                if (MaxNumber < num[x])
                {
                    MaxNumber = num[x];
                    indexMaxNumber = x;
                }
            }
            arr[indexMaxNumber] = 0;
            
            return GitTop1MaxNumber(arr);
        }



            

    }
}
