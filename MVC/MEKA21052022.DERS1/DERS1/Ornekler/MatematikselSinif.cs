using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS1.Ornekler
{
    internal class MatematikselSinif
    {
        // değişken tanımlaması Float olacak.
        #region 1.Yöntem
        internal void MatematikIslemleri(float sayi1, float sayi2)
        {
            // IF ELSE
            Console.Write("İşleminiz Türünüzü Seçiniz : Toplama İçin +'ya Çıkarma için -'ye Çarpma için *'ya Bölme İçin /'a basınız; : ");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim == '+')
            {
                Console.Write("Sayılarının Toplamı : ", sayi1 + sayi2);
            }
            else if (secim == '-')
            {
                sayi1 -= sayi2;
                Console.Write("Sayılarının Çıkarmasında Çıkan Sonucu : {0}", sayi1);
            }
            else if (secim == '*')
            {
                Console.Write("Sayılarının Çarpım İşleminden Çıkan Sonucu : "+ sayi1 * sayi2);
            }
            else if (secim == '/')
            {
                if (sayi2 == 0)
                {
                    Console.Write("İşlem tanımsız");
                }
                else
                {
                    Console.Write("Sayılarının Bölümünden Çıkan Sonucu: "+ sayi1 / sayi2);
                }
            }
            else
            {
                Console.WriteLine("Yanlış İşlem Yaptınız işleminiz başarısız oldu");
            }
        }
        #endregion
        #region 2.Yöntem
        internal void MatematikIslemleri2(float sayi1, float sayi2)
        {
            // SWITCH CASE
            Console.Write("İşleminiz Türünüzü Seçiniz : Toplama İçin +'ya Çıkarma için -'ye Çarpma için *'ya Bölme İçin /'a basınız; : ");
            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '+':
                    Console.Write("Sayılarının Toplamı : "+ sayi1 + sayi2);
                    break;
                case '-':
                    sayi1 -= sayi2;
                    Console.Write("Sayılarının Çıkarmasında Çıkan Sonucu : {0}", sayi1);
                    break;
                case '*':
                    Console.Write("Sayılarının Çarpım İşleminden Çıkan Sonucu : "+ sayi1 * sayi2);
                    break;
                case '/':
                    switch (sayi2)
                    {
                        case 0:
                            Console.Write("İşlem tanımsız");
                            break;

                        default:
                            Console.Write("Sayılarının Bölümünden Çıkan Sonucu: "+ sayi1 / sayi2);
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion
        #region 3.Yöntem
        internal void Topla(float sayi1, float sayi2)
        {
            Console.Write("Sayılarının Toplamı : {0}", sayi1 + sayi2);
        }
        internal void Cikarma(float sayi1, float sayi2)
        {
            sayi1 -= sayi2;
            Console.Write("Sayılarının Çıkarmasında Çıkan Sonucu : {0}", sayi1);
        }
        internal void Bolme(float sayi1, float sayi2)
        {
            if (sayi2 == 0)
            {
                Console.Write("İşlem tanımsız");
            }
            else
            {
                Console.Write("Sayılarının Bölümünden Çıkan Sonucu: "+sayi1 / sayi2);
            }
        }
        internal void Carpma(float sayi1, float sayi2)
        {
            Console.Write("Sayılarının Çarpım İşleminden Çıkan Sonucu : "+ sayi1 * sayi2);
        }
        #endregion
    }
}
