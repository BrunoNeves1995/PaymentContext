
using System.Windows.Input;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObject;

namespace PaymentContext.Domain.Commands
{
    public class CreatePayPalSubscriptionCommand
    {
        // É a junção de todas as informações que a gente precisa para criar um subscription
        // São objeto de transporte, passage, de uma camada para a outra 

        public string? FirstName { get;  set; }
        public string? LastName { get;  set; }
        public string? Number { get;  set; }
        public string? Email { get;  set; }

        public string? TransactionCode { get;  set; }
        
         public string? PaymentNumber { get;  set; }
        public DateTime PaidDate { get;  set; }
        public DateTime ExpireDate { get;  set; }
        public decimal Total { get;  set; }
        public decimal TotalPaid { get;  set; }
        public string? NamePayer { get;  set; }
        public string? PayerDocument { get;  set; }
        public EDocumentType DocumentType { get;  set; }
        public string? Street { get; private set; } 
        public string? NumberCasa { get; private set; } 
        public string?  Neighborhood{ get; private set; } 
        public string?  City{ get; private set; } 
        public string?  State{ get; private set; } 
        public string?  Country{ get; private set; } 
        public string?  ZipCode{ get; private set; }
       
       
    }
}