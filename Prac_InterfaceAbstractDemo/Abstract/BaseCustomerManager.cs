using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prac_InterfaceAbstractDemo.Abstract;
using Prac_InterfaceAbstractDemo.Entities;
using Prac_InterfaceAbstractDemo.Concrete;
using Prac_InterfaceAbstractDemo.Adapters;
using MernisServiceReference;

namespace Prac_InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to database: " + customer.FirstName);
        }
    }
}
