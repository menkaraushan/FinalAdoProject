using System;
using System.Data.SqlClient;

namespace FinalAdoProject
{
    class Program
    {
 
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        static void Main(string[] args)

        {
          
            string ConString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=FinalAoDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Addresses";
            con.Open();
            {
                SqlCommand cmd = new SqlCommand(querystring, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());

                }

            }
        }
    }
}

