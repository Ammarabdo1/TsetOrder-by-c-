namespace CMSApp.BL
{
    public class OrderItem
    {
        //Constructors
        public OrderItem() { }
        public OrderItem(int orderItemId)
        {
            this.orderItemId = orderItemId;

        }
        public OrderItem(int ProductId , int Quantity , decimal? PurchasePrice)
        {
            this.ProductId = ProductId;
            this.Quantity = Quantity;
            this.PurchasePrice = PurchasePrice;

        }

        //Properties
        public int orderItemId { get; private set; }
        public int ProductId {  get; private set; }
        public decimal? PurchasePrice { get; private set; }
        public int Quantity {  get; private set; }
        
        //Methods
        public OrderItem Retrueve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            bool saving = true;
            if ( orderItemId <= 0 ) saving = false;

            return saving;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <=0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;

        }
    }

}
