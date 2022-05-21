using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS1.Ornekler
{
    public class Ornek
    {
        public void NegativandPozitif (sbyte sayi)
        {
            if (sayi > 0)
            {
                Console.WriteLine("{0} sayısı pozitif sayıdır.", sayi);
            }
            else if (sayi < 0)
            {
                Console.WriteLine("{0} sayısı negatif sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı nötr sayıdır.", sayi);
            }
        }
    }
}
