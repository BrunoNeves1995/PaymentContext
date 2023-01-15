using Flunt.Validations;
using PaymentContext.Domain.models.Contracts.Subscription;
using PaymentContext.Domain.ValueObject;
using PaymentContext.Shared.Models;

namespace PaymentContext.Domain.models
{

    public class Student : Model
    {
        private IList<Subscriptions> _subscriptions;
        public Student(Name name, Document document, Email email, Addres addres)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = addres;
            _subscriptions = new List<Subscriptions>();
        }

        // Aluno(Student) tem varias assinatura(Subscription)

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Addres Address { get; private set; }
        // public bool HasActiveSubscription { get; private set; }

        public IReadOnlyCollection<Subscriptions> Subscriptions { get { return _subscriptions.ToArray(); } }


        // verifica se o estudante tem uma inscrição ativa
        public void AddSubscription(Subscriptions subscription)
        {   
            _subscriptions.Add(subscription);

            var HasActiveSubscription = false;
            if( _subscriptions.Count() > 1)
                HasActiveSubscription = true;

            AddNotifications(
                new Contract<Student>()
                .Requires()
                .IsFalse(HasActiveSubscription, "Student.Subscription", "Você já tem uma assinatura ativa")
                .IsGreaterThan(subscription.Payments.Count(), 0, "Subscriptions.Payments", "Essa assinatura não possui pagamentos"));
        }
        
    }
}
