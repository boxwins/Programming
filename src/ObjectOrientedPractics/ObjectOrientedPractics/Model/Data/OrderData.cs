namespace ObjectOrientedPractics.Model.Data
{
    public class OrderData
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }  
        public string Name { get; set; }
        public string Address { get; set; }
        public double Amount { get; set; }
        public OrderStatus Status { get; set; }
    }
}
