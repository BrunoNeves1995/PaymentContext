namespace PaymentContext.Domain.model
{
    public class CreditCardPayment : Payment
    {
        public string CardHolderName { get; private set; } = null!;
        public string CardNumber { get; private set; } = null!;
        public string LastTransactionNumber { get; private set; } = null!;
    }
}