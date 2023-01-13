namespace PaymentContext.Domain.model
{
    public class PayPalPayment : Payment
    {
         public string TransactionCode { get; private set; } = null!;
    }
}