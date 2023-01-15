using PaymentContext.Domain.ValueObject.Contracts.Address;
using PaymentContext.Shared.ValueObjects;

namespace  PaymentContext.Domain.ValueObject 
{
    public class Addres : ObjetoValor
    {
        public Addres(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new CreateAddressContract(this));
        }

        public string Street { get; private set; } 
        public string Number { get; private set; } 
        public string  Neighborhood{ get; private set; } 
        public string  City{ get; private set; } 
        public string  State{ get; private set; } 
        public string  Country{ get; private set; } 
        public string  ZipCode{ get; private set; } 
    }
}