using EnterpriseCarDealership.Models;
//using EnterpriseCarDealership.Pages.CRUDBike.Filters;

namespace EnterpriseCarDealership.Pages.CRUDKunder.Filters
{
    public class Adress : IKundeFilters
    {
        //KARZAN
        private IKundeFilters _filters;

        public Adress(IKundeFilters filters)
        {
            _filters = filters;
        }

        public List<Kunde> Filter()
        {
            List<Kunde> kunde = _filters.Filter(); // Hent de filtrerede kunder fra det interne filterobjekt
            List<Kunde> filteredKunde = kunde.Where(kunde => kunde.Adress).ToList(); // Filtrer kunder med adresse

            return filteredKunde;
        }
    }
}
