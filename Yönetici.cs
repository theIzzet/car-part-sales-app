

//210229048_İzzetEsener

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARABALAR
{
    internal class Yönetici:Kullanıcı
    {

        public void MusteriSilYoneticiden(Kullanıcı musterKu)
        {
            string anadosyayoluMusteri = "Müşteri.txt";
            string[] satirlar = File.ReadAllLines(anadosyayoluMusteri);
            Console.WriteLine("Enter username of costumer that you want to delete from system");
            musterKu.KullaniciAdi=Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(anadosyayoluMusteri))
            {
                foreach (string satir in satirlar)
                {
                    string[] kullaniciVerileri = satir.Split(',');
                    if (musterKu.KullaniciAdi != kullaniciVerileri[0])
                    {
                        writer.WriteLine($"{kullaniciVerileri[0]},{kullaniciVerileri[1]},{kullaniciVerileri[2]},{kullaniciVerileri[3]},{kullaniciVerileri[4]}");
                    }
                }
            }
            Console.WriteLine("Costumer was deleted");
        }




        public void SaticiSilYoneticiden(Kullanıcı saticiKuAd)
        {

            string anadosyayoluSatici = "Satıcı.txt";
            string[] satirlar = File.ReadAllLines(anadosyayoluSatici);
            Console.WriteLine("Enter username of dealer that you want to delete from system");
            saticiKuAd.KullaniciAdi = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(anadosyayoluSatici))
            {
                foreach (string satir in satirlar)
                {
                    string[] kullaniciVerileri = satir.Split(',');
                    if (saticiKuAd.KullaniciAdi != kullaniciVerileri[0])
                    {
                        writer.WriteLine($"{kullaniciVerileri[0]},{kullaniciVerileri[1]},{kullaniciVerileri[2]},{kullaniciVerileri[3]},{kullaniciVerileri[4]}");
                    }
                }
            }
            Console.WriteLine("Deaaler was deleted");
        }

        public void ArabaSilYoneticiden()
        {
            Satıcı saticidan = new Satıcı();
            saticidan.ArabaSil();
        }



    }
}
