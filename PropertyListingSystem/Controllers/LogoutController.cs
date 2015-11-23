using System;
using System.Configuration;

namespace PropertyListingSystem
{
    public class LogoutController
    {
        public static void Logout(ListingsForm currentListingsForm)
        {
            currentListingsForm.Close();

           // Form1._hideForm = false;
            //Form1 Search = new Form1();
            //Search.Show();
        }
    }
}
