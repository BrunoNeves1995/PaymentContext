namespace PaymentContext.Domain.model
{
    public class Student
    {
        // Aluno(Student) tem varias assinatura(Subscription)

        public string Name { get; private set; } = null!;
        public string Document { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string Address { get; private set; } = null!;

        public List<Subscriptions> Subscriptions { get; set;} = new();
    }
}