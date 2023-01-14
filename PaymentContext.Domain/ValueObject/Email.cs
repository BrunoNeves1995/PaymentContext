using Flunt.Notifications;
using PaymentContext.Domain.ValueObject.Contracts.Emails;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObject
{
    public class Email  : ObjetoValor
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new CreateEmailContract(this));
        }

        private IReadOnlyCollection<Notification> CreateEmailContract(Email email)
        {
            throw new NotImplementedException();
        }

        public string Address { get; private set; } = null!;

        public void AlterarEmail(string address)
        {
            Address = address;
        }
    }
}