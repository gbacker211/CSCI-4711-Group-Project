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
    class User
    {
        [DataMember]
        public string Fname { set; get; }

        [DataMember]
        public string Lname { set; get; }

        [DataMember]
        public int Agent_ID { set; get; }

        [DataMember]
        public string Phone { set; get; }

        [DataMember]
        public string Email { set; get; }
    }
}
