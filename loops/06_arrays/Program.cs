using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region temel dizi örnekleri

            // (değişken türü) diziadı[] = new (değişken türü)[eleman sayısı] **dizi tanımı

            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "blue";
            //colors[2] = "green";
            //colors[3] = "yellow";

            //Console.WriteLine(colors[2]);


            // string[] cities = new string[4];
            // cities[0] = "istanbul";
            // cities[1] = "londra";
            //// cities[2] = "dubai"; // bir indekse değer ataması yapılmazsa 0 atanır
            // cities[3] = "budapest";

            // Console.WriteLine(cities[2]);


            //string[] cities = { "istanbul", "hawai", "ankara", "maldivs", "moldova", "" };
            //// diğer dizi tanımlama yöntemi,      

            //Console.WriteLine(cities[0]);

            //Console.WriteLine(cities[5]);


            #endregion

            #region dizideki elemanları listeleme

            //string[] colors = { "red", "green", "yellow", "white", "purple", "grey", "green" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            //for (int i = 0; i <= numbers.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("çift sayılar" + i);
            //    }
            //}


            //for (int i = 0; i <= numbers.Length; i++)
            //{ 
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine("tek sayılar" + i); 
            //    }
            //}

            //char[] chars = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ',
            //    'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V',
            //    'Y', 'Z' };

            //int harf;
            //Console.WriteLine("alfabenin kaçıncı harfini görüntülemek istersiniz: ");
            //harf = int.Parse(Console.ReadLine());


            //Console.WriteLine(harf+". harf: " + chars[harf-1]);
            #endregion

            #region en büyük sayı bulma

            //int[] myArray =  { 128, 57, 302, 9, 245, 83, 16, 401, 72, 199 };

            //int maxNumber = myArray[0];
            //Console.WriteLine("dizideki elemanlar: ");

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);

            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine("en büyük eleman: " + maxNumber);

            #endregion

            #region dizi metotları

            ////length (dizi uzunluğu)
            //// ----------------
            //string[] persons = { "ali", "veli", "ayşe", "fatma", "hayriye" };

            //Console.WriteLine(persons.Length);  

            ////sort (küçükten büyüğe sıralama)
            ////------------------
            //int[] number = {23,45,234,23,1312,324,234,342,243,234,231,2312,123,434,32123,12 };

            //Array.Sort(number);

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}


            //// reverse (dizi elemanlarını tersten sıralar)
            ////---------------------

            //int[] number = { 23, 45, 234, 23, 1312, 324, 234, 342, 243, 234, 231, 2312, 123, 434, 32123, 12 };

            //Array.Reverse(number);

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            ////indexof (dizi içindeki aranan elemanın indexini gösterir)
            ////--------------------
            //string[] customers = { "ali", "veli", "ayşe", "fatma", "hayriye", "merve" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            ////max - min en büyük en küçük eleman
            ////--------------------

            //int[] numbers = { 1, 2, 342, 34, 34, 14, 5, 6, 57, 24, 23, 46, 234, 32, 4, 35 };

            //Console.WriteLine("dizideki en büyük eleman: " + numbers.Max() + "\n"
            //    + "dizideki en küçük eleman: " + numbers.Min());



            #endregion

            #region kullanıcıdan diziye değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)  // $ işareti  " " içinde + kullanmadan
            //{                                        // değer almayı sağlıyor
            //    Console.Write($"dizinin {i + 1}.şehrini giriniz: ");
            //    cities[i] = Console.ReadLine(); 
            //}

            //Console.WriteLine("Dizideki Şehirler: ");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.şehir: {cities[i]}");
            //}

            #endregion

            #region dizideki tüm elemanlrın toplamı

            //int[] numbers = new int[10];
            //int toplam = 0; //int toplam şeklinde tanımlanırsa hata verir toplama değer atanmalı

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Dizinin {i+1}.sayısını giriniz:");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    toplam += numbers[i];
            //}

            //Console.WriteLine($"------------------------- \n");

            //Console.WriteLine( $"Dizinin elemanları toplamı: {toplam}");



            #endregion

            #region dizi içindeki sayıları tek çift olarak sıralama

            //int[] numbers = new int[10];
            //int tek = 0, cift = 0;
            

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Dizinin {i + 1}.sayısını giriniz:");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"\n ---------------------------------- \n");

            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        cift++;
            //    }
            //    if (numbers[i] % 2 == 1)
            //    {
            //        tek++;
            //    }
            //}

            //int[] tekSayilar = new int[tek];
            //int[] ciftSayilar = new int[cift];

            //int indexcift = 0, indextek = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        ciftSayilar[indexcift] = numbers[i];
            //        indexcift++;
            //    }
            //    if (numbers[i] % 2 == 1)
            //    {
            //        tekSayilar[indextek] = numbers[i];
            //        indextek++;
            //    }
            //}

            //Console.WriteLine($"Çift Sayılar: \n --------------------");

            //for (int i = 0; i < ciftSayilar.Length; i++)
            //{
            //    Console.WriteLine(ciftSayilar[i]);
            //}

            //Console.WriteLine();

            //Console.WriteLine($"Tek Sayılar: \n --------------------");

            //for ( int i = 0; i < tekSayilar.Length; i++)
            //{
            //    Console.WriteLine(tekSayilar[i]);
            //}


            #endregion

            Console.Read();
        }
    }
}
