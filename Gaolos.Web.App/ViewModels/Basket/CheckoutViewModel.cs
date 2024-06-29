namespace Gaolos.Web.App.ViewModels.Basket
{
    public class CheckoutViewModel
    {
        public Guid BasketId { get; set; }
        public string Comments { get; set; }

        public decimal OrderTotal { get; set; }

        //user info
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        // public string Country { get; set; }
        public Guid? UserId { get; set; }

        //payment information
        public string CardNumber { get; set; } = "1234567891111213";
        public string CardName { get; set; } = "Elhihi";
        public string CardExpiration { get; set; } = "04/04";
        public string CvvCode { get; set; } = "099";

    }
}
