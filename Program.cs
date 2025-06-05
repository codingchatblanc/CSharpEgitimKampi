using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{ 
            //    Console.WriteLine("Şifre doğru, hoş geldiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış, lütfen tekrar deneyiniz!");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı!");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi!");
            //}

            //int number;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number == 5)
            //{                 
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine()); 
            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = " (Sonuç vasat)";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = " (Sonuç orta)";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = " (Sonuç iyi)";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = " (Sonuç çok iyi)";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen bir şehir giriniz: ");
            //city = Console.ReadLine(); 

            //if(city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez!");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz!");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı griniz: ");
            //int number2= int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //    {
            //    Console.Write("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir.");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("******* C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------------");

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Ana Yemekler-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("1-Kızartma Tabağı");
            //    Console.WriteLine("1-Fasulye Pilav");
            //    Console.WriteLine("1-Fırında Somon");
            //    Console.WriteLine("1-Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Ana Yemekler-------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Çorbalar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezo Gelin Çorba");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Çorbalar-------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Pizzalar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Pizzalar-------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------İçecekler-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------İçecekler-------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Tatlılar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Tatlılar-------------");

            //    Console.WriteLine();

            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapnız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //    {
            //    case 1:
            //        Console.WriteLine("Ocak ayı 31 gündür.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat ayı 28 gündür.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart ayı 31 gündür.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan ayı 30 gündür.");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs ayı 31 gündür.");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran ayı 30 gündür.");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz ayı 31 gündür.");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos ayı 31 gündür.");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül ayı 30 gündür.");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim ayı 31 gündür.");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım ayı 30 gündür.");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık ayı 31 gündür.");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız!");
            //        break;
            //}


            #endregion

            #region Switch Case - Örnek Proje Uygulaması

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen işlem sembolünü giriniz (+, -, *, /): ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{ 
            
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplama işlemi sonucu: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma işlemi sonucu: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma işlemi sonucu: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme işlemi sonucu: " + result);
            //        break;

            //}

            #endregion

            Console.Read();
        }
    }
}
