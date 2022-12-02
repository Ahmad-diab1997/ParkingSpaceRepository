namespace ParkingSpace.Store
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using ParkingSpace.Abstractions;
    using ParkingSpace.Abstractions.Models;
    public class CarsStore : ICarStore
    {
        SqlConnection con = new SqlConnection();

        public string AddCar(Car car)
        {
            try
            {
                string sql = "AddCar";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Model", car.Model);
                cmd.Parameters.AddWithValue("@Version", car.Version);
                cmd.Parameters.AddWithValue("@Color", car.Color);
                cmd.Parameters.AddWithValue("@Width", car.Width);
                cmd.Parameters.AddWithValue("@Height", car.Height);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Car save Successfully");
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

        public string UpdateCar(Car car)
        {
            try
            {
                string sql = "UpdateCar";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", car.Id);
                cmd.Parameters.AddWithValue("@Model", car.Model);
                cmd.Parameters.AddWithValue("@Version", car.Version);
                cmd.Parameters.AddWithValue("@Wdith", car.Width);
                cmd.Parameters.AddWithValue("@Height", car.Height);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Car was Successfully Updated");
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
        public string DeleteCar(Guid carId)
        {
            try
            {
                string sql = "DeleteCar";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", carId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Car was Successfully Deleted");
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
