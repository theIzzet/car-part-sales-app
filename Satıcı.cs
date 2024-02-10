

//210229048_İzzetEsener


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ARABALAR
{
    internal class Satıcı:Kullanıcı
    {



        // Add to car to system
        public void ArabaEkle(List<Araba> arabalar)
        {
            string ArabaDosya = "Araba.txt";


            Console.WriteLine("Enter the brand of car that you want to add");
            string AMarka = Console.ReadLine();
            Console.WriteLine("Enter the model of car that you want to add");
            string AModel = Console.ReadLine();
            Console.WriteLine("Enter the 1st package of car that you want to add");
            string APaket = Console.ReadLine();
            Console.WriteLine("Enter the 2nd package of car that you want to add");
            string APaket2 = Console.ReadLine();


            
            Dictionary<string,int> Paket1Parçalar = new Dictionary<string,int>();
            Console.WriteLine("How many car parts do you want to add for 1st package");
            int parSay=int.Parse(Console.ReadLine());
            for(int i=0;i<parSay;i++)
            {
                Console.WriteLine("Enter the name of part that you want to add");
                string parIsmi=Console.ReadLine();
                Console.WriteLine("Enter the number of part that you want to add");
                int adet=int.Parse(Console.ReadLine());
                Paket1Parçalar.Add(parIsmi,adet);
            }
           


            Dictionary<string, int> Paket2Parçalar = new Dictionary<string, int>();
            Console.WriteLine("How many car parts do you want to add for 2nd package");
            int parSay2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < parSay2; i++)
            {
                Console.WriteLine("Enter the name of part that you want to add");
                string parIsmi2 = Console.ReadLine();
                Console.WriteLine("Enter the number of part that you want to add");
                int adet2 = int.Parse(Console.ReadLine());
                Paket2Parçalar.Add(parIsmi2, adet2);
            }

            Araba araba = new Araba(AMarka,AModel,APaket,APaket2,Paket1Parçalar,Paket2Parçalar);

            araba.Marka = AMarka;
            araba.Model = AModel;
            araba.Paket = APaket;
            araba.Paket2= APaket2;
            araba.Paket1Parcalar = Paket1Parçalar;
            araba.Paket2Parcalar = Paket2Parçalar;

            arabalar.Add(araba);
            ArabaKaydet(arabalar,ArabaDosya);
            //return arabalar;
            Console.WriteLine("Car was added successfully");

        }

       
        // Register car to File
        // Arabayı Dosyaya kaydediyor
        public void ArabaKaydet(List<Araba> ArabaList, string ArabaDosyal)
        {
              ArabaDosyal = "Araba.txt";

            using (StreamWriter sw = new StreamWriter(ArabaDosyal, true))
            {
                foreach (var satir in ArabaList)
                {
                    foreach (var parca1 in satir.Paket1Parcalar)
                    {
                        sw.WriteLine($"{satir.Marka},{satir.Model},{satir.Paket},{parca1.Key},{parca1.Value}");

                    }
                    foreach (var parca2 in satir.Paket2Parcalar)
                    {
                        sw.WriteLine($"{satir.Marka},{satir.Model},{satir.Paket2},{parca2.Key},{parca2.Value}");

                    }
                  
                }
               
            }

        }





    
        // Update Car imformations

        public void ArabaGuncelle()
        {

           
            Console.WriteLine("\n");



            Console.WriteLine("Enter the Brand of car that you want to update");
            string AMarka = Console.ReadLine();
            Console.WriteLine("Enter the Model of car that you want to update");
            string AModel = Console.ReadLine();
            Console.WriteLine("Enter the Package of car that you want to update");
            string APaket = Console.ReadLine();

            string dosyayolu = "Araba.txt";
            string[] araba= File.ReadAllLines(dosyayolu);

           
         


            List<string> updatedLines = new List<string>(araba); // Değiştirilen satırları saklamak için bir liste

           
                Console.WriteLine("Enter the name of part that you want to update");
                string parIsmi = Console.ReadLine();
                Console.WriteLine("Enter new number");
                int adet = int.Parse(Console.ReadLine());

                for (int j = 0; j < updatedLines.Count(); j++)
                {
                    string[] arabaVerileri = updatedLines[j].Split(',');
                    if (AMarka == arabaVerileri[0] && AModel == arabaVerileri[1] && APaket == arabaVerileri[2] && parIsmi == arabaVerileri[3])
                    {
                        // İlgili satırı güncelle
                        arabaVerileri[arabaVerileri.Length - 1] = adet.ToString();
                        updatedLines[j] = string.Join(",", arabaVerileri);
                        break; // Bu parçayı bulduk, diğer satırları kontrol etmeye gerek yok
                    }
                }
            

            // Dosyaya güncellenmiş satırları yaz
            File.WriteAllLines(dosyayolu, updatedLines);

            Console.WriteLine("Car was updated successfully.");
        }

        //Delete car
        public void ArabaSil()
        {

           
                    Console.WriteLine("Enter the Brand of car that you want to delete");
                    string AMarka = Console.ReadLine();
                    Console.WriteLine("Enter the Model of car that you want to delete");
                    string AModel = Console.ReadLine();
                    Console.WriteLine("Enter the Package of car that you want to delete");
                    string APaket = Console.ReadLine();

                    string dosyayolu = "Araba.txt";
                    string[] araba = File.ReadAllLines(dosyayolu);

                    List<string> remainingLines = new List<string>();

                    for (int i = 0; i < araba.Length; i++)
                    {
                        string[] arabaVerileri = araba[i].Split(',');
                        if (!(AMarka == arabaVerileri[0] && AModel == arabaVerileri[1] && APaket == arabaVerileri[2]))
                        {
                            // Silmek istenmeyen arabaları yeni liste içinde sakla
                            remainingLines.Add(araba[i]);
                        }
                    }

                    // Dosyaya kalan arabaları yaz
                    File.WriteAllLines(dosyayolu, remainingLines);

                    Console.WriteLine("Car was deleted successfully.");
             

          
        }


        // Approve demands
        public void RedKabul()
        {
            //This statement List cars to Compiler
            Console.WriteLine("Cart:");
            string dosyayolu = "Sepet.txt";
            string[] satirlar2 = File.ReadAllLines(dosyayolu);
            foreach (string satir in satirlar2)
            {

                Console.WriteLine(satir);
            }

         
           
            string[] satirlar = File.ReadAllLines(dosyayolu);


            Console.WriteLine("Enter the username of the customer whose transaction you want to approve or reject ");
            string kulad=Console.ReadLine();
            Console.WriteLine("enter 1 to approve, 2 to reject");
            int islem=int.Parse(Console.ReadLine());
            for (int i = 0; i < satirlar.Length; i++)
            {
                string[] kullaniciVerileri = satirlar[i].Split(',');

                if (kullaniciVerileri[0].Contains(kulad))
                {
                    if (islem == 1)
                    {
                        satirlar[i] += ",Transaction successful";
                    }
                    else if (islem == 2)
                    {
                        satirlar[i] += ",Transaction unsuccessful";
                    }
                }
            }
            File.WriteAllLines(dosyayolu, satirlar);
            Console.WriteLine("Transaction successful");


        }

        // Delete your own account
        public void SaticiSil(Kullanıcı saticiAd)
        {
            string anadosyayolu = "Satıcı.txt";
            string[] satirlar = File.ReadAllLines(anadosyayolu);
            using (StreamWriter writer = new StreamWriter(anadosyayolu))
            {
                foreach (string satir in satirlar)
                {
                    string[] kullaniciVerileri = satir.Split(',');
                    if (saticiAd.KullaniciAdi != kullaniciVerileri[0])
                    {
                        writer.WriteLine($"{kullaniciVerileri[0]},{kullaniciVerileri[1]},{kullaniciVerileri[2]},{kullaniciVerileri[3]},{kullaniciVerileri[4]}");
                    }
                }
            }
            Console.WriteLine("Account was deleted");
        }

    }
 }
