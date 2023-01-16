using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreateCredCardSubscriptionCommand :  Notifiable<Notification>, ICommand
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Number { get; set; } = null!;
        public string Email { get; set; } = null!;

        public string CardHolderName { get; private set; } = null!;
        public string CardNumber { get; private set; } = null!;
        public string LastTransactionNumber { get; private set; } = null!;

        public string PaymentNumber { get; set; } = null!;
        public DateTime PaidDate { get; set; } 
        public DateTime ExpireDate { get; set; } 
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string NamePayer { get; set; } = null!;
        public string Document { get; set; } = null!;
        public EDocumentType DocumentType { get; set; }
        public string Street { get; private set; } = null!;
        public string NumberCasa { get; private set; } = null!;
        public string Neighborhood { get; private set; } = null!;
        public string City { get; private set; } = null!;
        public string State { get; private set; } = null!;
        public string Country { get; private set; } = null!;
        public string ZipCode { get; private set; } = null!;

        public void Validate()
        {
            AddNotifications(
                new Contract<CreateCredCardSubscriptionCommand>()
                .Requires()
                .IsNotNullOrEmpty(FirstName, "FirstName", "Nome inválido")
                // .IsNotNullOrEmpty(LastName, "LastName", "Sobre nome inválido")
                // .IsNotNullOrEmpty(Number, "Number", "Numero inválido")
                // .IsEmail(Email, "Email", "Email é inválido")
                // .IsNotNullOrEmpty(CardHolderName, "CardHolderName", "Nome do citular do cartão é inválido")
                // .IsNotNullOrEmpty(CardNumber, "CardNumber", "Numero do cartão é inválido")
                // .IsNotNullOrEmpty(LastTransactionNumber, "LastTransactionNumber", "Numero da ultima transação é inválido")
                // .IsNotNullOrEmpty(PaymentNumber, "PaymentNumber", "Numero do pagamento é inválido")
                // .IsNotNull(PaidDate, "PaidDate", "Data do pagamento é inválido")
                // .IsNotNull(ExpireDate, "PaidDate", "Data de expiração é inválido")
                // .IsNotNull(Total, "Total", "Total é inválido")
                // .IsNotNull(TotalPaid, "TotalPaid", "Total pago é inválido")
                // .IsNotNullOrEmpty(Document, "Document", "CPF é inválido")
                // .IsNotNull(DocumentType, "PayerDocument", "CPF é inválido")
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