using PaymentContext.Domain.models.Contracts.Boleto;
using PaymentContext.Domain.ValueObject;

namespace PaymentContext.Domain.models
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barCode,
            string boletoNumber,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Addres address,
            Email email) : base(
                paidDate,
                expireDate,
                total,
                totalPaid,
                payer,
                document,
                address,
                email
            )
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;

            AddNotifications(new CreateBoletoPaymentContract(this));
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}