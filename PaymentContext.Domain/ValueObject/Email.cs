using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObject
{
    public class Email  : ObjetoValor
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; } = null!;

        public void AlterarEmail(string address)
        {
            Address = address;
        }
    }
}