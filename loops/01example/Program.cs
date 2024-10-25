using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01example
{
    internal class Program   // sözcüğün kenarındaki mor renkli küp metot olduğunu ifade eder
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.Write("Merhaba Dünya");//imleç yanda kalır yeni cümleyi yanına ekler
            //Console.WriteLine("XXXXX"); //imleç alt satıra iner
            //Console.Read();

            #endregion

            #region Değişkenler string

            //string
            //string musteriadi;
            //musteriadi = "Hakan";
            //Console.Write(musteriadi);

            //string customerName; //camel case adlandırma
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Alioğlu";
            //customerPhone = "111 111 11 11";
            //customerEmail = "email";
            //district = "kadıköy";
            //city = "istanbul";

            //Console.WriteLine("******* Müşteri Bilgileri*******");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + "telefon: " + customerPhone +"\n"+ "email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("***************************");

            ////*******************************************************

            //customerName = "Ayşe";
            //customerSurname = "Alioğlu";
            //customerPhone = "222 222 22 22"; //string değerleri ayşegül bilgilerini aldı
            //customerEmail = "email";         //değer atama hiyerarşik ilerler 
            //district = "beşiktaş";
            //city = "istanbul";

            //Console.WriteLine("******* Müşteri Bilgileri*******");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + "telefon: " + customerPhone + "" + "email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("***************************");

            //Console.Read();


            #endregion

            #region int değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int pizzaPrice, hamburgerPrice, cokePrice, lemonadePrice;
            hamburgerPrice = 30;
            cokePrice= 40;
            pizzaPrice = 20;
            lemonadePrice = 50;
           
            Console.WriteLine("+++++++ Restoran Menü Fİyatı ++++++");
            Console.WriteLine("Hamburger Fiyatı: " + hamburgerPrice);
            Console.WriteLine("Pizza Fiyatı: " + pizzaPrice);
            Console.WriteLine("Kola Fiyatı: " + cokePrice);
            Console.WriteLine("Limonata Fiyatı: " + lemonadePrice);

            int hamburgerCount, pizzaCount, lemonadeCount, cokeCount;
            hamburgerCount = 1;
            pizzaCount = 1;
            lemonadeCount = 1;
            cokeCount = 1;

            int toplam;

            toplam = hamburgerCount * hamburgerPrice + pizzaCount * pizzaPrice +
                     cokeCount * cokePrice + lemonadeCount * lemonadePrice;

            Console.WriteLine("Toplam Hesap: " + toplam);

            #endregion

            Console.Read();
        }
    }
}

/* Yazdırma Komutları:
...........................
*/