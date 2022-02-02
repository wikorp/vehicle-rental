using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace TruckRental
{
    class Repository
    {
        private readonly SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);

        public DataTable GetVehicles()
        {
            string query = "SELECT * " +
                           "FROM Vehicle;";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetRentals(int clientId)
        {
            string query = "SELECT * " +
                           "FROM Rental " +
                           $"WHERE cient_id = {clientId};";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void SetIsAvaliableVehicle(int vehicleId, char isAvaliable)
        {
            string querySetIsAvaliableVehicle = "UPDATE Vehicle " +
                                     $"SET is_avaliable = {"'" + isAvaliable + "'"} " +
                                     $"WHERE vehicle_id = {vehicleId};";

            connection.Open();

            SqlCommand commandSetIsAvaliableVehicle = new SqlCommand(querySetIsAvaliableVehicle, connection);
            commandSetIsAvaliableVehicle.ExecuteNonQuery();

            connection.Close();
        }

        public void CreateRental(int vehicleId, int clientId)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlFormattedDateReturn = myDateTime.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");


            string queryCreateRental = "INSERT INTO Rental (vehicle_id, cient_id, rent_date, return_date) " +
                                     $"VALUES({vehicleId},{clientId},{"'" + sqlFormattedDate + "'"}, {"'" + sqlFormattedDateReturn + "'"});"; 

            connection.Open();

            SqlCommand cmd = new SqlCommand(queryCreateRental, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void CreateDamage(int vehicleId, string damageReason)
        {
            int primaryKey = CreateDamageRow(damageReason);
       
            string query = "UPDATE Vehicle " +
                                    $"SET damage_id = {primaryKey} " +
                                    $"WHERE vehicle_id = {vehicleId};";

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public int CreateDamageRow(string damageReason)
        {
            int primaryKey = -1;
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            string queryCreateDamage = "INSERT INTO Damage (damage_data, damage_reason) " +                               
                                     $"VALUES({"'" + sqlFormattedDate + "'"},{"'" + damageReason + "'"});";

            connection.Open();

            SqlCommand command = new SqlCommand(queryCreateDamage, connection);
            command.ExecuteNonQuery();

            string query = "SELECT damage_id " +
                           "FROM Damage " +
                           $"WHERE damage_reason = {"'" + damageReason + "'"};";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                primaryKey = Int32.Parse(rd[0].ToString());
            }

            connection.Close();

            return primaryKey;
        }

        public int getClientId(string name, string surname, int adressId, int accountNumber)
        {
            int clientId = -1;
            string query = "SELECT client_id " +
                           "FROM Client " +
                           $"WHERE name = {"'" + name + "'"} AND surname = {"'" + surname + "'"} AND adress_id = {adressId} AND account_number = {accountNumber};";

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
           
                clientId = Int32.Parse(rd[0].ToString());
            }

            connection.Close();

            return clientId;
        }

        public int CreateClientRow(string name, string surname, int adressId, int accountNumber)
        {
            string query = "INSERT INTO Client (name, surname, adress_id, account_number) " +
                                     $"VALUES({"'" + name + "'"}, {"'" + surname + "'"}, {adressId}, {accountNumber});";

            connection.Open();

            SqlCommand commandSetIsAvaliableVehicle = new SqlCommand(query, connection);
            commandSetIsAvaliableVehicle.ExecuteNonQuery();

            connection.Close();

            return getClientId(name, surname, adressId, accountNumber);
        }
        
        public int getAdressId(string street, int streetNumber, string city)
        {
            int adressId = -1;
            string query = "SELECT adress_id " +
                           "FROM Adress " +
                           $"WHERE street = {"'" + street + "'"} AND street_number = {streetNumber} AND city = {"'" + city + "'"};";

            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                adressId = Int32.Parse(rd[0].ToString());
            }

            connection.Close();

            return adressId;
        }

        public int CreateAdressRow(string street, int streetNumber, string city)
        {
            string query = "INSERT INTO Adress (street, street_number, city) " +
                                     $"VALUES({"'" + street + "'"}, {streetNumber}, {"'" + city + "'"});";

            connection.Open();

            SqlCommand commandSetIsAvaliableVehicle = new SqlCommand(query, connection);
            commandSetIsAvaliableVehicle.ExecuteNonQuery();

            connection.Close();
          
            return getAdressId(street, streetNumber, city);
        }
    }
}
