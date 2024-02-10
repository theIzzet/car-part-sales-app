
//210229048_İzzetEsener


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARABALAR
{
    internal class Musteri:Kullanıcı
    {

        // List cars
        // Arabaları Listeleyebildiğimiz fonksiyon
        public void ArabaListele()
        {
            string dosyayolu = "Araba.txt";
            string[] araba = File.ReadAllLines(dosyayolu);

            Console.WriteLine("Car List:");

            foreach (string satir in araba)
            {
                string[] arabaVerileri = satir.Split(',');

                if (arabaVerileri.Length >= 5)
                {
                    Console.Write($"{arabaVerileri[0]} {arabaVerileri[1]} {arabaVerileri[2]} {arabaVerileri[3]} {arabaVerileri[4]}");
                }

                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }





        // Add to cart the parts by customer

        //Müşterinin sepete ekleme fonksiyonu
        public void SepeteEkle(Kullanıcı MusAdi)
        {

            ArabaListele();
            Console.WriteLine("\n");
          

            string sepetdosya = "Sepet.txt";

            
            
            Console.WriteLine("Enter the Brand of car that you want to add to cart");
            string AMarka = Console.ReadLine();
            Console.WriteLine("Enter the Model of car that you want to add to cart");
            string AModel = Console.ReadLine();
            Console.WriteLine("Enter the Package of car that you want to add to cart");
            string APaket = Console.ReadLine();

            Console.WriteLine("Enter the name of the part you want to add to the cart");
            string parIsmi = Console.ReadLine();

            Console.WriteLine("Enter the number of the part you want to add to the cart");
            int parSay = int.Parse(Console.ReadLine());

            string dosyayolu = "Araba.txt";
            string[] araba = File.ReadAllLines(dosyayolu);



            bool arabaBulundu = false;

            foreach (var satir in araba)
            {
                string[] arabaVerileri = satir.Split(',');

                if (AMarka == arabaVerileri[0] && AModel == arabaVerileri[1] && APaket == arabaVerileri[2])
                {
                    arabaBulundu = true;
                    break; // Arabayı bulduk, döngüden çık
                }
            }

                using (StreamWriter sw = new StreamWriter(sepetdosya, true))
                {
                    sw.WriteLine($"{MusAdi.KullaniciAdi},{AMarka},{AModel},{APaket},{parIsmi},{parSay}");
                }

                Console.WriteLine("Transaction successfull");
           

            Console.WriteLine("Enter 1 to buy");
            int al=int.Parse(Console.ReadLine());
            if (al == 1)
            {
                Console.WriteLine("Demand was sent");
            }
           

        }







        //User can see sphares and numbers in sepet because of this function.
        public void List_cart(Kullanıcı MuAd)
        {
            string dosyayolu = "Sepet.txt";

            string[] satirlar = File.ReadAllLines(dosyayolu);
            foreach (string satir in satirlar)
            {
                if (satir.Contains(MuAd.KullaniciAdi))
                {

                    Console.WriteLine(satir);
                }
            }
        }







        // Delete your own customer dealer
        public void MusteriSil(Kullanıcı musAd) // Directed by Abdullah Zengin 
        {
            string anadosyayolu = "Müşteri.txt";
            string[] satirlar = File.ReadAllLines(anadosyayolu);
            using (StreamWriter writer =new StreamWriter(anadosyayolu))
            {
                foreach(string satir in satirlar)
                {
                    string[] kullaniciVerileri = satir.Split(',');
                    if(musAd.KullaniciAdi != kullaniciVerileri[0])
                    {
                        writer.WriteLine($"{kullaniciVerileri[0]},{kullaniciVerileri[1]},{kullaniciVerileri[2]},{kullaniciVerileri[3]},{kullaniciVerileri[4]}");
                    }
                }
            }
            Console.WriteLine("Your account was deleted");
        }
    }
}
