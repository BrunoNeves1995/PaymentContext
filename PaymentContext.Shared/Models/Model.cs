using Flunt.Notifications;

namespace PaymentContext.Shared.Models
{
    public abstract class Model : Notifiable<Notification>
    {
        protected Model()
        {
            Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 16);
        }

        public string Id { get; private set; }
    }
}