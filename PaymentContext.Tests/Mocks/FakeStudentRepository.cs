using PaymentContext.Domain.models;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentReposository
    {
        public void CreateSubscription(Student student)
        {
           
        }

        public bool DocumentExists(string document)
        {
            if(document == "04778440145")
                return true;
            
            return false;
        }

        public bool EmailExists(string email)
        {
            if(email == "brunoneves_f@hotmail.com")
                return true;
            
            return false;
        }
    }
}