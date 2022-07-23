using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(sayi1 + " + " + sayi2 + " = " + toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int cikarma = sayi1 - sayi2;
            Console.WriteLine(sayi1 + " - " + sayi2 + " = " + cikarma);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine(sayi1 + " / " + sayi2 + " = " + bolme);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine(sayi1 + " * " + sayi2 + " = " + carpma);
        }


    }
}
