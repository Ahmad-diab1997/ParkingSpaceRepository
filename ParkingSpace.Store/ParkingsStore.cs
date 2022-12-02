namespace ParkingSpace.Store
{
    using ParkingSpace.Abstractions;
    using ParkingSpace.Abstractions.Models;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    internal class ParkingsStore : IParkingStore
    {
        SqlConnection con = new SqlConnection();

        public string AddParking(Parking parking)
        {
            try
            {
                string sql = "AddParking";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", parking.Id);
                cmd.Parameters.AddWithValue("@Name", parking.Name);
                cmd.Parameters.AddWithValue("@Symbol", parking.Symbol);
                cmd.Parameters.AddWithValue("@ParkingType", parking.ParkingTypes);
                cmd.Parameters.AddWithValue("@Width", parking.Width);
                cmd.Parameters.AddWithValue("@Height", parking.Height);
                cmd.Parameters.AddWithValue("@PricePerHour", parking.PricePerHour);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Parking save Successfully");
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

        public string UpdateParking(Parking parking)
        {
            try
            {
                string sql = "UpdateParking";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", parking.Id);
                cmd.Parameters.AddWithValue("@Name", parking.Name);
                cmd.Parameters.AddWithValue("@Symbol", parking.Symbol);
                cmd.Parameters.AddWithValue("@ParkingType", parking.ParkingTypes);
                cmd.Parameters.AddWithValue("@Width", parking.Width);
                cmd.Parameters.AddWithValue("@Height", parking.Height);
                cmd.Parameters.AddWithValue("@PricePerHour", parking.PricePerHour);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Parking was Successfully Updated");
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

        public string DeleteParking(int parkingId)
        {
            try
            {
                string sql = "DeleteParking";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", parkingId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Parking was Successfully Deleted");
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
