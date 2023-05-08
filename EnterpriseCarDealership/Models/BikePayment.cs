namespace EnterpriseCarDealership.Models
{
    public class BikePayment:Payment
    {

        public int BikeBookingId { get; set; }
        public BikePayment(int id, double totalPrice, int bikeBookingId) : base(id, totalPrice)
        {
            BikeBookingId = bikeBookingId;
        }
        public BikePayment()
        {
            BikeBookingId = -1;
        }

        public override string ToString()
        {
            return $"{{{nameof(BikeBookingId)}={BikeBookingId.ToString()}, {nameof(NextId)}={NextId.ToString()}, {nameof(TotalPrice)}={TotalPrice.ToString()}}}";
        }
    }
}
