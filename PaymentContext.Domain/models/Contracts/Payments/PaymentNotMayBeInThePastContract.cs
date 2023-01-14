using Flunt.Validations;

namespace PaymentContext.Domain.models.Contracts.Payments
{
    public class PaymentNotMayBeInThePastContract : Contract<Payment>
    {
        public PaymentNotMayBeInThePastContract(Payment payment)
        {
            Requires()
                .IsGreaterThan(payment.PaidDate, DateTime.UtcNow, "Payment.PaidDate", 
                "Data de pagamento não pode ser menos que a data atual");

        }
    }
}