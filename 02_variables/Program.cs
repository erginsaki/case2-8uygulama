using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            double sayi;
            sayi = 3.232;
            Console.WriteLine(sayi);

            #endregion

            #region Char Değişkenler

            char sembol;
            sembol = 'a';
            Console.WriteLine(sembol);

            #endregion
            ////"ctrl F" ile seçilen sözcük başka sözcükle değiştirilebilir.
            #region Klavyeden Veri Girişi String

            Console.WriteLine("**** Hava Yolu Yolcu Bilgisi ****");

            string passengerName, passengerSurname, passengerDistrict, passengerCity,
                   passengerAge, passengerIdentity;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Yolcu İlçe: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Yolcu İl: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu Kimlik No: ");
            passengerIdentity = Console.ReadLine();

            Console.WriteLine("---------------------------");

            Console.WriteLine("Yolcu Bilgileri: \n" +
                "Ad: " + passengerName + "\t" + "Soyad: " + passengerSurname + "\n" +
                "Adres: " + passengerCity + "/" + passengerDistrict + "\n" +
                "Yaş: " + passengerAge + "\n" + "Kimlik No: " + passengerIdentity);


            #endregion

            #region Klavyeden Tam Sayı Girişi ve Dönüşümler

            int capPrice, compPrice, capCount, compCount;

            capPrice = 100;
            compPrice = 10000;


            Console.Write("Alınan Şapka Adedi: ");
            capCount = int.Parse(Console.ReadLine());

            // int.parse() klavyeden gelen sayısal string değerini integer a çevirir

            Console.Write("Alınan Bilgisayar Adedi: ");
            compCount = int.Parse(Console.ReadLine());

            int toplam = capPrice * capCount + compPrice * compCount;

            Console.WriteLine("Toplam Fiyat: " + toplam);

            #endregion

            #region Ondalıklı Sayı Girişi ve Dönüşümler

            double exam1, exam2, exam3;
            double result;

            Console.Write("Birinci sınav notunuz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci sınav notunuz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Üçüncü sınav notunuz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.Write("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.WriteLine("Lütfen Cinsiyet Seçiniz: \n erkek(E) / kadın(K)");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    
    }
}
