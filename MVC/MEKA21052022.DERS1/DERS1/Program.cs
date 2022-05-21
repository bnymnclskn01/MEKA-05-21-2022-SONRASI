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
            Ornek ornek = new Ornek();
            Console.WriteLine("Lütfen Bir Sayı Giriniz : ");
            sbyte sayi = Convert.ToSByte(Console.ReadLine());
            ornek.NegativandPozitif(sayi);
            Console.ReadKey();
            #endregion
        }
    }
}
