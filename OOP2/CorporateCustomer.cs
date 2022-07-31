using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //inheritance: müşteride olan özellikler artık tüzelde de gerçekte de vardır.
    //Yani ortakları oraya atarız.
    internal class CorporateCustomer : Customer // miras - inheritance
    {
        // tüzel müşteri
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
