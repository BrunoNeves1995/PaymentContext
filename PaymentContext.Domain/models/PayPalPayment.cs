using PaymentContext.Domain.models.Contracts.PayPal;
using PaymentContext.Domain.ValueObject;

namespace PaymentContext.Domain.models
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string transactionCode,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Addres address,
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
            TransactionCode = transactionCode;

            AddNotifications(new CreatePayPalPaymentContract(this));
        }

        public string TransactionCode { get; private set; }
    }
}