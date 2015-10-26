using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyListingSystem
{
    class User
    {
        /// <summary>
        ///     class variables
        /// </summary>
        private string mFname;
        private string mLname;
        private int mAgent_ID;
        private string mPhone;
        private string mEmail;

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
        public int Agent_ID { set; get; }

        /// <summary>
        ///     Property for mPhone
        /// </summary>
        public string Phone { set; get; }

        /// <summary>
        ///     Property for mEmail
        /// </summary>
        public string Email { set; get; }
    }
}
