using System.Linq.Expressions;
using PaymentContext.Domain.models;

namespace PaymentContext.Domain.Queries
{
    public static class StudentQueries
    {   
        // Exemplo de expression

        public static Expression<Func<Student, bool>> GetStudentInfo(string document)
        {
            return x => x.Document.Number == document;
        }
    }
}