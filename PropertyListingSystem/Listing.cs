using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///     Listing class is use to store data pulled from the database to be display on the ResultsForm.
/// </summary>
namespace PropertyListingSystem
{
    class Listing
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
        private string mFname;
        private string mLname;
        private string mPhone;
        private string mEmail;

        /// <summary>
        ///     Constructor for Listing
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
        /// <param name="aFname"></param>
        /// <param name="aLname"></param>
        /// <param name="aPhone"></param>
        /// <param name="aEmail"></param>
        public Listing(string aDesrciption = "", int aBed = 0, int aBath = 0, double aPrice = 0, string aPath = "", string aStreet = "", string aCity = "", string aState = "", int aZip = 0, string aFname = "", string aLname = "", string aPhone = "", string aEmail = "")
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
            Fname = aFname;
            Lname = aLname;
            Phone = aPhone;
            Email = aEmail;
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
        public string ImagePath { set { mImagePath = value; } get { return mImagePath; } }

        /// <summary>
        ///     Property for mStreet
        /// </summary>
        public string Street { set { mStreet = value; } get { return mStreet; } }

        /// <summary>
        ///     Property for mCity
        /// </summary>
        public string City { set { mCity = value; } get { return mCity; } }

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
        ///     Property for mFname
        /// </summary>
        public string Fname { set { mFname = value; } get { return mFname; } }

        /// <summary>
        ///     Property for mLname
        /// </summary>
        public string Lname { set { mLname = value; } get { return mLname; } }

        /// <summary>
        ///     Property for mPhone
        /// </summary>
        public string Phone { set { mPhone = value; } get { return mPhone; } }

        /// <summary>
        ///     Property for mEmail
        /// </summary>
        public string Email { set { mEmail = value; } get { return mEmail; } }

        /// <summary>
        ///     Overrides the ToString method for displaying a 
        ///     property's information.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Address: " + Street + City + ", " + State + ", " + Zip + "\n" + Description + "\n" + "Bed(s): " + Bed + "\n" + "Bath(s): " + Bath + "\n" + "Price: " + Price + "\n" + "Call " + Fname + " " + Lname + "at " + Phone + "or email at " + Email);
        }
    }
}
