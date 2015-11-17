using System;
using System.Runtime.Serialization;
using System.Text;

namespace PropertyListingSystem.Objects
{
    /// <summary>
    ///     Class Lisiting is for only outputing information 
    ///     on a property with an Agent's contact information
    ///     to the ResultsForm.
    /// </summary>
    [DataContract]
    class Listing
    {
        [DataMember]
        public string Street { set; get; }

        [DataMember]
        public string City { set; get; }

        [DataMember]
        public string State { set; get; }

        [DataMember]
        public int Zip { set; get; }

        [DataMember]
        public string Description { set; get; }

        [DataMember]
        public double Price { set; get; }

        [DataMember]
        public int Bed { set; get; }

        [DataMember]
        public int Bath { set; get; }

        [DataMember]
        public string ImagePath { set; get; }

        [DataMember]
        public string Fname { set; get; }

        [DataMember]
        public string Lname { set; get; }

        [DataMember]
        public string Phone { set; get; }

        [DataMember]
        public string Email { set; get; }
    }
}