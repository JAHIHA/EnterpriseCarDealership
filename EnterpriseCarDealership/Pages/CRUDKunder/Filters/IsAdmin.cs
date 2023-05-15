using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.Pages.CRUDKunder.Filters
{
    public class IsAdmin : IKundeFilters
    {
        private IKundeFilters _filters;

        public IsAdmin(IKundeFilters filters)
        {
            _filters = filters;
        }

        public List<Kunde> Filter()
        {
            List<Kunde> kunde = _filters.Filter(); // Hent de filtrerede kunder fra det interne filterobjekt
            List<Kunde> filteredKunde = kunde.Where(kunde => kunde.IsAdmin).ToList(); // Filtrer om der er tale om en kunde eller admin

            return filteredKunde;
        }
    }
}
