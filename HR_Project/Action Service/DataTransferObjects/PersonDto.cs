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
    public class PersonDto
    {
        /// <summary>
        /// Unique identifier.
        /// The Identity Field Design Pattern. 
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Person Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Person FirstName.
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Person Type.
        /// </summary>
        [DataMember]
        public int Type { get; set; }
    }
}
