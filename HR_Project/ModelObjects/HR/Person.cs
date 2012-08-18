using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ModelObjects.HR
{
    public class Person : IDataErrorInfo
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Type { get; set; }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
