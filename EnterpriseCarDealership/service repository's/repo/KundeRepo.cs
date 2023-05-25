using DocumentFormat.OpenXml.ExtendedProperties;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDKunder;
using Microsoft.Data.SqlClient;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class KundeRepo : IKundeRepo
    {
        //KARZAN

        List<Kunde> _kunde = new List<Kunde>();

        private readonly string ConString = "Server=mssql6.unoeuro.com;Database=jhhweb_dk_db_database;User Id=jhhweb_dk;Password=G2ftFgwApBE5ec3Dxn9r;MultipleActiveResultSets=False;Encrypt=False";



       

       

        public Kunde GetKundeById(int id)
        {
            string query = $"select * from Kunde where NextId = @NextId";
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
            _kunde.Clear();
            while (reader.Read())
            {
                Kunde k = ReadKunde(reader);
                _kunde.Add(k);
            }
            connection.Close();

            return _kunde;
        }

        public Kunde ReadKunde(SqlDataReader reader)
        {
            Kunde k = new Kunde();
            k.NextId = reader.GetInt32(0);
            k.Name = reader.GetString(1);
            k.Password = reader.GetString(2);
            k.IsMedarbejder = reader.GetBoolean(3);
            k.IsAdmin = reader.GetBoolean(4);
            k.Tlf = reader.GetString(5);
            k.Adress = reader.GetString(6); 
            return k;
        }

        

        public async Task Addkunde(CreateKunde kunde)
        {
            string queryString = "INSERT INTO Kunde ( Name, Password, IsMedarbejder, IsAdmin, Tlf, Adress) VALUES ( @Name, @Password,@IsMedarbejder,@IsAdmin, @Tlf, @Adress);";

            SqlConnection connection = new SqlConnection(ConString);
            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            //command.Parameters.AddWithValue("@NextId", kunde.NextId);
            command.Parameters.AddWithValue("@Name", kunde.Name.ToString());
            command.Parameters.AddWithValue("@Password", kunde.password.ToString());
            command.Parameters.AddWithValue("@IsMedarbejder", kunde.IsMedarbejder);
            command.Parameters.AddWithValue("@IsAdmin", kunde.isAdmin);
            command.Parameters.AddWithValue("@Tlf", kunde.tlf.ToString());
            command.Parameters.AddWithValue("@Adress", kunde.adress.ToString());
            var rows = command.ExecuteNonQuery();
            if (rows != 1)
            {
                throw new ArgumentException("Kunde er ikke oprettet");
            }

            connection.Close();
        }

        public async Task Updatekunde(int id, Kunde kunde)
        {
            string queryString = "update Kunde set Name=@Name,Password=@Password, IsMedArbejder=@IsMedarbejder,IsAdmin=@IsAdmin,Tlf=@Tlf, Adress=@Adress where NextId =@id";
            SqlConnection connection = new SqlConnection(ConString);
            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            //command.Parameters.AddWithValue("@NextId", kunde.NextId);
            command.Parameters.AddWithValue("@Name", kunde.Name.ToString());
            command.Parameters.AddWithValue("@Password", kunde.Password.ToString());
            command.Parameters.AddWithValue("@IsMedarbejder", kunde.IsMedarbejder);
            command.Parameters.AddWithValue("@IsAdmin", kunde.IsAdmin);
            command.Parameters.AddWithValue("@Tlf", kunde.Tlf.ToString());
            command.Parameters.AddWithValue("@Adress", kunde.Adress.ToString());
            command.Parameters.AddWithValue("@id", id);
            int rows = command.ExecuteNonQuery();
            if (rows != 1)
            {
                throw new ArgumentException("Kunde er ikke opdateret");
            }
            connection.Close();
        }

        public async Task Deletekunde(int id)
        {
            string queryString = "Delete from Kunde where  NextId = @NextId";
            SqlConnection connection = new SqlConnection(ConString);

            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
