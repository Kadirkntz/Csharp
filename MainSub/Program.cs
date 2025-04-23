using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhabalar Aq");
            //Console.Write("Selam");

            //Console.WriteLine("***** PC Parçaları *****");
            //    Console.WriteLine();
            //Console.WriteLine("1-CPU");
            //Console.WriteLine("2-GPU");
            //Console.WriteLine("3-Bellek");
            //Console.WriteLine("4-Anakart");
            //Console.WriteLine("5-SSD");
            //Console.WriteLine("6-PSU");
            //Console.WriteLine();
            //Console.WriteLine("***** PC Parçaları *****");


            //Console.Read();
            #endregion

            #region StringDeğişkenler

            //String
            //Değişkenin_Türü Değişkenin_Adı

            //String name;
            //name = "Kadir";
            //Console.Write(name);

            //String CostumerName;    
            //String CostumerSurname;
            //String CostumerPhone;
            //String CostumerEmail, district, city;

            //CostumerName = "Kadir";
            //CostumerSurname = "Kanıtez";
            //CostumerPhone = "+90 546 546 46 46";
            //CostumerEmail = "kadir@gmail.com";
            //district = "Mamak";
            //city = "Ankara";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + CostumerName + " " + CostumerSurname );
            //Console.WriteLine("İletişim/Mail: " + CostumerPhone +"/" + CostumerEmail);
            //Console.WriteLine("Adres: " + city + "/" + district);
            //Console.WriteLine();
            //Console.WriteLine("***** Rezervasyon Kartı *****");

            //Console.WriteLine("----------------------------------------------------");

            //String CostumerName1;
            //String CostumerSurname1;
            //String CostumerPhone1;
            //String CostumerEmail1;
            //String district1;
            //String city1;

            //CostumerName1 = "Koray";
            //CostumerSurname1 = "Boztepe";
            //CostumerPhone1 = "+90 500 400 40 20";
            //CostumerEmail1 ="koray@gmail.com";
            //district1 = "Ankara";
            //city1 = "Çankaya";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + CostumerName1 + "/" + CostumerSurname1);
            //Console.WriteLine("İletişim/Mail" + CostumerPhone1 + "/" + CostumerEmail1);
            //Console.WriteLine("Adres: " + city1 + "/" + district1);
            //Console.WriteLine();
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------");

            #endregion

            #region INT Değişkenler Tam sayı

            //int

            //int number = 24;
            //Console.WriteLine(number);

            int HamburgerPrice = 450;
            int CokePrice = 75;
            int FriesPrice = 100;
            int PizzaPrice = 300;
            int WaterPrice = 20;

            Console.WriteLine("****Restorant Fiyatları****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + HamburgerPrice + "TL");
            Console.WriteLine("-----Kola: " + CokePrice + "TL");
            Console.WriteLine("-----Kızartma: " + FriesPrice + "TL");
            Console.WriteLine("-----Pizza: " + PizzaPrice + "TL");
            Console.WriteLine();

            int HamburgerCount = 4;
            int CokeCount = 4;
            int FriesCount = 2;
            int PizzaCount = 2;
            int WaterCount = 4;

            Console.WriteLine("****Fiş****");
            Console.WriteLine();
            Console.WriteLine("Toplam hamburger fiyatı: " + HamburgerCount * HamburgerPrice + "TL");
            Console.WriteLine("Toplam kola fiyatı: " + CokeCount * CokePrice + "TL");
            Console.WriteLine("Toplam kızartma fiyatı: " + FriesCount * FriesPrice + "TL");
            Console.WriteLine("Toplam pizza fiyatı: " + PizzaCount * PizzaPrice + "TL");
            Console.WriteLine("Toplam su fiyatı: " + WaterCount * WaterPrice + "TL");

            Console.WriteLine();

            int TotalPrice=HamburgerCount*HamburgerPrice+CokeCount*CokePrice+FriesCount*FriesPrice+PizzaCount*PizzaPrice+WaterCount*WaterPrice;

            Console.WriteLine("Ödenecek Toplam Tutar: "+TotalPrice+ "TL");




            #endregion
            
            
            
            Console.Read();
        }
    }
}




//Yazdırma Komutları
