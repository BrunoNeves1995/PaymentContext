using Flunt.Validations;

namespace PaymentContext.Domain.models.Contracts.Subscription
{
    public class VerifiSubscriptionsIsActive : Contract<bool>
    {
        public VerifiSubscriptionsIsActive(bool hasActive)
        {
            Requires()
                .IsFalse(hasActive, "Student.Subscription", "Você já tem uma assinatura ativa");
        }
    }
}