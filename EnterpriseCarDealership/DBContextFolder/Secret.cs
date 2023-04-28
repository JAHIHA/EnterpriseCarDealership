using DocumentFormat.OpenXml.Bibliography;
using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.DBContextFolder
{
    public static class Secret
    {
        public static String GetConnectionString
        {
            get
            {
                return
           "Data Source = mssql6.unoeuro.com; User ID = jhhweb_dk; Password = ********; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            }
        }
    }
}
