using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CartManager
    {
        // Naming convention: isimlendirme kuralı
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + product.Name);
        }

        // 
        //public void Ekle2(string UrunAdi, string Aciklama, double Fiyat, int StokAdedi)
        //{
        //    Console.WriteLine("Tebrikler. Sepete eklendi: " + UrunAdi);
        //}
    }
}
