using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


namespace PropertyListingSystem.Controllers
{
    public class LoginController
    {
        // database connection // *** NOTE *** // THAT PATH NEEDS TO BE CHANGE FOR FINAL PRODUCT // ============================================================================================================================================================================== //
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\v11.0; AttachDbFilename = C:\\Users\\Christopher\\Source\\Repos\\CSCI - 4711 - Group - Project\\PropertyListingSystem\\Data\\PropertyListingsDB.mdf; Integrated Security = True; Connect Timeout = 30");
        

        public void Open()
        {
            LoginForm Login = new LoginForm();
            Login.Show();
        }

        /// <summary>
        ///     Verfies that the User is an Agent in the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void subimt(string username, string password)
        {
            if (username == null || password == null)
            {
                MessageBox.Show("Please enter your username and/or password");
            }

            else
            {
                try
                {
                    // database command
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_Get_AgentLogin", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);


                    User aUser = new User(); // create class User to hold ID.
                    aUser.Agent_ID = cmd.ExecuteNonQuery();

                    // Check if agent's ID is correct
                    if (aUser.Agent_ID != 0)
                    {
                        // call ListingsForm, and close SearchForm (Form1) and LoginForm.
                        List<Property> aAgentsProps = GetPropertyListings(aUser.Agent_ID);

                        //cmd = new SqlCommand("usp_Get_PropertySearch", conn);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@agent_ID", aUser.Agent_ID);


                        Form1.ActiveForm.Close(); // close SearchForm
                        ListingsForm AListingsForm = new ListingsForm(aUser, aAgentsProps);
                        AListingsForm.Show();
                        LoginForm.ActiveForm.Close();
                    }
                    else
                        MessageBox.Show("Your Username and/or Password is incorrect");
                }
                finally
                {
                    conn.Close();
                }
            }
        }//

        /// <summary>
        ///     Gets the Properties added by the Agent.
        /// </summary>
        /// <param name="aUser"></param>
        /// <returns></returns>
        public List<Property> GetPropertyListings(int aUser)
        {
            DataTable dt = new DataTable();
            List<Property> Property = new List<Property>();
            using (conn)
            {
                using (SqlCommand cmd = new SqlCommand("usp_Get_SearchProperty", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@agent_ID", aUser);
                    using (SqlDataAdapter getData = new SqlDataAdapter(cmd))
                    {
                        getData.Fill(dt);
                    }

                    dt.AsEnumerable().ToList().ForEach(dr =>
                    {
                        Property.Add(AddProperty(dr));
                    }
                        );
                }
            }
            return Property;
        }//

        /// <summary>
        ///     Adds the information from database to Property
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Property AddProperty(DataRow row)
        {
            var ojb = new Property()
            {
                Address = row["Street"].ToString(),
                City = row["City"].ToString(),
                State = row["State"].ToString(),
                Zip = Convert.ToInt32(row["Zip"].ToString()),
                Price = Convert.ToInt32(row["Price"].ToString()),
                NumberOfRooms = Convert.ToInt32(row["Bed"].ToString()),
                NumberOfBaths = Convert.ToInt32(row["Bath"].ToString()),
                Description = row["Description"].ToString(),
            };

            return ojb;
        }
    }
}
