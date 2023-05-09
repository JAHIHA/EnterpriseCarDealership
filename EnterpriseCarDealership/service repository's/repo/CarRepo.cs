using DocumentFormat.OpenXml.ExtendedProperties;
using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.service_repository_s.repo.interfaces;
using Microsoft.Data.SqlClient;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class CarRepo : ICarRepo

    {
        List<Car> _cars = new List<Car>(); 

        private readonly string ConString = "Server=mssql6.unoeuro.com;Database=jhhweb_dk_db_database;User Id=jhhweb_dk;Password=G2ftFgwApBE5ec3Dxn9r;MultipleActiveResultSets=False;Encrypt=False";


        public async Task Addcar(Car car)
        {
            String queryString = "INSERT INTO Car(NextId,Brand,Type,PrisPrDag,Year,Km,AC,Sunroof,Screen,DVD,Camera,Sensor) VALUES (@NextId,@Brand,@Type,@PrisPrDag,@Year,@Km,@AC,@Sunroof,@Screen,@DVD,@Camera,@Sensor)";

            SqlConnection connection = new SqlConnection(ConString);
            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", car.NextId);
            command.Parameters.AddWithValue("@Brand", car.Brand.ToString());
            command.Parameters.AddWithValue("@Type", car.Type);
            command.Parameters.AddWithValue("@PrisPrDag", car.PrisPrDag);
            command.Parameters.AddWithValue("@Year", car.Year);
            command.Parameters.AddWithValue("@Km", car.Km);
            command.Parameters.AddWithValue("@AC", car.AC);
            command.Parameters.AddWithValue("@Sunroof", car.Sunroof);
            command.Parameters.AddWithValue("@Screen", car.Screen);
            command.Parameters.AddWithValue("@DVD", car.DVD);
            command.Parameters.AddWithValue("@Camera", car.Camera);
            command.Parameters.AddWithValue("@Sensor", car.Sensor);

         
            connection.Close();
            
        }


        public async Task Deletecar(int id)
        {
            string queryString = "Delete from Car where  id = @NextId";
            SqlConnection connection = new SqlConnection(ConString);

            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", id);

            int rows = command.ExecuteNonQuery();
            if (rows != 1)
            {
                throw new ArgumentException("Car kunne ikke fjernes");
            }
            connection.Close();
        }

        public Car GetCarById(int id)
        {
            string query = $"select * from Car where id = @NextId";
            SqlConnection connection = new SqlConnection(ConString);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NextId", id);
            SqlDataReader reader = command.ExecuteReader();
            Car car= new Car();
            while (reader.Read())
            {
                car = ReadCar(reader);
            }
            connection.Close();
            return car; 
        }

        public List<Car> GetCarList()
        {
            string query = "select * from Car";
            SqlConnection connection = new SqlConnection(ConString);

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            _cars.Clear();
            while (reader.Read())
            {
                Car car = ReadCar(reader);
                _cars.Add(car);
            }
            connection.Close();

            return _cars; 

        }

        public Car ReadCar(SqlDataReader reader)
        {
            Car car=new Car();
            car.NextId = reader.GetInt32(0);
            car.Brand = reader.GetString(1);
            var type= Enum.Parse<MotorType>(reader.GetString(2));
            car.Type=type;
            car.PrisPrDag = reader.GetInt32(3);
            car.Year = reader.GetInt32(4);
            car.Km = reader.GetInt32(5);
            car.AC = reader.GetBoolean(6);
            car.Sunroof=reader.GetBoolean(7);
            car.Screen = reader.GetBoolean(8);
            car.DVD = reader.GetBoolean(9); 
            car.Camera=reader.GetBoolean(10);
            car.Sensor = reader.GetBoolean(11);
            return car; 


        }

        public async Task Updatecar(Car car)
        {
            string queryString = "Update Car set NextId=@NextId, Brand=@Brand,Type=@Type,PrisPrDag=@PrisPrDag,Year=@Year, Km=@Km, Ac=@AC, Sunroof=@Sunroof, Screen=@Screen, DVD=@DVD, Camera=@Camera, Sensor=@Sensor";
            SqlConnection connection = new SqlConnection(ConString);
            await connection.OpenAsync();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@NextId", car.NextId);
            command.Parameters.AddWithValue("@Brand", car.Brand.ToString());
            command.Parameters.AddWithValue("@Type", car.Type);
            command.Parameters.AddWithValue("@PrisPrDag", car.PrisPrDag);
            command.Parameters.AddWithValue("@Year", car.Year);
            command.Parameters.AddWithValue("@Km", car.Km);
            command.Parameters.AddWithValue("@AC", car.AC);
            command.Parameters.AddWithValue("@Sunroof", car.Sunroof);
            command.Parameters.AddWithValue("@DVD", car.DVD);
            command.Parameters.AddWithValue("@Camera", car.Camera);
            command.Parameters.AddWithValue("@Sensor", car.Sensor);
            int rows = command.ExecuteNonQuery(); 
            if(rows!=1)
            {
                throw new ArgumentException("car er ikke opdateret");

            }
            connection.Close();
        }

    }
}

