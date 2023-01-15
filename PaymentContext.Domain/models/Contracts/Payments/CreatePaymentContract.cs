using Flunt.Validations;

namespace PaymentContext.Domain.models.Contracts.Payments
{
    public class CreatePaymentContract : Contract<Payment>
    {
        public CreatePaymentContract(Payment payment)
        {
            Requires()
                .IsNotNullOrEmpty(payment.NamePayer, "Payment.NamePayer", "Nome do pagador é invalido")
                .IsLowerOrEqualsThan(payment.PaidDate, DateTime.UtcNow, "Payment.PaidDate", "A data de pagamento não pode ser menor ou igual a data atual")
                .IsGreaterOrEqualsThan(payment.ExpireDate, DateTime.UtcNow,  "Payment.ExpireDate", "A data de expiração não pode ser menor ou igual a data atual")
                .IsGreaterThan(payment.Total, 0,  "Payment.Total", "Total nao pode zer zero")
                .IsLowerOrEqualsThan(payment.TotalPaid, payment.Total, "Payment.Total", "O total pago, não pode ser maior que o meu total");
        }
    }
}