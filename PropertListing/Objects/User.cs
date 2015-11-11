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
        public String Fname { set; get; }

        [DataMember]
        public String Lname { set; get; }

        [DataMember]
        public Int32 Agent_ID { set; get; }

        [DataMember]
        public string Phone { set; get; }

        public string Email { set; get; }
    }
}
