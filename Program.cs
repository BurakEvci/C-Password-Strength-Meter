/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Burak Can Evci
**				ÖĞRENCİ NUMARASI.......: g211210091
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/


using System;
using System.Text.RegularExpressions;

namespace p1
{
    static class SifreUygulaması
    {
        public static int buyukHarfSayisi = 0;
        public static int kucukHarfSayisi = 0;
        public static int rakamSayisi = 0;
        public static int sembolSayisi = 0;


    }

    class Program
    {
        


        static void Main(string[] args)
        {
            
            int puan = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Şifre Kontrolcüsüne Hoş geldiniz.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("UYARI!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Şifrenizde boşluk olmamalıdır.");
            Console.WriteLine("Şifrenizde Türkçe karakterler olmamalıdır.");
            Console.WriteLine("Şifreniz en az 9 karakter olmalıdır.");
            Console.WriteLine("Şifreniz en az 70 puan olmalıdır.");
            Console.WriteLine("Şifrenizde en az bir rakam,sembol,büyük harf,küçük harf olmalıdır.");
            Console.WriteLine("Şifrenizde ]+'/=?_é<>|#½{},;.:!@£$%^&*()[ sembollerini kullanabilirsiniz.");
            Console.ForegroundColor = ConsoleColor.White;
            int tekrar=1;
            // Kullanıcı uygun şifre girmediğinde tekrar şifre istemesi için döngü
            while (tekrar == 1)
            {
                puan = 0;
                Console.WriteLine("Şifrenizi Giriniz:");
                Console.ForegroundColor = ConsoleColor.Blue;
                string sifre;

                sifre = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;


           

                if (sifre.Length < 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Şifre en az 9 haneli olmalıdır!");
                    Console.ForegroundColor = ConsoleColor.White;
                    tekrar = 1;
                }

                if (sifre.Length >= 9)
                {
                    puan += 10;


                    SifreUygulaması.rakamSayisi = Regex.Matches(sifre, @"\d").Count;
                    SifreUygulaması.buyukHarfSayisi = Regex.Matches(sifre, @"[A-Z]").Count;
                    SifreUygulaması.kucukHarfSayisi = Regex.Matches(sifre, @"[a-z]").Count;
                    SifreUygulaması.sembolSayisi = Regex.Matches(sifre, @"[]+'/=?_é<>|#½{},;.:!@£$%^&*()[]").Count;

                    int bosluksayisi = sifre.Length - (SifreUygulaması.rakamSayisi + SifreUygulaması.buyukHarfSayisi + SifreUygulaması.kucukHarfSayisi + SifreUygulaması.sembolSayisi);


                    if (Regex.Matches(sifre, @"\d").Count == 1)
                    {
                        puan += 10;
                    }

                    if (Regex.Matches(sifre, @"\d").Count >= 2)
                    {
                        puan += 20;
                    }

                    if (Regex.Matches(sifre, @"[a-z]").Count == 1)
                    {
                        puan += 10;
                    }

                    if (Regex.Matches(sifre, @"[a-z]").Count >= 2)
                    {
                        puan += 20;
                    }

                    if (Regex.Matches(sifre, @"[A-Z]").Count == 1)
                    {
                        puan += 10;
                    }

                    if (Regex.Matches(sifre, @"[A-Z]").Count >= 2)
                    {
                        puan += 20;
                    }

                    if (Regex.Matches(sifre, @"[]+'/=?_é<>|#½{},;.:!@£$%^&*()[]").Count >= 1)
                    {
                        puan += Regex.Matches(sifre, @"[]+'/=?_é<>|#½{},;.:!@£$%^&*()[]").Count * 10;
                    }




                    if (Regex.Matches(sifre, @"[]+'/=?_é<>|#½{},;.:!@£$%^&*()[]").Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Şifrenizde en az 1 tane sembol olmalıdır!");
                        Console.ForegroundColor = ConsoleColor.White;
                        tekrar = 1;
                    }



                    if (Regex.Matches(sifre, @"[a-z]").Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Şifrenizde en az 1 tane küçük harf olmalıdır!");
                        Console.ForegroundColor = ConsoleColor.White;
                        tekrar = 1;
                    }


                    if (Regex.Matches(sifre, @"[A-Z]").Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Şifrenizde en az 1 tane büyük harf olmalıdır!");
                        Console.ForegroundColor = ConsoleColor.White;
                        tekrar = 1;
                    }


                    if (Regex.Matches(sifre, @"\d").Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Şifrenizde en az 1 tane rakam olmalıdır!");
                        Console.ForegroundColor = ConsoleColor.White;
                        tekrar = 1;
                    }

                    if (bosluksayisi != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Şifrenizde Boşluk Olamaz.Tekrar Şifre Seçiniz.");
                        Console.ForegroundColor = ConsoleColor.White;
                        tekrar = 1;
                    }

                    if (puan < 70 && bosluksayisi == 0 && SifreUygulaması.rakamSayisi >= 1 && SifreUygulaması.buyukHarfSayisi >= 1 && SifreUygulaması.kucukHarfSayisi >= 1 && SifreUygulaması.sembolSayisi >= 1)
                    {
                        
                        Console.WriteLine("Puanınız: " + puan);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Şifreniz 70 puandan küçüktür.Lütfen yeni bir şifre belirleyiniz.");
                        Console.ForegroundColor = ConsoleColor.White;
                        tekrar = 1;
                    }

                    if (puan >= 70 && puan < 90 && bosluksayisi == 0 && SifreUygulaması.rakamSayisi >= 1 && SifreUygulaması.buyukHarfSayisi >= 1 && SifreUygulaması.kucukHarfSayisi >= 1 && SifreUygulaması.sembolSayisi >= 1)
                    {
                        Console.WriteLine("Şifreniz: " + sifre);
                        Console.WriteLine("Puanınız: " + puan);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Şifreniz Zayıftır.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Şifredeki Rakam Sayısı:" + SifreUygulaması.rakamSayisi);
                        Console.WriteLine("Şifredeki Büyük Harf Sayısı:" + SifreUygulaması.buyukHarfSayisi);
                        Console.WriteLine("Şifredeki Küçük Harf Sayısı:" + SifreUygulaması.kucukHarfSayisi);
                        Console.WriteLine("Şifredeki Sembol Sayısı:" + SifreUygulaması.sembolSayisi);
                        Console.ForegroundColor = ConsoleColor.White;
                        tekrar = 0;
                    }

                    if (puan >= 90 && bosluksayisi == 0 && SifreUygulaması.rakamSayisi >= 1 && SifreUygulaması.buyukHarfSayisi >= 1 && SifreUygulaması.kucukHarfSayisi >= 1 && SifreUygulaması.sembolSayisi >= 1)
                    {

                        Console.WriteLine("Şifreniz: " + sifre);
                        Console.WriteLine("Puanınız: " + puan);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Şifreniz Güçlüdür.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Şifredeki Rakam Sayısı:" + SifreUygulaması.rakamSayisi);
                        Console.WriteLine("Şifredeki Büyük Harf Sayısı:" + SifreUygulaması.buyukHarfSayisi);
                        Console.WriteLine("Şifredeki Küçük Harf Sayısı:" + SifreUygulaması.kucukHarfSayisi);
                        Console.WriteLine("Şifredeki Sembol Sayısı:" + SifreUygulaması.sembolSayisi);
                        Console.ForegroundColor = ConsoleColor.White;
                        tekrar = 0;
                    }

                }
            }
        }
    }
}
