using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_foreach_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region foreach döngüsü

            //foreach (1;2;3;+)
            // 1: değişken türü
            // 2: değişken adı
            // 3: in
            // 4: liste, koleksiyon, dizi adı

            //--------------------------------------------------

            //string[] cities = { "milano", "istanbul", "zonguldak", "paris", "kütahya" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 324, 3, 23, 4, 234, 12, 34, 123, 324, 312, 123, 43, 142, 643, 76, 54, 235, 32 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 324, 3, 23, 4, 234, 12, 34, 123, 324, 312, 123, 43, 142};

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 1, 2, 324, 3, 23, 4, 234, 12, 34, 123, 324, 312, 123, 43, 142 };
            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        total += number;
            //    }
            //}

            //Console.WriteLine(total);

            #endregion

            #region liste yapısı

            //List<int> list = new List<int>()
            //{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, };


            //foreach (int i in list)
            //{
            //    Console.Write(i + ",");
            //}


            //Console.Write("Harflerine ayrılacak kelimeyi giriniz: ");

            //string word = Console.ReadLine();

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region genel uygulama

            // sınıftaki öğrenci sayısını ve notlarını tutan ve listeleyen uygulama


            int studendtCount;

            Console.WriteLine("Öğrenci Kayıt Uygulaması");
            Console.WriteLine("------------------------------ \n");

            Console.Write("Sınıfınızdaki öğrenci sayısı kaç: ");

            studendtCount = int.Parse(Console.ReadLine());

            string[] students = new string[studendtCount];
            double[] studentsAverage = new double[studendtCount];
            double toplamNot = 0, ortalama = 0;


            Console.WriteLine("\nÖğrenci İsimleri");
            Console.WriteLine("------------------------------ \n");

            for (int i = 0; i < studendtCount; i++)
            {
                
                Console.Write($"{i+1}.öğrencinin ismini giriniz: ");
                students[i] = Console.ReadLine();

                toplamNot = 0;

                for (int sınav = 1; sınav <= 3; sınav++)
                {

                    Console.Write($"\n - {students[i]} adlı öğrencinin {sınav}. sınav notu: ");
                    double studentsExamValue = int.Parse(Console.ReadLine());
                    toplamNot += studentsExamValue;

                }

                studentsAverage[i] = toplamNot / 3;
                Console.WriteLine("---------------------------");
            }


            for (int i = 0; i<studendtCount; i++)
            {
                ortalama += studentsAverage[i];
            }

            Console.WriteLine("\nÖğrenci Not Ortalaması");
            Console.WriteLine("------------------------------ \n");
            Console.WriteLine($"{studendtCount} öğrencinin ortalaması: {ortalama / studendtCount}");

            for (int i = 0; i<studendtCount; i++)
            {
                Console.WriteLine($"{students[i]} adlı öğrencini ortlaması {studentsAverage[i]}");
                //başarılı olma durumu
                if (studentsAverage[i] >= 50)
                {
                    Console.WriteLine("Öğrenci sınavı geçti");
                }
                //başarsız olma durumu
              else
                {
                    Console.WriteLine("Öğrenci sınavdan kaldı");
                }

            }
   


            #endregion

            Console.Read();

        }
    }
}
