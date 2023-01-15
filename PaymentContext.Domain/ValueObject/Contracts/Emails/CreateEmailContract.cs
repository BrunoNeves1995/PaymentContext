using Flunt.Validations;

namespace PaymentContext.Domain.ValueObject.Contracts.Emails
{
    public class CreateEmailContract : Contract<Email>
    {
        public CreateEmailContract(Email email)
        {
            Requires()
                .IsEmail(email.Address, "Email.Address", "E-mail invalido");
        }
    }
}