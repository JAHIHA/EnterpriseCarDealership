using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.Pages.CRUDKunder.Filters
{
    public class Tlf : IKundeFilters
    {
        private IKundeFilters _filters;

        public Tlf(IKundeFilters filters)
        {
            _filters = filters;
        }

        public List<Kunde> Filter()
        {
            List<Kunde> kunde = _filters.Filter(); // Hent de filtrerede kunder fra det interne filterobjekt
            List<Kunde> filteredKunde = kunde.Where(kunde => kunde.Tlf).ToList(); // Filtrer kunde med telefon nummer 

            return filteredKunde;
        }
    }
}
