namespace EnterpriseCarDealership.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int Bookingid { get; set; }
        public double TotalPrice { get; set; }
        public Payment(int id, int bookingId, double totalPrice)
        {
            Id = id;
            Bookingid = bookingId;
            TotalPrice = totalPrice;
        }
        public Payment()
        {
            Id = -1;
            Bookingid = -1;
            TotalPrice = -1;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Bookingid)}={Bookingid.ToString()}, {nameof(TotalPrice)}={TotalPrice.ToString()}}}";
        }
    }
}
