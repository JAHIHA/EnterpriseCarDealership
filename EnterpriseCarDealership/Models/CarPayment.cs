namespace EnterpriseCarDealership.Models
{
    public class CarPayment:Payment
    {
        public int CarBookingId {get; set;}
        public CarPayment(int id, double totalPrice, int carBookingId): base(id, totalPrice)
        {
            CarBookingId = carBookingId;
        }
        public CarPayment()
        {
            CarBookingId = -1;
        }

        public override string ToString()
        {
            return $"{{{nameof(CarBookingId)}={CarBookingId.ToString()}, {nameof(NextId)}={NextId.ToString()}, {nameof(TotalPrice)}={TotalPrice.ToString()}}}";
        }
    }
}
