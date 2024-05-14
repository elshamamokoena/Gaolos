namespace Gaolos.Web.App.ViewModels.Account.DeliveryAddress
{
    public class DeliveryAddressViewModel
    {
        public Guid DeliveryAddressId { get; set; }
        public Guid UserId { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;    
        public string ZipCode { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Complex { get; set; } = string.Empty;
        public string Suburb { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }

        public override string ToString()
        {
            return $"{Street}, {Suburb}, {ZipCode}, {City}, {Province}";
        }
    }
}
