namespace PaymentContext.Domain.model
{
    public class Subscriptions
    {   
        private readonly IList<Payment> _payments;
        public Subscriptions(DateTime expireDate)
        {
            CreateDate = DateTime.UtcNow;
            LastUpdateDate = DateTime.UtcNow;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        // Essa Assinatura(Subscriptions) tem um de pagamento(Payment)
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get; set; } = new List<Payment>();

        public bool ActivarSubscription(bool active)
        {
            Active = active;
            return Active;
        }

        public void Activete()
        {
           Active = true;
           LastUpdateDate = DateTime.UtcNow;
        }

         public void Inactivate()
        {
           Active = false;
           LastUpdateDate = DateTime.UtcNow;
        }
       
       
    }
}