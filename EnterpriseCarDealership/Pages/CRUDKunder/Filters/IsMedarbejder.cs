using EnterpriseCarDealership.Models;

namespace EnterpriseCarDealership.Pages.CRUDKunder.Filters
{
    public class IsMedarbejder : IKundeFilters
    {
        private IKundeFilters _filters;

        public IsMedarbejder(IKundeFilters filters)
        {
            _filters = filters;
        }

        public List<Kunde> Filter()
        {
            List<Kunde> kunde = _filters.Filter(); // Hent de filtrerede kunder fra det interne filterobjekt
            List<Kunde> filteredKunde = kunde.Where(kunde => kunde.IsMedarbejder).ToList(); // Filtrer om der er tale om en kunde eller medarbejder 

            return filteredKunde;
        }
    }
}
