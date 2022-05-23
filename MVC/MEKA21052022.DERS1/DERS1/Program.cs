using DERS1.CheckEquality;
using DERS1.Kalitim;
using DERS1.Ornekler;
using System;

namespace DERS1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlamalar
            /* 1byte (0,255 arasındaki tam sayı değerleri verilebilir.)
             * 1sbyte (-128,127 arasındaki tam sayı değerlerini kapsar.)
             * 3int (-2147483648, 2147483647 tam sayı değerlerini kapsar.)
             * 3uint(0,4294967295 arasındaki tam sayı değerlerini kapsar.)
             * float (Tam ve Rasyonel Sayıların Hepsini kapsar.)
             * double (Tam ve Rasyonel Sayıların Hepsini kapsar.)
             * string (Tanımlama işlemleri için kullanılır.)
             * char (adı üstünde sadece karekter tanımlaması yapabilirsiniz.)
             * 4long (-9223372036854775808, ..., 9223372036854775807 (tam sayı)
             * 4ulong (0, ..., 18446744073709551615 (tam sayı) bigint)
             * 2short (-32768, ..., 32767 (tam sayı))
             * 2ushort (0, ..., 65535 (tam sayı))
             * decimal (Parasal işlemler için kullanılır.)
             * bool (True False)
             * Guid (id tanımlaması yapılır.)
             */
            #endregion
            #region Örnek 1
            //Ornek ornek = new Ornek();
            //Console.WriteLine("Lütfen Bir Sayı Giriniz : ");
            //sbyte sayi = Convert.ToSByte(Console.ReadLine());
            //ornek.NegativandPozitif(sayi);
            #endregion
            #region Örnek 2
            //MatematikselSinif matematikselSinif = new MatematikselSinif();
            //Console.Write("Birinci Sayiyi Giriniz : ");
            //float sayi1 = float.Parse(Console.ReadLine());
            //Console.Write("İkinci Sayiyi Giriniz : ");
            //float sayi2 = float.Parse(Console.ReadLine());
            //matematikselSinif.MatematikIslemleri(sayi1, sayi2);
            //Console.WriteLine();
            //matematikselSinif.MatematikIslemleri2(sayi1, sayi2);
            //Console.WriteLine();
            //matematikselSinif.Topla(sayi1, sayi2);
            //Console.WriteLine();
            //matematikselSinif.Cikarma(sayi1, sayi2);
            //Console.WriteLine();
            //matematikselSinif.Carpma(sayi1, sayi2);
            //Console.WriteLine();
            //matematikselSinif.Bolme(sayi1, sayi2);
            #endregion
            #region Örnek 3
            //KalitimIslemi kalitimIslemi = new KalitimIslemi();
            //kalitimIslemi.ActionVoid();
            #endregion
            #region Diziler - 1
            //string[] country = new string[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Ülke = ");
            //    country[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Ülkeler Listesi");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(country[i]+"\n");
            //}
            #endregion
            #region Diziler - 2
            //string[] isimler = new string[10];
            //isimler[0] = "Seyfullah Veli Dikmen";
            //isimler[1] = "Burak Koçak";
            //isimler[2] = "Emir Ergenç";
            //isimler[3] = "İrfan Taner";
            //isimler[4] = "Dilara Kaşıkçı";
            //isimler[5] = "Esra Kabul";
            //isimler[6] = "Arif Demirel";
            //isimler[7] = "Volkan Tanrıverdi";
            //isimler[8] = "Ulaş Tanrıverdi";
            //isimler[9] = "Ömer Polat";
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.Write(isimler[i]+"\n");
            //}
            //Console.WriteLine("==========================");
            //Random rand = new Random();
            //int rastgele = rand.Next(0, isimler.Length);
            //Console.WriteLine("Seçilmiş İnsan : "+ isimler[rastgele]);
            #endregion
            #region Diziler 3
            //check Check = new check();
            //check.MainLeep();
            #endregion
            #region Diziler 4
            //int[] sayiılar = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.Write("Dizinin İlk Hali = ");
            //foreach (var item in sayiılar)
            //{
            //    Console.WriteLine(item + " ");
            //}
            //Array.Sort(sayiılar);
            //Console.WriteLine();
            //Console.Write("Dizinin Son Hali = ");
            //foreach (var item in sayiılar)
            //{
            //    Console.WriteLine(item + " ");
            //}
            //Array.Reverse(sayiılar);
            //Console.WriteLine();
            //Console.Write("Dizinin Son Hali = ");
            //foreach (var item in sayiılar)
            //{
            //    Console.WriteLine(item + " ");
            //}
            //Console.WriteLine("Bir Değer Giriniz : ");
            //string deger=Console.ReadLine();
            //Console.Write("İkinci Değeri Giriniz : ");
            //string deger2=Console.ReadLine();
            #endregion
            Console.ReadKey();
        }
    }
}
