using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //inheritance: müşteride olan özellikler artık tüzelde de gerçekte de vardır.
    //Yani ortakları oraya atarız.
    internal class IndividualCustomer : Customer
    {
        // gerçek/bireysel müşteri
        public string IdentityNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
