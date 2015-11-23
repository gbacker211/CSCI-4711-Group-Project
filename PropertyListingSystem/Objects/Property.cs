using System;
using System.Runtime.Serialization;
using System.Text;

namespace PropertyListingSystem
{
    [DataContract]
    public class Property
    {
        [DataMember]
        public Int32 AgentID { get; set; }

        [DataMember]
        public String Photo_Url { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string State { get; set; }

        public string City { get; set; }

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public double Price { get; set; }

        public int MinPrice { get; set; }

        public int MaxPrice { get; set; }

        [DataMember]
        public int NumberOfRooms { get; set; }

        [DataMember]
        public int MaxNumberOfRooms { get; set; }

        [DataMember]
        public int MinNumberOfRooms { get; set; }

        [DataMember]
        public int NumberOfBaths { get; set; }

        [DataMember]
        public int MaxNumberOfBaths { get; set; }

        [DataMember]
        public int MinNumberOfBaths { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
