using System;

namespace PropertyListingSystem.Controllers
{
    public class LogoutController
    {
        public void Logout()
        {
            ListingsForm.ActiveForm.Close();
            Form1 Search = new Form1();
            Search.Show();
        }
    }
}
