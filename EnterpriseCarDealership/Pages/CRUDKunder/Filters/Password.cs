using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.Pages.CRUDKunder.Filters
{
    public class Password : IKundeFilters
    {
        private IKundeFilters _filters;

        public Password(IKundeFilters filters)
        {
            _filters = filters;
        }

        public List<Kunde> Filter()
        {
            List<Kunde> kunde = _filters.Filter(); // Hent de filtrerede kunder fra det interne filterobjekt
            List<Kunde> filteredKunde = kunde.Where(kunde => kunde.Password).ToList(); // Filtrer kunde med password 

            return filteredKunde;
        }
    }
}
