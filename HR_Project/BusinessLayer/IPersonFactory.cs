using System;
using System.Collections;
using DomainObjects.HR;

namespace BusinessLayer
{
    public interface IPersonFactory
    {
        // Standard transactional methods for single-row operations
        void Create(Person person);
        void Insert(Person person);
        void Update(Person person);
        void Delete(Person person);
        void Load(Person person);

        // Query method to return a collection
        ArrayList FindPersonsByName(String name);

        // Query method to return a collection
        ArrayList FindPersonsByType(int type);
    }
}
