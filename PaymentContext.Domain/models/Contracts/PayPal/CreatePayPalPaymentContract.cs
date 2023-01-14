using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;

namespace PaymentContext.Domain.models.Contracts.PayPal
{
    public class CreatePayPalPaymentContract : Contract<PayPalPayment>
    {
        public CreatePayPalPaymentContract(PayPalPayment payPalPayment)
        {
            Requires()
                .IsNotNullOrEmpty(payPalPayment.TransactionCode, "PayPalPayment.TransactionCode", "Código de transação é inválido");
        }
    }
}