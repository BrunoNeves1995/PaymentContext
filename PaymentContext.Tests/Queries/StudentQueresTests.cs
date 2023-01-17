using System.Linq;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.models;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObject;

namespace PaymentContext.Tests.Queries
{
    // [TestClass]
    public class StudentQueresTests
    {
        private IList<Student> _students;
        private List<Document> _document;
        private int i;

       
        public StudentQueresTests()
        {
            _document?.Add(new Document("81985437325", EDocumentType.CPF));
            _document?.Add(new Document("23631661835", EDocumentType.CPF));
            _document?.Add(new Document("44738496433", EDocumentType.CPF));
            _document?.Add(new Document("84141156329", EDocumentType.CPF));
            _document?.Add(new Document("26214143037", EDocumentType.CPF));
            _document?.Add(new Document("36164647657", EDocumentType.CPF));
            _document?.Add(new Document("16973641520", EDocumentType.CPF));
            _document?.Add(new Document("43384742460", EDocumentType.CPF));
            _document?.Add(new Document("13793856798", EDocumentType.CPF));
            _document?.Add(new Document("35745544864", EDocumentType.CPF));

            for (i = 0; i < 10; i++)
            {
                _students?.Add(new Student(
                    new Name("Aluno", $"sobreNome{i.ToString()}"),
                    _document![i],
                    new Email(i.ToString() + "teste@hotmail.com")
                    ));

                Console.WriteLine(_students);
            }
        }

        //  [TestMethod]
        public void DeveRetornaNuloQuandoDocumentoNaoExistir()
        {
            var expression = StudentQueries.GetStudentInfo("88744345453");
            var student = _students.AsQueryable().Where(expression).FirstOrDefault();

            Assert.AreEqual(null, student);
        }

        // [TestMethod]
        public void DeveRetornaAlunoQuandoDocumentoExistir()
        {

            var expression = StudentQueries.GetStudentInfo($"{_document[i]}");
            var student = _students.AsQueryable().Where(expression).FirstOrDefault();
            Assert.AreEqual(null, student);
        }
    }
}