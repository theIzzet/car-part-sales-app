

//210229048_İzzetEsener

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ARABALAR
{
    internal class Kullanıcı
    {
        
        // Kullanıcı Adı Bölümü
        private string kullaniciAdi;

        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set
            {
                if (KullaniciAdiKontrol(value))
                {
                    kullaniciAdi = value;
                }
               
                else
                {

                        Console.WriteLine("Incorrect username.Please enter a username that complies with the rules.");

                }
            }
        }



        private bool KullaniciAdiKontrol(string ad)
        {
            // Kullanıcı adı 5 ila 20 karakter arasında olmalıdır.
            if (ad.Length < 5 || ad.Length > 20)
            {
                Console.WriteLine("Usurname cannot be less than 5 character and more than 20 character");
                return false;
            }

            // Kullanıcı adı yalnızca nümerik veya alfabetik karakterler içerebilir.
            foreach (char karakter in ad)
            {
                if (!Char.IsLetterOrDigit(karakter))
                {
                    Console.WriteLine("Username cannot contain anything other than letters and numbers");
                    return false;
                }
            }

            // Kullanıcı adının ilk karakteri alfabetik karakter olmalıdır.
            if (!Char.IsLetter(ad[0]))
            {
                Console.WriteLine("First character of username cannot contain anything other than letter");
                return false;
            }
            if (ad == null)
            {
                Console.WriteLine("This field cannot be left blank ");
                return false;
            }
            

            return true;
        }


        // Maill@

        private string email;

        public string EMail
        {
            get
            { return email; }

            set
            {
                if (emailKontrol(value))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Incorrect E-Mail.Please enter a E-Mail that complies with the rules.");
                }
            }
        }

        private bool emailKontrol(string emailadress)
        {
            if (!emailadress.Contains("@"))
            {
                Console.WriteLine("E-Mail has to contains '@' ");
                return false;
            }
            if (char.IsSymbol(emailadress[0]) || char.IsPunctuation(emailadress[0]))
            {
                Console.WriteLine("First character of E-mail cannot Symbol and Punctuation");
                return false;
            }

            if (emailadress == null)
            {
                Console.WriteLine("This field cannot be left blank ");
                return false;
            }
            return true;
        }



        // İSİM


        private string isim;
        public string Isim
        {
            get { return isim; }
            set
            {
                if (isimKontrol(value))
                {

                    isim = value;
                }
                else
                {
                    Console.WriteLine("Incorrect name.Please enter a name that complies with the rules..");
                }
            }
        }


        private bool isimKontrol(string kullaniciİsmi)
        {
            if (!char.IsLetter(kullaniciİsmi[0]))
            {
                Console.WriteLine("First character of Name has to Letter");
                return false;
            }

            foreach (char karakter in kullaniciİsmi)
            {
                if (char.IsSymbol(karakter) || char.IsPunctuation(karakter))
                {
                    Console.WriteLine(" Name cannot Symbol and Punctuation");
                    return false;
                }
            }
            if (kullaniciİsmi == null)
            {
                Console.WriteLine("This field cannot be left blank ");
                return false;
            }

            return true;

        }




        // Şifre

        private string şifre;

        public string Şifre
        {
            get { return şifre; }

            set
            {
                if (şifreKontrol(value))
                {
                    şifre = value;

                }
                else
                {
                    Console.WriteLine("Incorrect password.Please enter a password that complies with the rules.");
                }
            }
        }

        private bool şifreKontrol(string kullaniciŞifre)
        {
            if (kullaniciŞifre.Length < 8 || kullaniciŞifre.Length > 20)
            {
                Console.WriteLine("Password cannot be less than 8 character and more than 20 character");
                return false;
            }

            if (!kullaniciŞifre.Any(char.IsDigit))
            {
                Console.WriteLine("Password has to contains digit.");
                return false;
            }



            if (!kullaniciŞifre.Any(char.IsUpper))
            {
                Console.WriteLine("Password has to contains upper letter.");
                return false;
            }



            if (!kullaniciŞifre.Any(char.IsLower))
            {
                Console.WriteLine("Password has to contains lower letter.");
                return false;
            }



            if (!kullaniciŞifre.Any(c => "!@#$%&*-+".Contains(c)))
            {
                Console.WriteLine("Password has to contains !@#$%&*-+ .");
                return false;
            }




            if (kullaniciŞifre.Contains(" "))
            {
                Console.WriteLine("Password cannot contain space character .");
                return false;
            }
            if (kullaniciŞifre == null)
            {
                Console.WriteLine("This field cannot be left blank ");
                return false;
            }



            return true;

        }



        // Tel Number

        private string telno;

        public string telNo
        {
            get { return telno; }

            set
            {
                if (telNoKontrol(value))
                {
                    telno = value;
                }

                else
                {
                    Console.WriteLine("Incorrect Phone Number.Please enter a phone Number that complies with the rules.");
                }
            }
        }


        private bool telNoKontrol(string kullanıcıTel)
        {

            if (kullanıcıTel.Any(char.IsLetter))
            {
                Console.WriteLine("phone number must contains ");
                return false;
            }


            if (kullanıcıTel.Length < 12 || kullanıcıTel.Length > 12)
            {

                return false;
            }

            string pattern = @"^\d{3}-\d{3}-\d{4}$";

            if (!Regex.IsMatch(kullanıcıTel, pattern))
            {
                Console.WriteLine("Format of phone number must be xxx-xxx-xxxx.");
                return false;
            }
            if (kullanıcıTel == null)
            {
                Console.WriteLine("This field cannot be left blank ");
                return false;
            }

            return true;

        }


    }
}
