using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            #region for döngüsü

            // for(x;y;z) x: başlangıç, y: bitiş, z: artış azalış

            //Console.Write("Kaç kere yazdırılacak: ");
            //int sondeger = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= sondeger ; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            #endregion

            #region for döngüsü ile karar yapıları

            //for (int i = 0; i<=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0; 

            //for (int i = 1; i <20; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------------");
            //Console.WriteLine(totalvalue);

            //int count = 0;


            //Console.WriteLine("Kaça kadar tam bölen hesaplansın: ");
            //int sayi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Kaça bölünen değerler hesaplansın: ");
            //int bolen = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (i % bolen == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine("tam bolen sayısı: " + count);

            #endregion

            #region while döngüsü


            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i); //sonuç 10
            //    i++;
            //}

            #endregion

            #region klavyeden girilen sayıyının basamakları toplamı

            Console.Write("Basamakları toplanacak sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int toplam = 0, basamak = 0;
            int times = 0;
            
            while(number > 0)
            {
                basamak = number % 10;
                toplam = toplam + basamak;
                number = number / 10;

                times++;


                Console.WriteLine(times + ". basamak " + basamak);

            }

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - ");

            Console.Write("Sayıyının rakamları toplamı: " + toplam);

          

           
            #endregion



            Console.Read();
        }
    }
}
