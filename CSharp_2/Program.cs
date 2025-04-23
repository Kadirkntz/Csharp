using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double degişkenler (ondalık)

            //double number = 4.85;
            //Console.WriteLine(number);
            //Console.Read();

            //Console.WriteLine("----PC Parça Fiyatları----");
            //Console.WriteLine();

            //double CPUprice, GPUprice, SSDprice, ATXprice, RAMprice, PSUprice;

            //CPUprice = 12.755;
            //GPUprice = 35.535;
            //SSDprice = 6.555;
            //ATXprice = 8.756;
            //RAMprice = 4.355;
            //PSUprice = 2.482;

            //Console.WriteLine("CPU fiyatı: " + CPUprice + "TL");
            //Console.WriteLine("GPU fiyatı: " + GPUprice + "TL");
            //Console.WriteLine("SSD fiyatı: " + SSDprice + "TL");
            //Console.WriteLine("ATX fiyatı: " + ATXprice + "TL");
            //Console.WriteLine("RAM fiyatı: " + RAMprice + "TL");
            //Console.WriteLine("PSU fiyatı: " + PSUprice + "TL");
            //Console.WriteLine();

            //Double CPUpcs, GPUpcs, SSDpcs, ATXpcs ,RAMpcs ,PSUpcs;

            //CPUpcs = 5;
            //GPUpcs = 10;
            //SSDpcs = 50;
            //ATXpcs = 10;
            //RAMpcs = 75;
            //PSUpcs = 100;

            //Console.WriteLine("CPU fiyatı: " + CPUprice + "-" + "Alınan adet: " + CPUpcs + "       Ödenecek tutar: " + CPUprice * CPUpcs + "TL");
            //Console.WriteLine("GPU fiyatı: " + GPUprice + "-" + "Alınan adet: " + GPUpcs + "       Ödenecek tutar: " + GPUprice * GPUpcs + "TL");
            //Console.WriteLine("SSD fiyatı: " + SSDprice + "-" + "Alınan adet: " + SSDpcs + "       Ödenecek tutar: " + SSDprice * SSDpcs + "TL");
            //Console.WriteLine("ATX fiyatı: " + ATXprice + "-" + "Alınan adet: " + ATXpcs + "       Ödenecek tutar: " + ATXprice * ATXpcs + "TL");
            //Console.WriteLine("RAM fiyatı: " + RAMprice + "-" + "Alınan adet: " + RAMpcs + "       Ödenecek tutar: " + RAMprice * RAMpcs + "TL");
            //Console.WriteLine("PSU fiyatı: " + PSUprice + "-" + "Alınan adet: " + PSUpcs + "       Ödenecek tutar: " + PSUprice * PSUpcs + "TL");

            //Console.WriteLine(); 
            //Console.WriteLine();

            //Double ShopingTotalPrice=CPUpcs * CPUpcs+GPUpcs*GPUprice+SSDprice*SSDpcs+ATXpcs*ATXprice+RAMpcs+RAMprice+PSUpcs*PSUprice;

            //Console.WriteLine("Ödenecek Toplam Tutar: "+ ShopingTotalPrice +"TL");





            //Console.Read();




            #endregion

            #region Char degişkenler (Sembol)

            //char degişkenlerde çift tırnak kullanılmaz.Tek tırnak kullanılır.('')

            //char symbol;

            //symbol = 'A';
            //Console.WriteLine(symbol);
            //Console.Read();

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları ****");
            //Console.WriteLine();

            //string PassengerName, PassengerSurname, PassengerDistrict, PassengerCity, PassengerCountry,PassengerAge,PassangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //PassengerName= Console.ReadLine();

            //Console.Write("Yolcu Soyismi: ");
            //PassengerSurname= Console.ReadLine();

            //Console.Write("İlçe: ");
            //PassengerDistrict= Console.ReadLine();

            //Console.Write("Şehir: ");
            //PassengerCity= Console.ReadLine();

            //Console.Write("Ülke: ");
            //PassengerCountry= Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //PassengerAge= Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //PassangerIdentityNumber= Console.ReadLine();
            //Console.WriteLine();


            //Console.WriteLine("----------Yolcu Bilgileri Özet----------");
            //Console.WriteLine("Yolcu Adı/Soyadı: " + PassengerName +" "+ PassengerSurname);
            //Console.WriteLine("Yolcu Ülke Kimlik Numarası: "+PassangerIdentityNumber ) ;
            //Console.WriteLine("Yolcu Yaşı: "+PassengerAge ) ;
            //Console.WriteLine("Yolculuk Yapılacak Ülke/İl/İlçe: " + PassengerCountry+","+ PassengerCity +","+  PassengerDistrict);



            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümleri

            //ABCDDEF43AGBC

            //int CPUprice, GPUprice, ATXprice, RAMprice;
            //CPUprice = 5000;
            //GPUprice = 15000;
            //ATXprice = 3000;
            //RAMprice = 1500;

            //int CPUpcs,GPUpcs,ATXpcs,RAMpcs;

            //Console.Write("Lütfen alınan CPU adetini girin: ");
            //CPUpcs = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen alınan GPU adetini girin: ");
            //GPUpcs = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen alınan ATX adetini girin: ");
            //ATXpcs = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen alınan RAM adetini girin: ");
            //RAMpcs = int.Parse( Console.ReadLine());

            //int TotalPrice=CPUprice*CPUpcs+GPUprice*GPUpcs+ATXprice*ATXpcs+RAMprice*RAMpcs;

            //Console.WriteLine();

            //Console.WriteLine("Ödenecek Toplam Tutar: " + TotalPrice + "TL");


            #endregion

            #region Klavyeden Ondalık Girişleri ve Dönüşümleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notnu girin: ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notnu girin: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notnu girin: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result=(exam1+exam2+exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karekter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyetinizi E/K olacak şekilde yazınız: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.Write("Seçtigniz Cinsiyet: " + gender);


            #endregion


            Console.Read();

        }
    }
}
