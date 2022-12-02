namespace ParkingSpace.Store
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using ParkingSpace.Abstractions.Models;
    using ParkingSpace.Abstractions.Store;
    public class UserStore : IUserStore
    {
        SqlConnection con = new SqlConnection();

        public string AddUser(User user)
        {
            try
            {
                string sql = "AddUser";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Money", user.Money);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("User saved Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }

        public string UpdateUser(User user)
        {
            try
            {
                string sql = "UpdateUser";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Money", user.Money);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("User was Successfully Updated");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
        public string DeleteUser(Guid userId)
        {
            try
            {
                string sql = "DeleteUser";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", userId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("User was Successfully Deleted");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }

        }
    }
}
