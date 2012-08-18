using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainObjects.HR
{
    public class Customer : Person
    {
        public Customer()
        {
            Type = Convert.ToInt16(PeopleType.Customer);
        }
    }
}
