using Flunt.Validations;

namespace PaymentContext.Domain.ValueObject.Contracts.Address
{
    public class CreateAddressContract : Contract<Addres>
    {
        public CreateAddressContract(Addres address)
        {
            Requires()
                .IsNullOrEmpty(address.Street, "Address.City", "Rua inválida")
                .IsNullOrEmpty(address.Number, "Address.Number", "Numero inválida")
                .IsNullOrEmpty(address.Neighborhood, "Address.Neighborhood", "Bairro inválida")
                .IsNullOrEmpty(address.Neighborhood, "Address.Neighborhood", "Bairro inválida")
                .IsNullOrEmpty(address.City, "Address.City", "cidade inválida")
                .IsNullOrEmpty(address.State, "Address.State", "Estado inválida")
                .IsNullOrEmpty(address.Country, "Address.Country", "Estado inválida")
                .IsNullOrEmpty(address.ZipCode, "Address.ZipCode", "CEP inválida");
                
        }
    }
}