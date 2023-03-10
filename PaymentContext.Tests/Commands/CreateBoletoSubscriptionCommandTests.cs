using System.Reflection.Metadata;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        // Comand que nao testaria, apenas como exemplo

        [TestMethod]
        public void DeveRetornaUmErroSequalquerInformacaoDoBoletoEstiverInvalida()
        {
            var Command = new CreateBoletoSubscriptionCommand();
            Command.FirstName = "";
            Command.Validate();

            Assert.IsFalse(Command.IsValid);
        }

        [TestMethod]
        public void DeveRetornaSucessoQaundoTodasAsImformacoesDoBoletoEstiverValida()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruno";
            command.LastName = "Neves";
            command.Document = "12345678";
            command.Email = "brunoneves_f@hotmail.com";
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

            command.Validate();

            Assert.IsTrue(command.IsValid);
        }
    }
}