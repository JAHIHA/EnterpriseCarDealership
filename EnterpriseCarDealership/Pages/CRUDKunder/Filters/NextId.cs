using EnterpriseCarDealership.Models;
//using EnterpriseCarDealership.Pages.CRUDBike.Filters;

namespace EnterpriseCarDealership.Pages.CRUDKunder.Filters
{
    public class NextId : IKundeFilters
    {
        //KARZAN
        private IKundeFilters _filters;

        public NextId(IKundeFilters filters)
        {
            _filters = filters;
        }

        public List<Kunde> Filter()
        {
            List<Kunde> kunde = _filters.Filter(); // Hent de filtrerede kunder fra det interne filterobjekt
            List<Kunde> filteredKunde = kunde.Where(kunde => kunde.NextId).ToList(); // Filtrer kunder med Id

            return filteredKunde;
        }
    }
}
