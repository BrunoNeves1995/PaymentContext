using PaymentContext.Domain.models.Contracts.Subscription;
using PaymentContext.Domain.ValueObject;
using PaymentContext.Shared.Models;

namespace PaymentContext.Domain.models
{

    public class Student : Model
    {
        private readonly IList<Subscriptions> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscriptions>();
        }

        // Aluno(Student) tem varias assinatura(Subscription)

        public Name Name { get; private set; } = null!;
        public Document Document { get; private set; } = null!;
        public Email Email { get; private set; } = null!;
        public Addres? Address { get; private set; }
        // public bool HasActiveSubscription { get; private set; }

        public IReadOnlyCollection<Subscriptions> Subscriptions { get { return _subscriptions.ToArray(); } }

        // verifica se o estudante tem uma inscrição ativa
        public void AddSubscription(Subscriptions subscription)
        {
            var HasActiveSubscription = false;
            foreach (var sub in Subscriptions)
            {
                if (sub.Active)
                    HasActiveSubscription = true; 
            }
            AddNotifications(new VerifiSubscriptionsIsActive(HasActiveSubscription));
        }
        
    }
}
