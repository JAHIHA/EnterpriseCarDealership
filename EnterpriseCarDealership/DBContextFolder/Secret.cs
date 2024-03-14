namespace EnterpriseCarDealership.DBContextFolder
{
    //Jakob
    public static class Secret
    {
        /// <summary>
        /// Her vi har vores forbindelses-string til vores database.
        /// </summary>
        public static String GetConnectionString
        {
            get
            {
                return
                //"Data Source = mssql6.unoeuro.com; User ID = jhhweb_dk; Password = G2ftFgwApBE5ec3Dxn9r; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                "Server=mssql6.unoeuro.com;Database=jhhweb_dk_db_database;User Id=jhhweb_dk;Password=G2ftFgwApBE5ec3Dxn9r;MultipleActiveResultSets=False;Encrypt=False";
            }
        }
    }
}
