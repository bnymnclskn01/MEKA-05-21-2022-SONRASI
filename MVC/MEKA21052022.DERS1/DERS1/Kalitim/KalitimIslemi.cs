using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS1.Kalitim
{
    public class KalitimIslemi
    {
        Futbolcu futbolcu = new Futbolcu();
        public void ActionVoid()
        {
            char secim;
            do
            {
                Console.Write("Lütfen Futbolcunun Adını Giriniz : ");
                futbolcu.Name = Console.ReadLine();
                Console.Write("Lütfen Futbolcunun Soyadını Giriniz : ");
                futbolcu.Surname = Console.ReadLine();
                Console.Write("Lütfen Futbolcunun Yaşını Giriniz : ");
                futbolcu.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Lütfen Futbolcunun Pozisyonunu Giriniz : ");
                futbolcu.Position = Console.ReadLine();
                Console.Write("Lütfen Futbolcunun Ülkesini Giriniz : ");
                futbolcu.Country = Console.ReadLine();
                Console.Write("Lütfen Futbolcunun Takımının Adını Giriniz : ");
                futbolcu.TeamName = Console.ReadLine();
                Console.Write("Lütfen Futbolcunun Oynadığı Ligi Giriniz : ");
                futbolcu.Leage = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("*******************************");
                Console.WriteLine("Futbolcunun Adı : {0}\nFutbolcunun Soyadı : {1}\nFutbolcunun Yaşı : {2}\nFutbolcunun Oynadığı Mevki : {3}\nFutbolcunun Ülkesi : {4}\nFutbolcunun Oynadığı Takım : {5}\nFutbolcunun Oynadığı Lig : {6}", futbolcu.Name, futbolcu.Surname, futbolcu.Age, futbolcu.Position, futbolcu.Country, futbolcu.TeamName, futbolcu.Leage);
                Console.WriteLine("*******************************");
                Console.Write("Yeni Futbolcu Eklemek İster Misiniz ? E|H : ");
                secim = Convert.ToChar(Console.ReadLine().ToLower().ToUpper());
                Console.Clear();

            } while (secim=='E');

        }
        #region
       
        #endregion
    }
}
