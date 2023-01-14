using PaymentContext.Domain.ValueObject;
using PaymentContext.Shared.Models;

namespace PaymentContext.Domain.models
{
    public abstract class Payment : Model
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string namePayer, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            NamePayer = namePayer;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number { get; private set; } = null!;
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string NamePayer { get; private set; } = null!;
        public Document Document { get; private set; }
        public Address Address { get; private set; }  = null!;
        public Email Email { get; private set; }  = null!;
    }
}