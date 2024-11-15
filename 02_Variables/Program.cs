using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice+" TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram = 1.245;
            //double orangeGram = 2.650;
            //double strGram = 0.750;
            //double potatoGram = 4.859; 
            //double tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strTotalPrice = strGram * strawberryPrice;
            //double potatoTotalPrice= potatoGram * potatoPrice;
            //double tomatoTotalPrice= tomatoGram * tomatoGram;

            //Console.WriteLine("Elma Fiyatı: " + appleTotalPrice);
            //Console.WriteLine("Portakal Fiyatı: " + orangeTotalPrice);
            //Console.WriteLine("Çilek Fiyatı: " + strTotalPrice);
            //Console.WriteLine("Patates Fiyatı: " + potatoTotalPrice);
            //Console.WriteLine("Domates Fiyatı: " + tomatoTotalPrice);

            #endregion
            #region Char Değişkenler   
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);




            #endregion
            #region Klavyeden Veri Girişleri String

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname=Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict=Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity=Console.ReadLine();

            //Console.Write("Yolcu Yaş:");
            //passangerAge = Console.ReadLine();

            //Console.Write("TC: ");
            //passangerIdentityNumber=Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu :" + passangerName + " " + passangerSurname + " " + passangerDistrict + "/" + passangerCity + " " + passangerAge + " " + passangerIdentityNumber);






            #endregion
            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion
            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunuzu giriniz:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunuzu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunuzu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.Write("Ortalama: "+result);

            #endregion
            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion
            Console.Read();
        }
    }
}
