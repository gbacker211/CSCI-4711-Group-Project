using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyListingSystem
{
    /// <summary>
    ///     Class Property is for storing a User retrieved 
    ///     from the database and to be used on the system.
    /// </summary>
    class Property
    {
        // class variables
        private int mProperty_ID;
        private int mAddress_ID;
        private int mAgent_ID;
        private string mDescription;
        private int mBed;
        private int mBath;
        private double mPrice;
        private string mImagePath;
        private string mStreet;
        private string mCity;
        private string mState;
        private int mZip;

        /// <summary>
        ///     Constructor for class Property
        ///     // ***NOTE: Property_ID, Agent_D, and Address_ID may not be needed in constructor but can be if necessary*** // ====================================================================== //
        /// </summary>
        /// <param name="aDesrciption"></param>
        /// <param name="aBed"></param>
        /// <param name="aBath"></param>
        /// <param name="aPrice"></param>
        /// <param name="aPath"></param>
        /// <param name="aStreet"></param>
        /// <param name="aCity"></param>
        /// <param name="aState"></param>
        /// <param name="aZip"></param>
        public Property(string aDesrciption, int aBed, int aBath, double aPrice, string aPath, string aStreet, string aCity, string aState, int aZip)
        {
            Description = aDesrciption;
            Bed = aBed;
            Bath = aBath;
            Price = aPrice;
            ImagePath = aPath;
            Street = aStreet;
            City = aCity;
            State = aState;
            Zip = aZip;
        }

        /// <summary>
        ///     Property for mProperty_ID
        /// </summary>
        public int Property_ID
        {
            set
            {
                if (value >= 0)
                    mProperty_ID = value;
                else
                    throw new ApplicationException("ID was set as negative ID cannont be a negative number.");
            }
            get
            {
                return mProperty_ID;
            }
        }

        /// <summary>
        ///     Property for mAddress_ID
        /// </summary>
        public int Address_ID
        {
            set
            {
                if (value >= 0)
                    mAddress_ID = value;
                else
                    throw new ApplicationException("ID was set as negative. ID cannont be a negative number.");
            }

            get { return mAddress_ID; }
        }

        /// <summary>
        ///     Property for mAgent_ID
        /// </summary>
        public int Agent_ID
        {
            set
            {
                if (value >= 0)
                    mAgent_ID = value;
                else
                    throw new ApplicationException("ID was set as negative. ID cannont be a negative number.");
            }
            get { return mAgent_ID; }
        }
        /// <summary>
        ///     Property for mDescription
        /// </summary>
        public string Description { set { mDescription = value; } get { return mDescription; } }

        /// <summary>
        ///     Property for mBed
        /// </summary>
        public int Bed
        {
            set
            {
                if (value >= 0)
                    mBed = value;
                else
                    throw new ArgumentOutOfRangeException("Value for Bed(s) cannont be a negative number.");
            }
            get
            {
                return mBed;
            }
        }

        /// <summary>
        ///     Property for mBath
        /// </summary>
        public int Bath
        {
            set
            {
                if (value >= 0)
                    mBath = value;
                else
                    throw new ApplicationException("Value for Bath(s) cannont be a negative number.");
            }

            get
            {
                return mBath;
            }
        }

        /// <summary>
        ///     Property for mPrice
        /// </summary>
        public double Price
        {
            set
            {
                if (value >= 0)
                    mPrice = value;
                else
                    throw new ApplicationException("Price cannot be a negatice number.");
            }
            get
            {
                return mPrice;
            }
        }

        /// <summary>
        ///     Property for mImagePath
        /// </summary>
        public string ImagePath { set { mImagePath = value; } get{ return mImagePath; } }

        /// <summary>
        ///     Property for mStreet
        /// </summary>
        public string Street { set { mStreet = value; } get { return mStreet; } }

        /// <summary>
        ///     Property for mCity
        /// </summary>
        public string City { set { mCity = value; }  get { return mCity; } }

        /// <summary>
        ///     Property for mState
        /// </summary>
        public string State { set { mState = value; } get { return mState; } }

        /// <summary>
        ///     Property for mZip
        /// </summary>
        public int Zip
        {
            set
            {
                if (value >= 0)
                    mZip = value;
                else
                    throw new ApplicationException("Value Zip cannot be a negative number.");
            }

            get { return mZip; }
        }

        /// <summary>
        ///     Overrides the ToString method for displaying a 
        ///     property's information.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Address: " + Street + City + ", " + State + ", " + Zip + "\n" + Description + "\n" + "Bed(s): " + Bed + "\n" + "Bath(s): " + Bath + "\n" + "Price: " + Price + "\n");
        }
    }// END CLASS Property
}
