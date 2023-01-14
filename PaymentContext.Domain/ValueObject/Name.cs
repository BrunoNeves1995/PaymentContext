using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObject
{
    public class Name  : ObjetoValor
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; } = null!;
        public string LastName { get; private set; } = null!;

        public void AlterarNome(string firstName, string lastName){
            FirstName = firstName;
            LastName = lastName;
        }
    }
}