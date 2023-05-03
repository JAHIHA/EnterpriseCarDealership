namespace EnterpriseCarDealership.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public double TotalPrice { get; set; }
        public Payment(int id, int bookingId, double totalPrice)
        {
            Id = id;
            BookingId = bookingId;
            TotalPrice = totalPrice;
        }
        public Payment()
        {
            Id=-1;
            BookingId=-1;
            TotalPrice=-1;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(BookingId)}={BookingId.ToString()}, {nameof(TotalPrice)}={TotalPrice.ToString()}}}";
        }
    }
}
