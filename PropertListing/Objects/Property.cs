using System.Runtime.Serialization;
using System.Text;

namespace PropertyListing
{
    [DataContract]
    public class Property
    {
        [DataMember]
         public  string Address { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public  int Price { get; set; }

        [DataMember]
        public  int NumberOfRooms { get; set; }

        [DataMember]
        public  int NumberOfBaths { get; set; }

        [DataMember]
        public  string Description { get; set; }
    }
}