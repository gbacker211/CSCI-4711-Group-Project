using System;
using System.Runtime.Serialization;
using System.Text;

namespace PropertyListingSystem
{
    /// <summary>
    ///     Class Lisiting is for only outputing information 
    ///     on a property with an Agent's contact information
    ///     to the ResultsForm.
    /// </summary>
    [DataContract]
    public class Listing
    {
        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public int Zip { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public int Bed { get; set; }

        [DataMember]
        public int Bath { get; set; }

        [DataMember]
        public string ImagePath {get; set; }

        [DataMember]
        public string AgentName { get; set; }

        [DataMember]
        public string Lname { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}