namespace Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethod
{
    public class PaymentMethodVm
    {
        public Guid CreditCardId { get; set; }
        public Guid UserId { get; set; }
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public string CVV { get; set; }
        public string CardHolderName { get; set; }
        public bool isPrimary { get; set; } = true;
        public string CardType { get; set; }= "Visa";

     
    }
}