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

namespace Prac_InterfaceAbstractDemo.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentityNumber { get; set; }
    }
}
