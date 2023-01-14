using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObject
{
    public class Document  : ObjetoValor
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; } = null!;
        public EDocumentType Type { get; private set; }

         public void AletarDocumento(string number)
         {
            Number = number;
        }
    }
    
}