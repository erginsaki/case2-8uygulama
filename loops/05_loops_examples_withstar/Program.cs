using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_loops_examples_withstar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("+");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region ters dik üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("+");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region ters piramit

            int n = 5;
            for (int i = n; i >= 1; i--)
            {

                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            #endregion

            Console.Read();

        }
    }
}
