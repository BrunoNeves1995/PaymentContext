namespace PaymentContext.Domain.model
{
    public class Student
    {   
        private IList<Subscriptions> _subscriptions;
        public Student(string name, string document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
           _subscriptions = new List<Subscriptions>();
        }

        // Aluno(Student) tem varias assinatura(Subscription)

        public string Name { get; private set; } = null!;
        public string Document { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string? Address { get; private set; }

        public IReadOnlyCollection<Subscriptions> Subscriptions { get {return _subscriptions.ToArray();}}

        public void AletarNome(string nome){
            Name = nome;
        }

        public void AddSubscription(Subscriptions subscription)
        {
            foreach (var sub in Subscriptions)
                sub.Activete();
                
            _subscriptions.Add(subscription);

        }
        
    }
}