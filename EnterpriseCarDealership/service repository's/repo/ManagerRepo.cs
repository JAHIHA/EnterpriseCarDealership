using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using Microsoft.Data.SqlClient;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class ManagerRepo : IManagerRepo
    {

        List<Manager> _managers = new List<Manager>();

        private readonly string ConString = "Data Source = mssql6.unoeuro.com; User ID = jhhweb_dk; Password = G2ftFgwApBE5ec3Dxn9r; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";




        public async Task AddManager(Manager manager)
        {
            string queryString = "INSERT INTO Manager (NextId, Name, Password, IsAdmin, Tlf) VALUES (@NextId, @Name, @Password,@IsAdmin, @Tlf);";

            SqlConnection connection = new SqlConnection(ConString);
            await  connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", manager.NextId);
            command.Parameters.AddWithValue("@Name", manager.Name.ToString());
            command.Parameters.AddWithValue("@Password", manager.Password.ToString());
            command.Parameters.AddWithValue("@IsAdmin", manager.IsAdmin);
            command.Parameters.AddWithValue("@Tlf", manager.Tlf.ToString());
         
            int rows = command.ExecuteNonQuery();
            if (rows != 1)
            {
                throw new ArgumentException("Manager er ikke oprettet");
            }

            connection.Close();
            var val = GetManagerList().Last().NextId;
            Console.WriteLine($"den nye id er : {val}");
            
        }

        public async Task DeleteManager(int id)
        {

            string queryString = "Delete from Manager where  id = @NextId";
            SqlConnection connection = new SqlConnection(ConString);

            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", id);

            int rows = command.ExecuteNonQuery();
            if (rows != 1)
            {
                throw new ArgumentException("Manager kunne ikke fjernes");
            }
            connection.Close();
            
        }

        public Manager GetManagerById(int id)
        {
            string query = $"select * from Manager where id = @NextId";
            SqlConnection connection = new SqlConnection(ConString);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NextId", id);
            SqlDataReader reader = command.ExecuteReader();
            Manager m = new Manager();
            while (reader.Read())
            {
                m = ReadManager(reader);
            }
            connection.Close();
            return m;
        }

        public List<Manager> GetManagerList()
        {
            string query = "select * from Manager";
            SqlConnection connection = new SqlConnection(ConString);

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            _managers.Clear();
            while (reader.Read())
            {
                Manager m = ReadManager(reader);
                _managers.Add(m);
            }
            connection.Close();

            return _managers;
        }

        public Manager ReadManager(SqlDataReader reader)
        {
            Manager m = new Manager();
            m.NextId = reader.GetInt32(0);
            m.Name = reader.GetString(1);
            m.Password=reader.GetString(2);
            m.IsAdmin = reader.GetBoolean(3);
            m.Tlf = reader.GetString(4);
            return m;
        }

        public async Task UpdateManager(Manager manager)
        {
            string queryString = "update Manager set NextId=@NextId,Name=@Name,Password=@Password,IsAdmin=@IsAdmin,Tlf=@Tlf";
            SqlConnection connection = new SqlConnection(ConString);
            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", manager.NextId);
            command.Parameters.AddWithValue("@Name", manager.Name.ToString());
            command.Parameters.AddWithValue("@Password", manager.Password.ToString());
            command.Parameters.AddWithValue("@IsAdmin", manager.IsAdmin);
            command.Parameters.AddWithValue("@Tlf", manager.Tlf.ToString());
            int rows = command.ExecuteNonQuery();
            if (rows != 1)
            {
                throw new ArgumentException("manager er ikke opdateret");
            }
            connection.Close();
        }
    }
}

    

    
       
    

