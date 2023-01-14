using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentContext.Domain.model
{
    public abstract class Payment
    {
        protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string address, string email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number { get; private set; } = null!;
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPaid { get; private set; }
        public string Payer { get; private set; } = null!;
        public string Document { get; private set; }  = null!;
        public string Address { get; private set; }  = null!;
        public string Email { get; private set; }  = null!;
    }
}