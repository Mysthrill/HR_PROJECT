using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainObjects.HR
{
    public class Supplier : Person
    {
        public Supplier()
        {
            Type = Convert.ToInt16(PeopleType.Supplier);
        }
    }
}
