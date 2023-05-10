﻿using EnterpriseCarDealership.Models;
using EnterpriseCarDealership.Pages.CRUDKunder;
using Microsoft.Data.SqlClient;

namespace EnterpriseCarDealership.service_repository_s.repo
{
    public interface IKundeRepo
    {
        //KARZAN

        public Kunde ReadKunde(SqlDataReader reader);
        public List<Kunde> GetKundeList();

        public Task Addkunde(CreateKunde createkunde);


        public Task Updatekunde(Kunde kunde);


        public Kunde GetKundeById(int id);

        public Task Deletekunde(int id);
    }
}
