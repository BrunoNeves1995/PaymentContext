using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand  : Notifiable<Notification>, ICommand
    {   
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Number { get; set; }
        public string? Email { get; set; }

        public string? BarCode { get; private set; }
        public string? BoletoNumber { get; private set; }

        public string? PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string? NamePayer { get; set; }
        public string? PayerDocument { get; set; }
        public string? DocumentType { get; set; }
        public string? Street { get; private set; }
        public string? NumberCasa { get; private set; }
        public string? Neighborhood { get; private set; }
        public string? City { get; private set; }
        public string? State { get; private set; }
        public string? Country { get; private set; }
        public string? ZipCode { get; private set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<CreateBoletoSubscriptionCommand>()
                .Requires()
                .IsNotNullOrEmpty(FirstName, "FirstName", "Nome inválido")
                // .IsNotNullOrEmpty(LastName, "LastName", "Sobre nome inválido")
                // .IsNotNullOrEmpty(Number, "Number", "Numero inválido")
                // .IsEmail(Email, "Email", "Email é inválido")
                // .IsNotNullOrEmpty(BarCode, "BarCode", "Codigo de barra é inválido")
                // .IsNotNullOrEmpty(BoletoNumber, "BoletoNumber", "Numero do boleto é inválido")
                // .IsNotNullOrEmpty(PaymentNumber, "PaymentNumber", "Numero do pagamento é inválido")
                // .IsNotNull(PaidDate, "PaidDate", "Data do pagamento é inválido")
                // .IsNotNull(ExpireDate, "PaidDate", "Data de expiração é inválido")
                // .IsNotNull(Total, "Total", "Total é inválido")
                // .IsNotNull(TotalPaid, "TotalPaid", "Total pago é inválido")
                // .IsNotNullOrEmpty(PayerDocument, "PayerDocument", "CPF é inválido")
                // .IsNotNullOrEmpty(DocumentType, "PayerDocument", "CPF é inválido")
                // .IsNotNullOrEmpty(Street, "Street", "Rua é inválido")
                // .IsNotNullOrEmpty(NumberCasa, "NumberCasa", "Numero da casa é inválido")
                // .IsNotNullOrEmpty(Neighborhood, "Neighborhood", "Bairro é inválido")
                // .IsNotNullOrEmpty(City, "City", "Cidade é inválido")
                // .IsNotNullOrEmpty(State, "State", "Estado é inválido")
                // .IsNotNullOrEmpty(Country, "Country", "Pais é inválido")
                // .IsNotNullOrEmpty(ZipCode, "ZipCode", "CEP é inválido")
            );
        }
    }
}