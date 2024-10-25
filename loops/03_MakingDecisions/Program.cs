using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  if yapısı

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password = Console.ReadLine();

            //if(password == "abcd") //kod bloğu işlemi bitmediğinden noktalı virgül konulmaz.
            //{
            //    Console.Write("*** şifre doğru ***");
            //}
            //else
            //{
            //    Console.Write("!!! Şifre Yanlış !!!");

            //string capital, country;

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Türkiye için Bilgiler Doğru");
            //}

            //else
            //{
            //    Console.Write("Veriler Yanlış");
            //}




            #endregion

            #region switch case yapısı

            Console.Write("Öğrenmek İstediğiniz Ay Numarasını giriniz: ");
            int monthnumber = int.Parse(Console.ReadLine());

            switch(monthnumber)
            {
                case 1: Console.Write("Ocak"); break;  
                case 2: Console.Write("Şubat"); break;
                case 3: Console.Write("Mart"); break;
                case 4 : Console.Write("Nisan"); break ;
                case 5: Console.Write("Mayıs"); break;
                case 6: Console.Write("Haziran"); break;
                case 7: Console.Write("Temmuz"); break;
                case 8: Console.Write("Ağustos"); break;
                case 9: Console.Write("Eylül"); break;
                case 10: Console.Write("Ekim"); break;
                case 11: Console.Write("Kasım"); break;
                case 12: Console.Write("Aralık"); break;

                default: Console.Write("Hatalı Veri Girişi"); break;
            }
            #endregion


            Console.Read();
        }
    }
}
