namespace PaymentContext.Domain.model
{
    public class BoletoPayment : Payment
    {
        public string BarCode { get; private set; } = null!;
        public string BoletoNumber { get; private set; } = null!;
    }
}