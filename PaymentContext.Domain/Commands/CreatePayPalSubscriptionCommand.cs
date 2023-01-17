

using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreatePayPalSubscriptionCommand :  Notifiable<Notification>, ICommand
    {
        public string FirstName { get;  set; } = null!;
        public string LastName { get;  set; } = null!;
        public string Number { get;  set; } = null!;
        public string Email { get;  set; } = null!;

        public string TransactionCode { get;  set; } = null!;
        
         public string PaymentNumber { get;  set; } = null!;
        public DateTime PaidDate { get;  set; } 
        public DateTime ExpireDate { get;  set; }
        public decimal Total { get;  set; } 
        public decimal TotalPaid { get;  set; } 
        public string NamePayer { get;  set; } = null!;
        public string Document { get;  set; } = null!;
        public EDocumentType DocumentType { get;  set; } 
        public string Street { get;  set; } = null!; 
        public string NumberCasa { get;  set; } = null!; 
        public string  Neighborhood{ get;  set; } = null!; 
        public string  City{ get;  set; } = null!; 
        public string  State{ get;  set; } = null!; 
        public string  Country{ get;  set; } = null!; 
        public string  ZipCode{ get;  set; } = null!;

        public void Validate()
        {
            AddNotifications(
                new Contract<CreatePayPalSubscriptionCommand>()
                .Requires()
                .IsNotNullOrEmpty(FirstName, "FirstName", "Nome inválido")
                .IsNotNullOrEmpty(LastName, "LastName", "Sobre nome inválido")
                .IsNotNullOrEmpty(Number, "Number", "Numero inválido")
                .IsEmail(Email, "Email", "Email é inválido")
                .IsNotNullOrEmpty(TransactionCode, "TransactionCode", "Numero da transação é inválido")
                .IsNotNullOrEmpty(PaymentNumber, "PaymentNumber", "Numero do pagamento é inválido")
                .IsNotNull(PaidDate, "PaidDate", "Data do pagamento é inválido")
                .IsNotNull(ExpireDate, "PaidDate", "Data de expiração é inválido")
                .IsNotNull(Total, "Total", "Total é inválido")
                .IsNotNull(TotalPaid, "TotalPaid", "Total pago é inválido")
                .IsNotNullOrEmpty(Document, "Document", "CPF é inválido")
                .IsNotNull(DocumentType, "PayerDocument", "CPF é inválido")
                .IsNotNullOrEmpty(Street, "Street", "Rua é inválido")
                .IsNotNullOrEmpty(NumberCasa, "NumberCasa", "Numero da casa é inválido")
                .IsNotNullOrEmpty(Neighborhood, "Neighborhood", "Bairro é inválido")
                .IsNotNullOrEmpty(City, "City", "Cidade é inválido")
                .IsNotNullOrEmpty(State, "State", "Estado é inválido")
                .IsNotNullOrEmpty(Country, "Country", "Pais é inválido")
                .IsNotNullOrEmpty(ZipCode, "ZipCode", "CEP é inválido")
            );
        }
    }
}