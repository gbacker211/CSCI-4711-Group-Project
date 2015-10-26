using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyListingSystem
{
    /// <summary>
    ///     Class User is for storing a User retrieved 
    ///     from the database and to be used on the system.
    /// </summary>
    class User
    {

        // class variables
        private string mFname;
        private string mLname;
        private int mAgent_ID;
        private string mPhone;
        private string mEmail;

        /// <summary>
        ///     constructor for class User
        /// </summary>
        /// <param name="aFname"></param>
        /// <param name="aLname"></param>
        /// <param name="aAgent_ID"></param>
        /// <param name="aPhone"></param>
        /// <param name="aEmail"></param>
        public User(string aFname = "", string aLname = "", int aAgent_ID = 0, string aPhone = "", string aEmail = "")
        {
            Fname = aFname;
            Lname = aLname;
            Agent_ID = aAgent_ID;
            Phone = aPhone;
            Email = aEmail;
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
        ///     Property for mAgent_ID
        /// </summary>
        public int Agent_ID
        {
            set
            {
                if (value >= 0)
                    mAgent_ID = value;
                else
                    throw new ArgumentOutOfRangeException("Error: ID cannot be a negative...");
            }    
            get
            {
                return mAgent_ID;
            }
        }

        /// <summary>
        ///     Property for mPhone
        /// </summary>
        public string Phone { set { mPhone = value; } get { return mPhone; } }

        /// <summary>
        ///     Property for mEmail
        /// </summary>
        public string Email { set { mEmail = value; } get { return mEmail; } }
    }
}
