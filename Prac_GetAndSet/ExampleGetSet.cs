using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_GetAndSet
{
    internal class ExampleGetSet
    {
        public int Id { get; set; }
        string _firstName;
        public string Name
        {
            get { return "Mr. " + _firstName; }
            set { _firstName = value; }
        }
        public string City { get; set; }


    }
}
