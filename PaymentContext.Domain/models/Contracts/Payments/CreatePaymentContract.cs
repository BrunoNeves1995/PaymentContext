using Flunt.Validations;

namespace PaymentContext.Domain.models.Contracts.Payments
{
    public class CreatePaymentContract : Contract<Payment>
    {
        public CreatePaymentContract(Payment payment)
        {
            Requires()
                .IsNotNullOrEmpty(payment.NamePayer, "Payment.NamePayer", "Nome do pagador é invalido")
                .IsGreaterThan(payment.PaidDate, DateTime.UtcNow, "Payment.PaidDate", "A data de pagamento não pode ser menor que a data atual")
                .IsGreaterOrEqualsThan(payment.ExpireDate, DateTime.UtcNow, "Payment.ExpireDate", "A data de expiração não pode ser menor ou igual a data atual")
                .IsGreaterThan(payment.Total, 0, "Payment.Total", "Total nao pode zer zero")
                .IsGreaterThan(payment.TotalPaid, payment.Total, "Payment.Total", "O valor a ser pago é maior que o valor do pagamento");
        }
    }
}