
//210229048_İzzetEsener


using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ARABALAR
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Parça tanımlama
            Dictionary<string, int> Momentum = new Dictionary<string, int> { { "Hava Filtresi", 120 }, { "Yağ Filtresi", 19 }, { "Sis Lambası", 24 }, { "Şasi ", 28 }, { "Buji", 45 }, { "Fren Slindiri", 57 }, { "Amartisör ", 94 }, { "Klima Radyatörü", 27 }, { "Stop Lambası", 32 }, { "Motor Filtresi", 9 } };
            Dictionary<string, int> Inscription = new Dictionary<string, int> { { "Hava Filtresi", 75 }, { "Yağ Filtresi", 5 }, { "Sis Lambası", 45 }, { "Şasi ", 14 }, { "Buji", 74 }, { "Fren Slindiri", 7 }, { "Amartisör ", 31 }, { "Klima Radyatörü", 18 }, { "Stop Lambası", 21 }, { "Motor Filtresi", 13 } };
            Dictionary<string, int> AMGLine = new Dictionary<string, int> { { "Hava Filtresi", 62 }, { "Yağ Filtresi", 26 }, { "Sis Lambası", 42 }, { "Şasi ", 22 }, { "Buji", 40 }, { "Fren Slindiri", 117 }, { "Amartisör ", 90 }, { "Klima Radyatörü", 45 }, { "Stop Lambası", 12 }, { "Motor Filtresi", 19 } };
            Dictionary<string, int> ALLTerrain = new Dictionary<string, int> { { "Hava Filtresi", 49 }, { "Yağ Filtresi", 34 }, { "Sis Lambası", 108 }, { "Şasi ", 118 }, { "Buji", 34 }, { "Fren Slindiri", 105 }, { "Amartisör ", 80 }, { "Klima Radyatörü", 44 }, { "Stop Lambası", 122 }, { "Motor Filtresi", 115 } };
            Dictionary<string, int> RLine = new Dictionary<string, int> { { "Hava Filtresi", 67 }, { "Yağ Filtresi", 17 }, { "Sis Lambası", 113 }, { "Şasi ", 103 }, { "Buji", 103 }, { "Fren Slindiri", 38 }, { "Amartisör ", 17 }, { "Klima Radyatörü", 41 }, { "Stop Lambası", 131 }, { "Motor Filtresi", 95 } };
            Dictionary<string, int> Impression = new Dictionary<string, int> { { "Hava Filtresi", 34 }, { "Yağ Filtresi", 61 }, { "Sis Lambası", 77 }, { "Şasi ", 74 }, { "Buji", 106 }, { "Fren Slindiri", 84 }, { "Amartisör ", 25 }, { "Klima Radyatörü", 22 }, { "Stop Lambası", 15 }, { "Motor Filtresi", 14 } };
            Dictionary<string, int> MomGrandTouringentum = new Dictionary<string, int> { { "Hava Filtresi", 55 }, { "Yağ Filtresi", 88 }, { "Sis Lambası", 32 }, { "Şasi ", 28 }, { "Buji", 147 }, { "Fren Slindiri", 57 }, { "Amartisör ", 142 }, { "Klima Radyatörü", 27 }, { "Stop Lambası", 13 }, { "Motor Filtresi", 29 } };
            Dictionary<string, int> Signature = new Dictionary<string, int> { { "Hava Filtresi", 38 }, { "Yağ Filtresi", 30 }, { "Sis Lambası", 70 }, { "Şasi ", 75 }, { "Buji", 135 }, { "Fren Slindiri", 64 }, { "Amartisör ", 32 }, { "Klima Radyatörü", 79 }, { "Stop Lambası", 17 }, { "Motor Filtresi", 174 } };
            Dictionary<string, int> EXL = new Dictionary<string, int> { { "Hava Filtresi", 110 }, { "Yağ Filtresi", 29 }, { "Sis Lambası", 40 }, { "Şasi ", 32 }, { "Buji", 21 }, { "Fren Slindiri", 69 }, { "Amartisör ", 11 }, { "Klima Radyatörü", 69 }, { "Stop Lambası", 36 }, { "Motor Filtresi", 63 } };
            Dictionary<string, int> Touring = new Dictionary<string, int> { { "Hava Filtresi", 86 }, { "Yağ Filtresi", 37 }, { "Sis Lambası", 60 }, { "Şasi ", 123 }, { "Buji", 174 }, { "Fren Slindiri", 74 }, { "Amartisör ", 88 }, { "Klima Radyatörü", 130 }, { "Stop Lambası", 25 }, { "Motor Filtresi", 65 } };

            Dictionary<string, int> Titanium = new Dictionary<string, int> { { "Hava Filtresi", 21 }, { "Yağ Filtresi", 43 }, { "Sis Lambası", 50 }, { "Şasi ", 89 }, { "Buji", 118 }, { "Fren Slindiri", 25 }, { "Amartisör ", 111 }, { "Klima Radyatörü", 140 }, { "Stop Lambası", 175 }, { "Motor Filtresi", 24 } };
            Dictionary<string, int> TrandX = new Dictionary<string, int> { { "Hava Filtresi", 30 }, { "Yağ Filtresi", 23 }, { "Sis Lambası", 115 }, { "Şasi ", 23 }, { "Buji", 130 }, { "Fren Slindiri", 37 }, { "Amartisör ", 117 }, { "Klima Radyatörü", 180 }, { "Stop Lambası", 18 }, { "Motor Filtresi", 17 } };
            Dictionary<string, int> M550ixDrive = new Dictionary<string, int> { { "Hava Filtresi", 72 }, { "Yağ Filtresi", 11 }, { "Sis Lambası", 17 }, { "Şasi ", 27 }, { "Buji", 127 }, { "Fren Slindiri", 22 }, { "Amartisör ", 109 }, { "Klima Radyatörü", 66 }, { "Stop Lambası", 92 }, { "Motor Filtresi", 24 } };
            Dictionary<string, int> Competition = new Dictionary<string, int> { { "Hava Filtresi", 36 }, { "Yağ Filtresi", 12 }, { "Sis Lambası", 6 }, { "Şasi ", 5 }, { "Buji", 137 }, { "Fren Slindiri", 151 }, { "Amartisör ", 25 }, { "Klima Radyatörü", 55 }, { "Stop Lambası", 19 }, { "Motor Filtresi", 90 } };
            Dictionary<string, int> QuattroStronic = new Dictionary<string, int> { { "Hava Filtresi", 14 }, { "Yağ Filtresi", 9 }, { "Sis Lambası", 2 }, { "Şasi ", 1 }, { "Buji", 155 }, { "Fren Slindiri", 141 }, { "Amartisör ", 39 }, { "Klima Radyatörü", 52 }, { "Stop Lambası", 97 }, { "Motor Filtresi", 37 } };
            Dictionary<string, int> QuattroTiptronic = new Dictionary<string, int> { { "Hava Filtresi", 71 }, { "Yağ Filtresi", 1 }, { "Sis Lambası", 81 }, { "Şasi ", 10 }, { "Buji", 112 }, { "Fren Slindiri", 104 }, { "Amartisör ", 36 }, { "Klima Radyatörü", 31 }, { "Stop Lambası", 102 }, { "Motor Filtresi", 16 } };
            Dictionary<string, int> Urban = new Dictionary<string, int> { { "Hava Filtresi", 92 }, { "Yağ Filtresi", 15 }, { "Sis Lambası", 66 }, { "Şasi ", 23 }, { "Buji", 28 }, { "Fren Slindiri", 20 }, { "Amartisör ", 63 }, { "Klima Radyatörü", 21 }, { "Stop Lambası", 138 }, { "Motor Filtresi", 83 } };
            Dictionary<string, int> Loung = new Dictionary<string, int> { { "Hava Filtresi", 20 }, { "Yağ Filtresi", 24 }, { "Sis Lambası", 45 }, { "Şasi ", 14 }, { "Buji", 23 }, { "Fren Slindiri", 16 }, { "Amartisör ", 67 }, { "Klima Radyatörü", 23 }, { "Stop Lambası", 126 }, { "Motor Filtresi", 119 } };
            Dictionary<string, int> SX = new Dictionary<string, int> { { "Hava Filtresi", 3 }, { "Yağ Filtresi", 44 }, { "Sis Lambası", 32 }, { "Şasi ", 17 }, { "Buji", 57 }, { "Fren Slindiri", 100 }, { "Amartisör ", 72 }, { "Klima Radyatörü", 7 }, { "Stop Lambası", 128 }, { "Motor Filtresi", 117 } };
            Dictionary<string, int> EX = new Dictionary<string, int> { { "Hava Filtresi", 33 }, { "Yağ Filtresi", 8 }, { "Sis Lambası", 17 }, { "Şasi ", 38 }, { "Buji", 56 }, { "Fren Slindiri", 51 }, { "Amartisör ", 79 }, { "Klima Radyatörü", 78 }, { "Stop Lambası", 4 }, { "Motor Filtresi", 33 } };
            //Parça tanımlama





            Araba araba1 = new Araba("VOLVO", "XC:90", "Momentum", "Inscription", Momentum, Inscription);
            Araba araba2 = new Araba("Mercedes Benz", "E Class", "E350 AMG Line", "E-Class All-Terrain", AMGLine, ALLTerrain);
            Araba araba3 = new Araba("Wolkswagen", "Golf", "R-Line", "Impression", RLine, Impression);
            Araba araba4 = new Araba("Mazda", "CX-5", "Grand Touring", "Signature", MomGrandTouringentum, Signature);
            Araba araba5 = new Araba("Honda", "Civic", "EX-L", "Touring", EXL, Touring);
            Araba araba6 = new Araba("Ford", "Focus", "Titanium", "Trend X", Titanium, TrandX);
            Araba araba7 = new Araba("BMW", "M5", "M550i xDrive", "Competition", M550ixDrive, Competition);
            Araba araba8 = new Araba("Audi", "A7", "Quattro S tronic", "Quattro Tiptronic", QuattroStronic, QuattroTiptronic);
            Araba araba9 = new Araba("Fiat", "Egea", "Urban", "Lounge", Urban, Loung);
            Araba araba10 = new Araba("Kia", "Telluride", "SX", "EX", SX, EX);


           

            //List<Araba> ArabaList = new List<Araba> { araba1, araba2, araba3, araba4, araba5, araba6, araba7, araba8, araba9, araba10 };
            List<Araba>ArabaList=new List<Araba>();
            





            Musteri musteri1 = new Musteri();
            Satıcı saticilar=new Satıcı();
            Yönetici yoneticii=new Yönetici();
           
           


           




            // *Polimorfizm

            Kullanıcı musteri = new Musteri();

            Kullanıcı yonetici = new Yönetici();

            Kullanıcı satici = new Satıcı();


            // *Polimorfizm


           
            



            
          

            // File path
            //DOSYA YOLU
            string KullaniciDosya = "Müşteri.txt";
            string KullaniciDosya2 = "Satıcı.txt";
            string KullaniciDosya3 = "Yönetici.txt";
            string ArabaDosya = "Araba.txt";


          


            Console.WriteLine("1-Costumer Login ");
            Console.WriteLine("2-Dealer Login ");
            Console.WriteLine("3-Admin Login ");
            Console.WriteLine("4-Sigin");

            int n = int.Parse(Console.ReadLine());

            Console.Clear();



            if (n == 1) {
                Console.WriteLine("Costumer Login:");

                MusteriGiris();
                
                Console.Clear() ;
                Kullanıcı girisYapan = MusteriGirisYapVarMi();
                if (girisYapan != null)
                {
                    Console.WriteLine("Login successful");
                    Console.WriteLine($"Welcome {girisYapan}");
                    do
                    {
                        Console.WriteLine("1-List Cars:");
                        Console.WriteLine("2-Add to Cart:");
                        Console.WriteLine("3-View of My Cart:");
                        Console.WriteLine("4-Deleting Account:");
                        Console.WriteLine("5-Exit");
                        Console.WriteLine("Please select the option you want to perform");
                        int k = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (k == 1)
                        {
                            
                            musteri1.ArabaListele();

                        }
                        else if (k == 2)
                        {
                            musteri1.SepeteEkle(girisYapan);
                        }
                        else if (k == 3)
                        {
                            Console.WriteLine("Cart:");
                            musteri1.List_cart(girisYapan);
                        }
                        else if (k == 4)
                        {
                            musteri1.MusteriSil(girisYapan);
                        }
                        else if (k == 5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You entered an invalid transaction.Please try again..");
                        }
                    }while (true);

                }

            }
            else if (n == 2)
            {
                Console.WriteLine("Dealer Login:");
                SaticiGiris();
                Console.Clear();
                Kullanıcı girisYapanSatici = SaticiGirisYapVarMi();
                if (girisYapanSatici!=null)
                {
                    Console.WriteLine($"Welcome {girisYapanSatici}");
                    Console.WriteLine("Login successful");

                    do
                    {
                        Console.WriteLine("1-Add Car");
                        Console.WriteLine("2-Update Car Piece");
                        Console.WriteLine("3-Delete Car");
                        Console.WriteLine("4-Demand Approve Transaction");
                        Console.WriteLine("5-Delete My Account");
                        Console.WriteLine("6-Exit");
                        Console.WriteLine("Please select the option you want to perform");

                        int islem = int.Parse(Console.ReadLine());
                        Console.Clear();
                        
                        if (islem == 1)
                        {
                            saticilar.ArabaEkle(ArabaList);
                        }
                        else if (islem == 2)
                        {
                            musteri1.ArabaListele();
                            saticilar.ArabaGuncelle();
                           
                        }
                        else if (islem == 3)
                        {
                            musteri1.ArabaListele();

                            saticilar.ArabaSil();
                        }
                        else if (islem == 4)
                        {
                            saticilar.RedKabul();
                            DepodanDus();
                        }
                        else if (islem == 5)
                        {
                            saticilar.SaticiSil(girisYapanSatici);
                        }
                        else if(islem == 6)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You entered an invalid transaction.Please try again..");
                        }

                    } while (true);


                }
                
            }
            else if (n == 3)
            {
                Console.WriteLine("Admin Login:");

                YoneticiGiris();
                Console.Clear();
                Kullanıcı girisYapanYonetici= YoneticiGirisYapVarMi();

                
                if (girisYapanYonetici!=null)
                {
                    Console.WriteLine($"Welcome {girisYapanYonetici}");
                    Console.WriteLine("Login successful");
                    
                    do
                    {

                       
                        Console.WriteLine("1-Delete Customer");
                        Console.WriteLine("2-Delete Dealer");
                        Console.WriteLine("3-Delete Car");
                        Console.WriteLine("4-Exit");
                       
                        Console.WriteLine("Please select the option you want to perform");

                        int islem = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (islem == 1)
                        {
                            yoneticii.MusteriSilYoneticiden(musteri1);
                            Console.WriteLine("Costumer was deleted ");
                        }
                        else if (islem == 2)
                        {
                            yoneticii.SaticiSilYoneticiden(saticilar);
                            
                        }
                        else if (islem == 3)
                        {
                            yoneticii.ArabaSilYoneticiden();
                          
                        }
                        else if (islem == 4)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You entered an invalid transaction.Please try again.");
                        }

                    }while(true);
                }

            }
            else if (n == 4)
            {

                Console.WriteLine("Sigin :");
                Console.WriteLine("1-Costumer Sigin:");
                Console.WriteLine("2-Dealer Sigin: ");
                Console.WriteLine("3-Admin Sigin:");

                int x = int.Parse(Console.ReadLine());
                Console.Clear();

                if (x == 1)
                {
                    Console.WriteLine("Costumer Sigin:\n");
                    MusteriGirisKayit();
                    SaveCustomerToFile();

                }
                else if (x == 2)
                {

                    Console.WriteLine("Dealer Sigin:\n");
                    SaticiGirisKayit();
                    SatıcıKayitIslemi();
                }
                else if (x == 3)
                {
                    Console.WriteLine("Admin Sigin:\n");
                    YoneticiGirisKayit();
                    YoneticiKayitIslemi();
                }

            }

            //Customer Login
            void MusteriGiris()
            {
                Console.WriteLine("Enter user information \n");


                do
                {



                    Console.WriteLine("User Name: ");
                    musteri.KullaniciAdi = Console.ReadLine();

                  

                } while (musteri.KullaniciAdi == null);

                do
                {


                    Console.WriteLine("Password: ");
                    musteri.Şifre = Console.ReadLine();

                } while (musteri.Şifre == null);

            }

            //Dealer Login
            void SaticiGiris()
            {
                Console.WriteLine("Enter user information \n");


                do
                {

                    Console.WriteLine("Username: ");
                    satici.KullaniciAdi = Console.ReadLine();

                    if (satici.KullaniciAdi == null)
                    {
                        Console.WriteLine("");
                    }

                } while (satici.KullaniciAdi == null);


                do
                {


                    Console.WriteLine("Password: ");
                    satici.Şifre = Console.ReadLine();

                } while (satici.Şifre == null);

            }

            //Admin Login
            void YoneticiGiris()
            {
                Console.WriteLine("Enter user information \n");


                do
                {



                    Console.WriteLine("Username: ");
                    yonetici.KullaniciAdi = Console.ReadLine();

                    if (yonetici.KullaniciAdi == null)
                    {
                        Console.WriteLine("Bu alan boş bırakılamaz");
                    }

                } while (yonetici.KullaniciAdi == null);

                do
                {


                    Console.WriteLine("Password: ");
                    yonetici.Şifre = Console.ReadLine();

                } while (yonetici.Şifre == null);

            }


            // Custoemr Signup
            void MusteriGirisKayit()
            {
                Console.WriteLine("Enter user information \n");

                do
                {


                    Console.WriteLine("Username: ");
                    musteri.KullaniciAdi = Console.ReadLine();


                 

                } while (KullaniciAdiVarMi(musteri.KullaniciAdi) || musteri.KullaniciAdi==null);



                do
                {


                    Console.WriteLine("E-mail: ");
                    musteri.EMail = Console.ReadLine();

                } while (musteri.EMail == null);


                do
                {


                    Console.WriteLine("Password: ");
                    musteri.Şifre = Console.ReadLine();

                } while (musteri.Şifre == null);


                do
                {

                    Console.WriteLine("Name: ");
                    musteri.Isim = Console.ReadLine();

                } while (musteri.Isim == null);



                do
                {

                    Console.WriteLine("Phone Number: ");
                    musteri.telNo = Console.ReadLine();


                } while (musteri.telNo == null);

                Console.WriteLine("Costumer was enrolled");

            }


            //Dealer Signup

            void SaticiGirisKayit()
            {
                Console.WriteLine("Enter user information \n");
                do
                {
                    

                    Console.WriteLine("Username: ");
                    satici.KullaniciAdi = Console.ReadLine();

                  

                } while (KullaniciAdiVarMi(satici.KullaniciAdi) || satici.KullaniciAdi == null);



                do
                {


                    Console.WriteLine("E-mail: ");
                    satici.EMail = Console.ReadLine();

                } while (satici.EMail == null);


                do
                {


                    Console.WriteLine("Password: ");
                    satici.Şifre = Console.ReadLine();

                } while (satici.Şifre == null);


                do
                {

                    Console.WriteLine("Name: ");
                    satici.Isim = Console.ReadLine();

                } while (satici.Isim == null);



                do
                {

                    Console.WriteLine("Phone Number: ");
                    satici.telNo = Console.ReadLine();


                } while (satici.telNo == null);

                Console.WriteLine("Dealer was enrolled");


            }


            // Admin Signup
            void YoneticiGirisKayit()
            {
                Console.WriteLine("Enter user information \n");

                do
                {



                    Console.WriteLine("Username: ");
                    yonetici.KullaniciAdi = Console.ReadLine();


                } while (KullaniciAdiVarMi(yonetici.KullaniciAdi) || yonetici.KullaniciAdi == null);



                do
                {


                    Console.WriteLine("E-mail: ");
                    yonetici.EMail = Console.ReadLine();

                } while (yonetici.EMail == null);


                do
                {


                    Console.WriteLine("Password: ");
                    yonetici.Şifre = Console.ReadLine();

                } while (yonetici.Şifre == null);


                do
                {

                    Console.WriteLine("Name: ");
                    yonetici.Isim = Console.ReadLine();

                } while (yonetici.Isim == null);



                do
                {

                    Console.WriteLine("Phone Number: ");
                    yonetici.telNo = Console.ReadLine();


                } while (yonetici.telNo == null);

                Console.WriteLine("Admin was enrolled");

            }



            void SaveCustomerToFile()
                 {
                   
                    using (StreamWriter sw = new StreamWriter(KullaniciDosya,true))
                    {
                    
                    sw.WriteLine($"{musteri.KullaniciAdi},{musteri.EMail},{musteri.Şifre},{musteri.Isim},{musteri.telNo}");

                 }
                 }

                
            
                 void SatıcıKayitIslemi()
                 {
                   
                    using (StreamWriter sw = new StreamWriter(KullaniciDosya2,true))
                    {
                        sw.WriteLine($"{satici.KullaniciAdi},{satici.EMail},{satici.Şifre},{satici.Isim},{satici.telNo}");
                       
                       
                    }
                 }
                 void YoneticiKayitIslemi()
                 {
                   
                    using (StreamWriter sw = new StreamWriter(KullaniciDosya3,true))
                    {
                    sw.WriteLine($"{yonetici.KullaniciAdi},{yonetici.EMail},{yonetici.Şifre},{yonetici.Isim},{yonetici.telNo}");
                  }
                 }


            // It checks the customer where it is exist in warehouse
            Kullanıcı MusteriGirisYapVarMi()
            {
                string dosyayolu = "Müşteri.txt";

                foreach (string satir in File.ReadLines(dosyayolu))
                {
                    string[] kullaniciVerileri = satir.Split(',');
                    if(musteri.KullaniciAdi == kullaniciVerileri[0] && musteri.Şifre == kullaniciVerileri[2])
                    {
                        //Tekrar incelenecek
                        musteri.EMail = kullaniciVerileri[1];
                        musteri.Isim = kullaniciVerileri[3];
                        musteri.telNo = kullaniciVerileri[4];
                        return musteri;
                    }
                    
                }



                Console.WriteLine("Such a user don't exists");
                return null;
            }

            // It checks the username where it is exist in text
            //Dosyada kullanıcın girdiği kullanıcı adı mevcut olup olmadığını kontrol ediyor
            bool KullaniciAdiVarMi(string kullaniciAdi)
            {
               

                if (File.Exists(KullaniciDosya))
                {
                    foreach (string satir in File.ReadLines(KullaniciDosya))
                    {
                        string[] kullaniciVerileri = satir.Split(',');
                        if (musteri.KullaniciAdi == kullaniciVerileri[0] || satici.KullaniciAdi== kullaniciVerileri[0] || yonetici.KullaniciAdi == kullaniciVerileri[0])
                        {
                            Console.WriteLine("Such a username already exists. Choose another username");

                            return true;

                        }

                    }
                    foreach (string satir in File.ReadLines(KullaniciDosya2))
                    {
                        string[] kullaniciVerileri = satir.Split(',');
                        if (musteri.KullaniciAdi == kullaniciVerileri[0] || satici.KullaniciAdi == kullaniciVerileri[0] || yonetici.KullaniciAdi == kullaniciVerileri[0])
                        {
                            Console.WriteLine("Such a username already exists. Choose another username.");

                            return true;

                        }
                    }

                    foreach (string satir in File.ReadLines(KullaniciDosya3))
                    {
                        string[] kullaniciVerileri = satir.Split(',');
                        if (musteri.KullaniciAdi == kullaniciVerileri[0] || satici.KullaniciAdi == kullaniciVerileri[0] || yonetici.KullaniciAdi == kullaniciVerileri[0])
                        {
                            Console.WriteLine("Such a username already exists. Choose another username.");

                            return true;

                        }
                    }
                }

                return false;
            }
            // It checks the dealer where it is exist in warehouse
            Kullanıcı SaticiGirisYapVarMi()
            {
                string dosyayolu = "Satıcı.txt";
               
                foreach (string satir in File.ReadLines(dosyayolu))
                {
                    string[] kullaniciVerileri = satir.Split(',');
                    if (satici.KullaniciAdi == kullaniciVerileri[0] && satici.Şifre == kullaniciVerileri[2])
                    {
                        //Tekrar incelenecek
                        satici.EMail = kullaniciVerileri[1];
                        satici.Isim = kullaniciVerileri[3];
                        satici.telNo = kullaniciVerileri[4];
                        return satici;
                    }
                }

                Console.WriteLine("There is no such user");
                return null;
            }
            // It checks the Admin where it is exist in warehouse
            // Bu fonksiyon Yönetici giriş yaptığında var mı diye kontrol ediyor
            Kullanıcı YoneticiGirisYapVarMi()
            {
                foreach (string satir in File.ReadLines(KullaniciDosya3))
                {
                    string[] kullaniciVerileri = satir.Split(',');
                    if (yonetici.KullaniciAdi == kullaniciVerileri[0] && yonetici.Şifre == kullaniciVerileri[2])
                    {
                       
                        yonetici.EMail = kullaniciVerileri[1];
                        yonetici.Isim = kullaniciVerileri[3];
                        yonetici.telNo = kullaniciVerileri[4];
                        return yonetici;
                    }
                }
                Console.WriteLine("There is no such user");
                return null;
            }




            // If purchase is successfull,it will drop from the warehouse equal to the number of parts the customer purchased
            // Bu fonksiyon satın alım işlemi olumluysa depodan parça adedini düşüyor
            void DepodanDus()
            {
                string sepetDosya = "Sepet.txt";
                string arabaDosya = "Araba.txt";

                string[] sepetSatirlar = File.ReadAllLines(sepetDosya);
                string[] arabaSatirlar = File.ReadAllLines(arabaDosya);

                foreach (string sepetSatir in sepetSatirlar)
                {
                    if (sepetSatir.Contains("Transaction successful"))
                    {
                        string[] sepetVerileri = sepetSatir.Split(',');

                        string AMarka = sepetVerileri[1];
                        string AModel = sepetVerileri[2];
                        string APaket = sepetVerileri[3];
                        string parIsmi = sepetVerileri[4];
                        int parSay = int.Parse(sepetVerileri[5]);

                        for (int i = 0; i < arabaSatirlar.Length; i++)
                        {
                            string[] arabaVerileri = arabaSatirlar[i].Split(',');

                            if (AMarka == arabaVerileri[0] && AModel == arabaVerileri[1] && APaket == arabaVerileri[2])
                            {
                                int stokAdet = int.Parse(arabaVerileri[4]);
                                if (arabaVerileri[3] == sepetVerileri[4])
                                {
                                    int yeniStokAdet = stokAdet - parSay;

                                    
                                    // If the number of parts ordered by the customer is more than what is in the warehouse, the transaction will not be processed.
                                    // Eğer müşterinin sipariş ettiği parça sayısı eğer depodakinden fazla ise işlem gerçekleşmez
                                    if (yeniStokAdet < 0)
                                    {
                                        Console.WriteLine("Error: Insufficient stock for the part.");
                                        return;
                                    }

                                    arabaSatirlar[i] = $"{AMarka},{AModel},{APaket},{arabaVerileri[3]},{yeniStokAdet}";
                                    break;
                                }
                                
                            }
                        }
                    }
                }

                File.WriteAllLines(arabaDosya, arabaSatirlar);
                Console.WriteLine("Stock update successful");
            }


            Console.ReadKey();
        }
    }
}