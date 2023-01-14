namespace PaymentContext.Shared.Models
{
    public abstract class Model
    {
        protected Model()
        {
            Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 16);
        }

        public string Id { get; private set; }
    }
}