using static System.Console;
namespace CMSApp.Order
{
    public class Order
    {
        public Order() { }  
        public Order(int orderId)
        {
            this.orderId = orderId;
        }

        public DateTimeOffset? orderDate {  get; set; }
        public int orderId {  get; set; }

    }
}
