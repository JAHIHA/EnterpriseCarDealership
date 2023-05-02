using EnterpriseCarDealership.DBContextFolder;
using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public class MedarbejderRepo:IMedarbejderRepo
    {
        private DealershipContext _medarbejdercontext = new DealershipContext();  

        public async Task  Addmedarbejder(Medarbejder medarbejder)
        {
            _medarbejdercontext.Add(medarbejder);
            await _medarbejdercontext.SaveChangesAsync();
        }

        public async Task Deletemedarbejder(int id)
        {
            Medarbejder medarbejder = GetmedarbejderById(id);
            _medarbejdercontext.Remove(medarbejder);
            await _medarbejdercontext.SaveChangesAsync();
        }

        public Medarbejder GetmedarbejderById(int id)
        {
            Medarbejder medarbejder = GetmedarbejderList().FirstOrDefault(x => x.NextId == id);
            return medarbejder; 

           
        }

        public List<Medarbejder> GetmedarbejderList()
        {
            return new List<Medarbejder>(_medarbejdercontext.Medarbejder);
        }

        public async Task Updatemedarbejder(Medarbejder medarbejder)
        {
            Medarbejder existingmedarbejder = GetmedarbejderById(medarbejder.NextId);
                 
                existingmedarbejder.Name = medarbejder.Name;
                existingmedarbejder.Tlf = medarbejder.Tlf;
                existingmedarbejder.Adress = medarbejder.Adress;
                existingmedarbejder.Password = medarbejder.Password;
                existingmedarbejder.ManagerId = medarbejder.ManagerId;
                existingmedarbejder.IsAdmin = medarbejder.IsAdmin;

            await _medarbejdercontext.SaveChangesAsync(); 
        }
            

        }
    }

