using System;
using System.Configuration;

namespace PropertyListingSystem
{
    public class LogoutController
    {
        public static void Logout(ListingsForm currentListingsForm)
        {
            currentListingsForm.Close();
        }
    }
}
