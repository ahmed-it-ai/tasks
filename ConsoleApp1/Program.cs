using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[]numbers = NumberArrays.GetArrayFromUser();
            Console.WriteLine("        Task1        ");
            Console.WriteLine(MaxNumber.GitTop1MaxNumber(numbers));
            Console.WriteLine("        Task2        ");
            Console.WriteLine(MaxNumber.GitTop2MaxNumber(numbers));
            Console.WriteLine("        Task3        ");
            score.sum(numbers, int.Parse(Console.ReadLine()));           
            Console.ReadLine();
        }


       
       
    }
}
