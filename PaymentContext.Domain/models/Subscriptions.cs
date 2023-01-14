
using Flunt.Validations;
using PaymentContext.Domain.models.Contracts.Payments;
using PaymentContext.Domain.models.Contracts.Subscription;
using PaymentContext.Shared.Models;

namespace PaymentContext.Domain.models
{
    public class Subscriptions : Model
    {   
        private readonly IList<Payment> _payments;
        public Subscriptions(DateTime expireDate)
        {
            CreateDate = DateTime.UtcNow;
            LastUpdateDate = DateTime.UtcNow;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();

            AddNotifications(new CreateSubscriptionsContracts(this));
        }

        // Essa Assinatura(Subscriptions) tem um de pagamento(Payment)
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get {return _payments.ToArray();} }
        // public IReadOnlyCollection<Payment> Payments { get; private set; }

        public void AddPayment(Payment payment)
        {   
            AddNotifications(new PaymentNotMayBeInThePastContract(payment));
            
            _payments.Add(payment);
            
            
            
            // AddNotifications(
            //     new Contract<Payment>()
            //     .Requires()
            //     .IsGreaterThan(payment.PaidDate, DateTime.UtcNow, 
            //         "Payment.PaidDate", "Data de pagamento não pode ser menos que a data atual"));
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