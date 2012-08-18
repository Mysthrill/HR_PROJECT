using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DomainObjects.HR;

namespace BusinessLayer
{
    public interface IPersonFactory
    {
        // Standard transactional methods for single-row operations
        void Create(Customer cust);
        void Insert(Customer cust);
        void Update(Customer cust);
        void Delete(Customer cust);
        void Load(Customer cust);

        // Query method to return a collection
        ArrayList FindPersonsByName(String name);

        // Query method to return a collection
        ArrayList FindPersonsByType(int type);
    }
}
