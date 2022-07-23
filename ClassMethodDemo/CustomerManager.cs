using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Kullanıcı Eklendi: " + customer.CustomerName + " " + customer.CustomerSurname + ". Doğum Yeri: " + customer.CustomerBirthPlace);
            Console.WriteLine(" ");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + ". Doğum Yeri: " + customer.CustomerBirthPlace + " listelenmiştir.");
            Console.WriteLine(" ");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " silinmiştir.");
            Console.WriteLine(" ");
        }
    }
}
