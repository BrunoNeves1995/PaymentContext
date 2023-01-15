using Flunt.Validations;

namespace PaymentContext.Domain.models.Contracts.Subscription
{
    public class CreateSubscriptionsContracts : Contract<Subscriptions>
    {
        public CreateSubscriptionsContracts(Subscriptions subscriptions)
        { 
             Requires()
                .IsNotNull(subscriptions.ExpireDate, "Subscriptions.ExpireDate", "Data de expiração é inválida")
                .IsLowerOrEqualsThan( DateTime.UtcNow, subscriptions.ExpireDate, "Payment.PaidDate", "A data de expiração não pode ser menor ou igual a data atual");
        }
    }
}