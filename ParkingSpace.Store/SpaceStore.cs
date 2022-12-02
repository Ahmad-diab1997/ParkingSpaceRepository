namespace ParkingSpace.Store
{
    using ParkingSpace.Abstractions;
    using ParkingSpace.Abstractions.Models;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class SpaceStore : ISpaceStore
    {
        SqlConnection con = new SqlConnection();

        public string AddSpace(Space space)
        {
            try
            {
                string sql = "AddSpace";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", space.Id);
                cmd.Parameters.AddWithValue("@Symbol", space.Symbol);
                cmd.Parameters.AddWithValue("@Width", space.Width);
                cmd.Parameters.AddWithValue("@Height", space.Height);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Space save Successfully");
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

        public string UpdateSpace(Space space)
        {
            try
            {
                string sql = "UpdateSpace";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", space.Id);
                cmd.Parameters.AddWithValue("@Symbol", space.Symbol);
                cmd.Parameters.AddWithValue("@Width", space.Width);
                cmd.Parameters.AddWithValue("@Height", space.Height);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Space was Successfully Updated");
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

        public string DeleteSpace(int spaceId)
        {
            try
            {
                string sql = "DeleteSpace";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", spaceId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Space was Successfully Deleted");
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
