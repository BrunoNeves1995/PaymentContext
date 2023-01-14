using Flunt.Validations;

namespace PaymentContext.Domain.ValueObject.Contracts.Names
{
    public class CreateNameContract : Contract<Name>
    {
        public CreateNameContract(Name name)
        {
             Requires()
                .IsNullOrEmpty(name.FirstName, "FirstName", "Nome inválido")
                .IsMinValue(3 ,"name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .IsNullOrEmpty(name.LastName, "LastName", "Sobre nome inválido")
                .IsMaxValue(40 ,"name.FirstName", "Nome deve conter pelo menos 3 caracteres");
        }
    }
}