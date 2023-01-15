using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.models;

namespace PaymentContext.Domain.Repositories
{
    public interface IStudentReposository
    {
        bool DocumentExists(string document);
        bool EmailExists(string document);

        public void CreateSubscription(Student student);
    }
}