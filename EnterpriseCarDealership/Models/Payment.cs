namespace EnterpriseCarDealership.Models
{
    public abstract class Payment
    {
        public int NextId { get; set; }
     
        public double TotalPrice { get; set; }
        public Payment(int id,  double totalPrice)
        {
            id = NextId++;
            
            TotalPrice = totalPrice;
        }
        public Payment()
        {
            NextId = -1;
           
            TotalPrice = -1;
        }

        public override string ToString()
        {
            return $"{{{nameof(NextId)}={NextId.ToString()},  {nameof(TotalPrice)}={TotalPrice.ToString()}}}";
        }
    }
}
