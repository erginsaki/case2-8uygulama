using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region metotlar

            //()
            // geriye değer döndürmeyen metotlar
            // customer----> listele, ekle, sil, güncelle
            // void metotlar

            //void customerlist()
            //{
            //    Console.WriteLine("ali çetin");
            //    Console.WriteLine("veli çetin");
            //    Console.WriteLine("Ali veli");
            //}

            //customerlist();


            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;

            //    Console.WriteLine(z);
            //}
            //sum();


            #endregion

            #region geriye değer döndürmeyen string parametreli metotlar

            //void writename(string customername)
            //{
            //    Console.WriteLine(customername);
            //}

            //writename("ali mehmet");

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine($"Müşteri adı: {name} \nmüşteri soyadı: {surname}");

            //}

            //CustomerCard("Ayşe","Yeşil");
            //CustomerCard("Ali", "Kaleli");


            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar

            //void sum(int number1, int number2, int number3)
            //{

            //    int result = number1 + number2 + number3;
            //    Console.WriteLine($"İşlem Sonucu: {result}");
            //}

            //sum(2, 3, 4);

            #endregion

            #region geriye değer döndüren metotlar

            //string namecard()
            //{
            //    return ("Buse Yıldız");
            //}
            //namecard();

            //string studentinf()
            //{
            //    string name = "ali";
            //    string surname = "veli";

            //    return (name + " " + surname);
            //}

            //Console.WriteLine(studentinf());


            #endregion

            #region geriye değer döndüren string parametreli metotlar

            // string PersonelCard(string name, string surname, string job)
            // {
            //     string personelInformation = "Adı: " + name + "\nSoyadı: " + surname
            //         + "\nMesleği: " + job;

            //     return personelInformation;
            // }

            // string x, y, z;

            // Console.Write("Personel Adını Giriniz: ");
            // x = Console.ReadLine();
            // Console.Write("Personel Soyadını Giriniz: ");
            // y = Console.ReadLine();
            // Console.Write("Personel Mesleğini Giriniz: ");
            // z = Console.ReadLine();

            // Console.WriteLine(PersonelCard(x, y, z));

            //Console.WriteLine(PersonelCard("Ali", "veli", "pazarcı"));

            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(sum(1,2));    
            //Console.WriteLine(sum(2,3));
            //Console.WriteLine(sum(3,4));

            //int ToplamaIslemi(int sayi1, int sayi2, int sayi3)
            //{
            //    int result = sayi1 + sayi2 + sayi3;
            //    return result;
            //}

            //int x, y, z;

            //Console.Write("Toplanacak 1.sayı: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Toplanacak 2.sayı: ");
            //y = int.Parse(Console.ReadLine());  
            //Console.Write("Toplanacak 3.sayı: ");
            //z = int.Parse(Console.ReadLine());

            //Console.WriteLine($"SONUÇ: {ToplamaIslemi(x, y, z)}");
            //Console.WriteLine($"SONUÇ: {ToplamaIslemi(1,2,0)}");    

            #endregion

            #region örnek uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int average = (exam1 + exam2 + exam3) / 3;

            //    if (average >= 50)
            //    {
            //        return student + " Adlı öğrenci sınavı geçti. Ortalaması: " + average; 
            //    }
            //    else
            //    {
            //        return student + " Adlı öğrenci sınavdan kaldı. Ortalaması: " + average;
            //    }
               
            //}

            //int x, y, z;
            //string studentName;

            //Console.Write("Öğrenci Adını Giriniz: ");
            //studentName = Console.ReadLine();
            //Console.Write("Öğrenci 1.sınav notu: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Öğrenci 2.sınav notu: ");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("Öğrenci 3.sınav notu: ");
            //z = int.Parse(Console.ReadLine());

            //Console.WriteLine(ExamResult(studentName, x, y, z));

            #endregion


            Console.Read();
        }
    }
}
