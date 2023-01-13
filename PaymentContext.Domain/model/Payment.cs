using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentContext.Domain.model
{
    public abstract class Payment
    {
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