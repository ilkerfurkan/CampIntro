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
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        public ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }            
        }
    }
}
