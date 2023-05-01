using DocumentFormat.OpenXml.ExtendedProperties;
using EnterpriseCarDealership.Models;
using Microsoft.Data.SqlClient;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class KundeRepo : IKundeRepo
    {

        List<Kunde> kunder = new List<Kunde>();

        private readonly string ConString = "Data Source = mssql6.unoeuro.com; User ID = jhhweb_dk; Password = G2ftFgwApBE5ec3Dxn9r; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        public async Task Addkunde(Kunde kunde)
        {
            string queryString = "INSERT INTO Kunde (NextId, Name, Password, IsAdmin, Tlf) VALUES (@NextId, @Name, @Password,@IsAdmin, @Tlf);";


            SqlConnection connection = new SqlConnection(ConString);
            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", kunde.;
            command.Parameters.AddWithValue("@Name", kunde.Name.ToString());
            command.Parameters.AddWithValue("@Password", kunde.Password.ToString());
            command.Parameters.AddWithValue("@IsAdmin", kunde.IsAdmin);
            command.Parameters.AddWithValue("@Tlf", kunde.Tlf.ToString());

            int rows = command.ExecuteNonQuery();

            connection.Close();
            var val = GetKundeList().Last().NextId;
            Console.WriteLine($"den nye id er : {val}");
        }

        public async Task Deletekunde(int id)
        {
            string queryString = "Delete from Kunde where  id = @NextId";
            SqlConnection connection = new SqlConnection(ConString);


            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", id);


            int rows = command.ExecuteNonQuery();

            connection.Close();
        }


        public Kunde GetKundeById(int id)
        {
            string query = $"select * from Kunde where id = @NextId";
            SqlConnection connection = new SqlConnection(ConString);



            connection.Open();



            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NextId", id);
            SqlDataReader reader = command.ExecuteReader();
            Kunde k = new Kunde();
            while (reader.Read())
            {
                k = ReadKunde(reader);
            }
            connection.Close();
            return k;
        }


        public List<Kunde> GetKundeList()
        {
            string query = "select * from Kunde";
            SqlConnection connection = new SqlConnection(ConString);



            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            kunder.Clear();
            while (reader.Read())
            {
                Kunde k = ReadKunde(reader);
                kunder.Add(k);
            }
            connection.Close();



            return kunder;
        }


        public Kunde ReadKunde(SqlDataReader reader)
        {
            Kunde k = new Kunde();
            k.NextId = reader.GetInt32(0);
            k.Name = reader.GetString(1);
            k.Password = reader.GetString(2);
            k.IsAdmin = reader.GetBoolean(3);
            k.Tlf = reader.GetString(4);
            return k;
        }


        public async Task Updatekunde(Kunde kunde)
        {
            string queryString = "update Kunde set NextId=@NextId,Name=@Name,Password=@Password,IsAdmin=@IsAdmin,Tlf=@Tlf";
            SqlConnection connection = new SqlConnection(ConString);
            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", kunder.NextId);
            command.Parameters.AddWithValue("@Name", kunder.Name.ToString());
            command.Parameters.AddWithValue("@Password", kunder.Password.ToString());
            command.Parameters.AddWithValue("@IsAdmin", kunder.IsAdmin);
            command.Parameters.AddWithValue("@Tlf", kunder.Tlf.ToString());
            int rows = command.ExecuteNonQuery();



            connection.Close();
        }
    }
}
