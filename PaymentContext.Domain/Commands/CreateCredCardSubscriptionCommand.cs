using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.Commands
{
    public class CreateCredCardSubscriptionCommand
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Number { get; set; }
        public string? Email { get; set; }

        public string? CardHolderName { get; private set; }
        public string? CardNumber { get; private set; }
        public string? LastTransactionNumber { get; private set; }

        public string? PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string? NamePayer { get; set; }
        public string? PayerDocument { get; set; }
        public EDocumentType DocumentType { get; set; }
        public string? Street { get; private set; }
        public string? NumberCasa { get; private set; }
        public string? Neighborhood { get; private set; }
        public string? City { get; private set; }
        public string? State { get; private set; }
        public string? Country { get; private set; }
        public string? ZipCode { get; private set; }
    }
}