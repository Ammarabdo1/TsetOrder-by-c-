using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CMSApp.BL
{
    public class Product
    {
        public Product() { }
        public Product(int productId)
        {
            this.productId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription {  get; set; }
        public int productId {  get; set; }
        public string ProductName {  get; set; }

        public Product Retrieve(int  productId)
        {
            return new Product();
        }

        public bool Save()
        {
            bool Saving = true;
            if(productId <=0) Saving = false;
            return Saving;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName) || ProductName.Length < 2) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }


    }
 
}
