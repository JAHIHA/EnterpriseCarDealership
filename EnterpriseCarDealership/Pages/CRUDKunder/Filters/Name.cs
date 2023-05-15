using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.Pages.CRUDKunder.Filters
{
    public class Name : IKundeFilters
    {
        private IKundeFilters _filters;

        public Name(IKundeFilters filters)
        {
            _filters = filters;
        }

        public List<Kunde> Filter()
        {
            List<Kunde> kunde = _filters.Filter(); // Hent de filtrerede kunder fra det interne filterobjekt
            List<Kunde> filteredKunde = kunde.Where(kunde => kunde.Name).ToList(); // Filtrer kunde med navn 

            return filteredKunde;
        }
    }
}
