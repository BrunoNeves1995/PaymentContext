using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;

namespace PaymentContext.Domain.models.Contracts.CredCard
{
    public class CreateCredCardPaymentContract : Contract<CreditCardPayment>
    {
        public CreateCredCardPaymentContract(CreditCardPayment creditCardPayment)
        {
             Requires()
                .IsNotNullOrEmpty(creditCardPayment.CardHolderName, "creditCardPayment.CardHolderName", "Nome do titular do cartão é invalido")
                .IsNotNullOrEmpty(creditCardPayment.CardNumber, "creditCardPayment.CardNumber", "Número do cartão é invalido")
                .IsNotNullOrEmpty(creditCardPayment.LastTransactionNumber, "creditCardPayment.LastTransactionNumber", "Número da última transação é invalido");
                
        }
    }
}