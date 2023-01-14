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
        public Address? Address { get; private set; }

        public IReadOnlyCollection<Subscriptions> Subscriptions { get {return _subscriptions.ToArray();}}

        public void AddSubscription(Subscriptions subscription)
        {
            foreach (var sub in Subscriptions)
                sub.Activete();

            _subscriptions.Add(subscription);

        }
        
    }
}