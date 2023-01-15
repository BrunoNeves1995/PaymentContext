using Flunt.Validations;

namespace PaymentContext.Domain.ValueObject.Contracts.Address
{
    public class CreateAddressContract : Contract<Addres>
    {
        public CreateAddressContract(Addres address)
        {
            Requires()
                .IsNotNullOrEmpty(address.Street, "Address.City", "Rua inválida")
                .IsNotNullOrEmpty(address.Number, "Address.Number", "Numero inválida")
                .IsNotNullOrEmpty(address.Neighborhood, "Address.Neighborhood", "Bairro inválida")
                .IsNotNullOrEmpty(address.Neighborhood, "Address.Neighborhood", "Bairro inválida")
                .IsNotNullOrEmpty(address.City, "Address.City", "cidade inválida")
                .IsNotNullOrEmpty(address.State, "Address.State", "Estado inválida")
                .IsNotNullOrEmpty(address.Country, "Address.Country", "Estado inválida")
                .IsNotNullOrEmpty(address.ZipCode, "Address.ZipCode", "CEP inválida");
                
        }
    }
}