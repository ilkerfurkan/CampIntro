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

namespace Prac_InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
