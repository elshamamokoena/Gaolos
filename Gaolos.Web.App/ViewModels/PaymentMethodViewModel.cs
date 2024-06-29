namespace Gaolos.Web.App.ViewModels
{
    public class PaymentMethodViewModel
    {
        public Guid CreditCardId { get; set; }
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public string CVV { get; set; } = string.Empty;
        public string CardHolderName { get; set; }
        public bool isPrimary { get; set; }
        public string CardType { get; set; }
    }
}
