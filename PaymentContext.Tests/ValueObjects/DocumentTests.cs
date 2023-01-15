
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObject;

namespace PaymentContext.Tests.ValueObjects
{   
    [TestClass]
    public class DocumentTests
    {
        
        [TestMethod]
        [DataTestMethod]
        [DataRow("04778440144")]
        [DataRow("25225307044")]
        [DataRow("6247047101")]
        [DataRow("01850352034")]
        [DataRow("33573857088")]
        public void DeveRetornaUmErroQuandoCPFEInvalido(string cpf)
        {   
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsFalse(doc.IsValid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("04778440145")]
        [DataRow("25225307043")]
        [DataRow("62470471001")]
        [DataRow("01850352054")]
        [DataRow("33573857086")]
        public void DeveRetornaSucessoQuandoCPFEValido(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.IsValid);
        }

        [TestMethod]
        public void DeveRetornaUmErroQuandoCNPJEInvalido()
        {
           var doc = new Document("04778440145123", EDocumentType.CNPJ);
            Assert.IsFalse(doc.IsValid);
        }

        [TestMethod]
        public void DeveRetornaSucessoQuandoCNPJEValido()
        {   
            var doc = new Document("81105023000162", EDocumentType.CNPJ);
            Assert.IsTrue(doc.IsValid);
            
        }
    }
}