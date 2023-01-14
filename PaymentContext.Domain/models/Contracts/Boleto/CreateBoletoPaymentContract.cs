using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;

namespace PaymentContext.Domain.models.Contracts.Boleto
{
    public class CreateBoletoPaymentContract : Contract<BoletoPayment>
    {
        public CreateBoletoPaymentContract(BoletoPayment boletoPayment)
        {
            Requires()
                .IsNotNullOrEmpty(boletoPayment.BarCode, "BoletoPayment.BarCode", "Codigo de barra é invalido")
                .IsNotNullOrEmpty(boletoPayment.BoletoNumber, "BoletoPayment.BoletoNumber", "Numero do boleto é invalido");

        }
    }
}