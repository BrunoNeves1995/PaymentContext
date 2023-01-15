using PaymentContext.Domain.ValueObject.Contracts.Names;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObject
{
    public class Name  : ObjetoValor
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new CreateNameContract(this));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public void AlterarNome(string firstName, string lastName){
            FirstName = firstName;
            LastName = lastName;
        }
    }
}