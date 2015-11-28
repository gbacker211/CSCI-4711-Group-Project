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
                System.Configuration.ConfigurationManager.ConnectionStrings["PropertyListingsDBConnectionString2"]
                    .ConnectionString;
        }


        

        public List<Property> GetPropertyListings(Property property)
        {
            DataTable dt = new DataTable();
            List<Property> Property = new List<Property>();
            using (SqlConnection sqlConnect = new SqlConnection(_connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("usp_Get_PropertySearch", sqlConnect))
                {
                    sqlConnect.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                   
                    sqlCommand.Parameters.AddWithValue("@Address", property.Address);
                    sqlCommand.Parameters.AddWithValue("@State", property.State);
                    sqlCommand.Parameters.AddWithValue("@Zip", property.Zip);
                    sqlCommand.Parameters.AddWithValue("@MaxPrice", property.MaxPrice);
                    sqlCommand.Parameters.AddWithValue("@MinPrice", property.MinPrice);
                    sqlCommand.Parameters.AddWithValue("@MaxNumberOfRooms", property.MaxNumberOfRooms);
                    sqlCommand.Parameters.AddWithValue("@MaxNumberOfBaths", property.MaxNumberOfBaths);
                    sqlCommand.Parameters.AddWithValue("@MinNumberOfRooms", property.MinNumberOfRooms);
                    sqlCommand.Parameters.AddWithValue("@MinNumberOfBaths", property.MinNumberOfBaths);
                   // sqlCommand.Parameters.AddWithValue("@Description", property.Description);
                    //sqlCommand.Parameters.AddWithValue("@Photo_URL", property.Photo_Url);

                    using (SqlDataAdapter getData = new SqlDataAdapter(sqlCommand))
                    {
                        getData.Fill(dt);
                    }

                    dt.AsEnumerable().ToList().ForEach(dr =>
                    {
                        Property.Add(AddPropertyToList(dr));
                    }


                        );



                }
            }

            return Property;
        }


        private Property AddPropertyToList(DataRow row)
        {
            var ojb = new Property()
            {
                Address = row["Street"].ToString(),
                City = row["City"].ToString(),
                State = row["State"].ToString(),
                Zip = row["Zip"].ToString(),
                NumberOfBaths = Convert.ToInt32(row["Bath"].ToString()),
                NumberOfRooms = Convert.ToInt32(row["Bed"].ToString()),
                Price = Convert.ToInt32(row["Price"].ToString()),
                Photo_Url = row["image_path"].ToString(),
                Description = row["Description"].ToString(),
                AgentName = row["AgentFullName"].ToString(),
                AgentPhone = row["PhoneNumber"].ToString(),
                AgentEmail = row["Email"].ToString()


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
