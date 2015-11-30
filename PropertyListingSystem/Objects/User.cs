using System;
using System.Runtime.Serialization;
using System.Text;


namespace PropertyListingSystem
{
    /// <summary>
    ///     Class User is for storing information of a User retrieved 
    ///     from the database and to be used on the system.
    /// </summary>
    [DataContract]
    public class User
    {
        [DataMember]
        public string Fname { get; set; }

        [DataMember]
        public string Lname { get; set; }

        [DataMember]
        public int Agent_ID { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
