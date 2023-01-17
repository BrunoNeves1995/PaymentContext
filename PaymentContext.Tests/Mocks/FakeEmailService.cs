using PaymentContext.Domain.Services;

namespace PaymentContext.Tests.Mocks
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string toName, string toEmail, string subject, string body, string fromName, string fromEmail)
        {
            
        }
    }
}