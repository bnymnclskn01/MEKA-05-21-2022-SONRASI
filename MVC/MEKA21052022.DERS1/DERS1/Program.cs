using DERS1.CheckEquality;
using DERS1.Interface.ClassMetot;
using DERS1.Interface.Manager;
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

            #region Sözel Anlatım
            /*
             For, Foreach, While, Do While
            Yapılan döngüsel işlemlerin hepsinde Şartlı ve Şartsız Döngüler
            Kendini Tekrarlayan döngüler ve Kendini Yenileyen döngüler.
             if else switch case koşullarda da geçerlidir.
            Şartlı Koşul vardır.
            Bir işlem elimizde bu işlemi yapabilmemiz için bize iki farklı çıktı
            ve veya iki aynı çıktının benzerlerini işleme almamız için zorunlu kılınan özelliklerdir.
            if(puan>350) // Olumlu
            {
            bla bla
            }
            else // Olumsuz Çıktı
            {
            bla bla 
            }
            Ben işe gidiyorum  Ben otobüsle gidebilirim minibüslede
            her iki ulaşım aracının kullandığı güzergah aynı güzergah
            ve bu güzergah trafik yoğunluğu ile gidiş yapılacak
            if(otobus) // Olumsuz 
            { 
                otobusle işe giidiyorum
            }
            else // Olumsuz çıktı.
            {
                minibüsle işe gidiyorum
            }

             */
            //Console.WriteLine("Lütfen yemeğiniz seçiniz : Bamya ise B'ye Ispanak ise I'ya basınız : ");
            //string yemek = Console.ReadLine();
            //if (yemek.ToUpper().ToLower() == "B") // Olumsuz Ama zorunlu
            //{
            //    Console.WriteLine("seçtiğiniz yemek Bamya afiyet olsun");
            //}
            //else if (yemek.ToUpper().ToLower() == "I") // Olumsuz ama zorunlu
            //{
            //    Console.WriteLine("seçtiğiniz yemek Ispanak afiyet olsun");
            //}
            //else // Zorunlu koşulda işlem yapılmıyor. Olumsuz.
            //{
            //    Console.Write("Yaptığınız işlem başarısız.");
            //}
            //switch (yemek.ToLower().ToUpper())
            //{
            //    case "B":
            //        Console.WriteLine("seçtiğiniz yemek Bamya afiyet olsun");
            //        break;
            //    case "I":
            //        Console.WriteLine("seçtiğiniz yemek Ispanak afiyet olsun");
            //        break ;
            //    default:
            //        Console.Write("Yaptığınız işlem başarısız.");
            //        break;
            //}
            //
            /*
             
             */
            #endregion
            #region Interface Örneği
            string mark = new string('-', 6);
            int value;
            DatabaseManager database;
            Console.Write("[1]\n<--Oracle -->\n[2]<-- MySql -->\n[3]\nMSSQL \n{0}", mark);
            value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    database = new DatabaseManager(new OracleDatabaseManager());
                    database.LoginDB();
                    break;
                case 2:
                    database = new DatabaseManager(new MySqlDatabaseManager());
                    database.LoginDB();
                    break;
                case 3:
                    database = new DatabaseManager(new MsSqlDatabaseManager());
                    database.LoginDB();
                    break;
                default:
                    Console.Write(mark);
                    break;
            }
            Console.ReadKey();
            #endregion
        }
    }
}
