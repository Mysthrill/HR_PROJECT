using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Action_Service.DataTransferObjects
{
    /// <summary>
    /// Customer Data Transfer Object.
    /// 
    /// The purpose of the CustomerTransferObject is to facilitate transport of 
    /// customer business data in a serializable format. Business data is kept in 
    /// publicly accessible auto properties. This class has no methods. 
    /// </summary>
    /// <remarks>
    /// Pattern: Data Transfer Objects.
    /// 
    /// Data Transfer Objects are objects that transfer data between processes, but without behavior.
    /// </remarks>
    [DataContract(Name = "Person", Namespace = "http://www.yourcompany.com/types/")]
    public class CustomerDto : PersonDto
    {

    }
}
