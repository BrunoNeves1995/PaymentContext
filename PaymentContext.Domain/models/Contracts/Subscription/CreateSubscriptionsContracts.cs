using Flunt.Validations;

namespace PaymentContext.Domain.models.Contracts.Subscription
{
    public class CreateSubscriptionsContracts : Contract<Subscriptions>
    {
        public CreateSubscriptionsContracts(Subscriptions subscriptions)
        { 
             Requires()
                .IsNull(subscriptions.ExpireDate, "Subscriptions.ExpireDate", "Data de expiração é inválida");
        }
    }
}