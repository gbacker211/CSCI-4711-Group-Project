using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PropertyListingSystem;


namespace PropertyListingSystem
{
    public class AddController
    {
        private string _connectionString = String.Empty;  //Once connection to db is established place the connection string here

        public AddController()
        {
            _connectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["PropertyListingsDBConnectionString2"]
                    .ConnectionString;
        }

        public void Open()
        {
            AddForm newAdd = new AddForm();
            newAdd.Show();
        }

        public bool AddNewProperty(Property property)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand addProperty = new SqlCommand("usp_Insert_NewProperty", connection))
                    {
                        connection.Open();
                        addProperty.CommandType = CommandType.StoredProcedure;
                        addProperty.Parameters.AddWithValue("@AgentID", property.AgentID);
                        addProperty.Parameters.AddWithValue("@Address", property.Address);
                        addProperty.Parameters.AddWithValue("@State", property.State);
                        addProperty.Parameters.AddWithValue("@Zip", property.Zip);
                        addProperty.Parameters.AddWithValue("@Price", property.Price);
                        addProperty.Parameters.AddWithValue("@NumberOfRooms", property.NumberOfRooms);
                        addProperty.Parameters.AddWithValue("@NumberOfBaths", property.NumberOfBaths);
                        addProperty.Parameters.AddWithValue("@Description", property.Description);
                        addProperty.Parameters.AddWithValue("@Photo_URL", property.Photo_Url);
                        addProperty.Parameters.Add("@ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

                        addProperty.ExecuteNonQuery();

                        value = (bool)addProperty.Parameters["@ReturnValue"].Value;




                    }
                }
            }
            catch (Exception)
            {

                //EAT FAILURE FOR NOW
            }


            return value;
        }
    }
}