namespace Gaolos.Application.Features.Account.Queries.PaymentMethods.GetPaymentMethods
{
    public class CreditCardsVm
    {
        public Guid CreditCardId { get; set; }
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public string CardHolderName { get; set; }
        public bool isPrimary { get; set; }
    }
}