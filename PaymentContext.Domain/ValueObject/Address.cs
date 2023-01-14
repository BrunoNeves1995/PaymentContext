using PaymentContext.Shared.ValueObjects;

namespace  PaymentContext.Domain.ValueObject 
{
    public class Address : ObjetoValor
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        public string Street { get; private set; } = null!;
        public string Number { get; private set; } = null!;
        public string  Neighborhood{ get; private set; } = null!;
        public string  City{ get; private set; } = null!;
        public string  State{ get; private set; } = null!;
        public string  Country{ get; private set; } = null!;
        public string  ZipCode{ get; private set; } = null!;
    }
}