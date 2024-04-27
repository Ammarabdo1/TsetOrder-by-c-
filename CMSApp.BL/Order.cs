namespace CMSApp.BL
{
    public class Order
    {
        public Order() { }
        public Order(int orderId)
        {
            this.orderId = orderId;
        }

        public DateTimeOffset? orderDate { get; set; }
        public int orderId { get; set; }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (orderDate == null) isValid = false;

            return isValid;
        }
    }
}