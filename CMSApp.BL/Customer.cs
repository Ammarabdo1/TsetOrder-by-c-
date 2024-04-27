using static System.Console;
namespace CMSApp.BL
{
    public class Customer
    {
        //Constructor
        public Customer()
        {

        }

        public Customer(string FirstName, string _LastName, string EmailAddress)
        {
            this.FirstName = FirstName;
            this._LastName = _LastName; 
            this.EmailAddress = EmailAddress;
        }

        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string _LastName { get; set ; }

        public string Name { get { return $"{FirstName}, {_LastName}"; } }

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            var isValid = true;
            
            if(string.IsNullOrWhiteSpace(FirstName)||FirstName.Length <3) isValid=false;
            else if(string.IsNullOrWhiteSpace(_LastName) || _LastName.Length < 3) isValid=false;
            else if(string.IsNullOrWhiteSpace(EmailAddress) ||  EmailAddress.Length < 12) isValid=false;
            else isValid = true;
            return isValid;
        }

        public Customer Retrive(int CustomerId)
        {
            return new Customer();
        }

        public List<Customer> Retrive()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
