//Author:SercanCelenk

using System;

namespace StatikConst
{
    class Kullanici
    {
        private static int kullanicisayisi;
        public static int KullaniciSayisi { get { return kullanicisayisi; } }

        private string Nick;
        private string EMail;

        static Kullanici()
        {
            kullanicisayisi = 0;
        }

        public Kullanici(string Nick, string EMail)
        {
            this.Nick = Nick;
            this.EMail = EMail;
            kullanicisayisi++;
        }

        ~Kullanici()
        {
            kullanicisayisi--;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            // Online Kullanıcı Sayısı:0
            Console.WriteLine("Online Kullanıcı Sayısı:{0}", Kullanici.KullaniciSayisi);

            Kullanici k1 = new Kullanici("Sercan Celenk", "sercan@iletisim.com\n");
            Kullanici k2 = new Kullanici("Seyma Karakaya", "seyma@iletisim.com\n");

            // Online Kullanıcı Sayısı:2
            Console.WriteLine("Online Kullanıcı Sayısı:{0}", Kullanici.KullaniciSayisi);
        }
        }
    }

