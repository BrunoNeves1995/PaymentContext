using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void DeveRetornaUmErroQuandoSeDocumentoJaExisti()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruno";
            command.LastName = "Neves";
            command.Document = "04778440145";
            command.Email = "nevesbruno@gmail.com";
            command.BarCode = "codigo de barra";
            command.BoletoNumber = "1234455464112332456436463455678567834523523543234545";
            command.PaymentNumber = "100980";
            command.PaidDate = DateTime.UtcNow;
            command.ExpireDate = DateTime.UtcNow.AddMonths(1);
            command.Total = 100;
            command.TotalPaid = 100;
            command.NamePayer = "Luiz Henrique de brito";
            command.PayerDocument = "35742744676";
            command.DocumentType = Domain.Enums.EDocumentType.CPF;
            command.PayerEmail = "luiz@hotmail.com";
            command.Street = "Rua 1";
            command.NumberCasa = "216";
            command.Neighborhood = "Barro 1";
            command.City = "Mirassol";
            command.State = "Mato Grosso";
            command.Country = "Brasil";
            command.ZipCode = "78280-000";

            handler.Handler(command);
            Assert.AreEqual(false, handler.IsValid);
        }

         [TestMethod]
        public void DeveRetornaSucessoSeDocumentoNaoExisti()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruno";
            command.LastName = "Neves";
            command.Document = "35742744676";
            command.Email = "nevesbruno@gmail.com";
            command.BarCode = "codigo de barra";
            command.BoletoNumber = "1234455464112332456436463455678567834523523543234545";
            command.PaymentNumber = "100980";
            command.PaidDate = DateTime.UtcNow;
            command.ExpireDate = DateTime.UtcNow.AddMonths(1);
            command.Total = 100;
            command.TotalPaid = 100;
            command.NamePayer = "Luiz Henrique de brito";
            command.PayerDocument = "04778440145";
            command.DocumentType = Domain.Enums.EDocumentType.CPF;
            command.PayerEmail = "luiz@hotmail.com";
            command.Street = "Rua 1";
            command.NumberCasa = "216";
            command.Neighborhood = "Barro 1";
            command.City = "Mirassol";
            command.State = "Mato Grosso";
            command.Country = "Brasil";
            command.ZipCode = "78280-000";

            handler.Handler(command);
            Assert.AreEqual(true, handler.IsValid);
        }

        [TestMethod]
        public void DeveRetornaUmErroQuandoEmailJaExisti()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruno";
            command.LastName = "Neves";
            command.Document = "68066231156";
            command.Email = "brunoneves_f@hotmail.com";
            command.BarCode = "codigo de barra";
            command.BoletoNumber = "1234455464112332456436463455678567834523523543234545";
            command.PaymentNumber = "100980";
            command.PaidDate = DateTime.UtcNow;
            command.ExpireDate = DateTime.UtcNow.AddMonths(1);
            command.Total = 100;
            command.TotalPaid = 100;
            command.NamePayer = "Luiz Henrique de brito";
            command.PayerDocument = "35742744676";
            command.DocumentType = Domain.Enums.EDocumentType.CPF;
            command.PayerEmail = "luiz@hotmail.com";
            command.Street = "Rua 1";
            command.NumberCasa = "216";
            command.Neighborhood = "Barro 1";
            command.City = "Mirassol";
            command.State = "Mato Grosso";
            command.Country = "Brasil";
            command.ZipCode = "78280-000";

            handler.Handler(command);
            Assert.AreEqual(false, handler.IsValid);
        }

         [TestMethod]
        public void DeveRetornaSucessoSeEmailNaoExisti()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruno";
            command.LastName = "Neves";
            command.Document = "68066231156";
            command.Email = "nevesbruno814@gmail.com";
            command.BarCode = "codigo de barra";
            command.BoletoNumber = "1234455464112332456436463455678567834523523543234545";
            command.PaymentNumber = "100980";
            command.PaidDate = DateTime.UtcNow;
            command.ExpireDate = DateTime.UtcNow.AddMonths(1);
            command.Total = 100;
            command.TotalPaid = 100;
            command.NamePayer = "Luiz Henrique de brito";
            command.PayerDocument = "35742744676";
            command.DocumentType = Domain.Enums.EDocumentType.CPF;
            command.PayerEmail = "luiz@hotmail.com";
            command.Street = "Rua 1";
            command.NumberCasa = "216";
            command.Neighborhood = "Barro 1";
            command.City = "Mirassol";
            command.State = "Mato Grosso";
            command.Country = "Brasil";
            command.ZipCode = "78280-000";

            handler.Handler(command);
            Assert.AreEqual(true, handler.IsValid);
        }
    }
}