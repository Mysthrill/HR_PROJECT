using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;
using DomainObjects.HR;

namespace HR_TEST_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee();
            person.Name = "Cattoor";
            person.FirstName = "Robby";

            IPersonFactory factory = new PersonFactory();
            factory.Create(person);
        }
    }
}
