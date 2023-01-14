using PaymentContext.Domain.ValueObject;

namespace PaymentContext.Domain.models
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            string cardHolderName,
            string cardNumber,
            string lastTransactionNumber,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Address address,
            Email email) : base(
                paidDate,
                expireDate,
                total,
                totalPaid,
                payer,
                document,
                address,
                email
            )
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; } = null!;
        public string CardNumber { get; private set; } = null!;
        public string LastTransactionNumber { get; private set; } = null!;
    }
}