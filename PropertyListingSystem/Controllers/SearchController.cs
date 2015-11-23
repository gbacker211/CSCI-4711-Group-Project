using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace PropertyListingSystem
{
  public  class SearchController
    {


        private string _connectionString = String.Empty;  //Once connection to db is established place the connection string here

        public SearchController()
        {
            _connectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["PropertyListingsDBConnectionString"]
                    .ConnectionString;
        }


        

        public List<Property> GetPropertyListings(Property property)
        {
            DataTable dt = new DataTable();
            List<Property> Property = new List<Property>();
            using (SqlConnection sqlConnect = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("usp_Get_SearchProperty", sqlConnect))
                {
                    sqlConnect.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@AgentID", property.AgentID);
                    sqlCommand.Parameters.AddWithValue("@Address", property.Address);
                    sqlCommand.Parameters.AddWithValue("@State", property.State);
                    sqlCommand.Parameters.AddWithValue("@Zip", property.Zip);
                    sqlCommand.Parameters.AddWithValue("@Price", property.Price);
                    sqlCommand.Parameters.AddWithValue("@NumberOfRooms", property.NumberOfRooms);
                    sqlCommand.Parameters.AddWithValue("@NumberOfBaths", property.NumberOfBaths);
                    sqlCommand.Parameters.AddWithValue("@Description", property.Description);
                    //sqlCommand.Parameters.AddWithValue("@Photo_URL", property.Photo_Url);

                            using (SqlDataAdapter getData = new SqlDataAdapter(sqlCommand))
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
        }


        private Property AddProperty(DataRow row)
        {
            var ojb = new Property()
            {
                Address = row["Street"].ToString(),
                AgentID = Convert.ToInt32(row["Agent_ID"].ToString()),
                Description = row["Description"].ToString(),


            };


            return ojb;
        }




        public List<Property> GetPropertyListings()
        {
            DataTable dt = new DataTable();
            List<Property> Property = new List<Property>();
            using (SqlConnection sqlConnect = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("usp_Get_SearchProperty", sqlConnect))
                {


                    using (SqlDataAdapter getData = new SqlDataAdapter(sqlCommand))
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
        }

        private Property AddProperty(DataRow row)
        {
            var ojb = new Property()
            {
                Address = row["Street"].ToString(),
                AgentID = Convert.ToInt32(row["Agent_ID"].ToString()),
                Description = row["Description"].ToString(),


            };


            return ojb;
        }


      


    }
}
