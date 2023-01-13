namespace PaymentContext.Domain.model
{
    public class Subscriptions
    {
        // Essa Assinatura(Subscriptions) tem um de pagamento(Payment)
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public List<Payment> Payments { get; set; } = new();
    }
}