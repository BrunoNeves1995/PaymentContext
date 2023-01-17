using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreatePayPalSubscriptionCommandTests
    {
        // Comand que nao testaria, apenas como exemplo
        
        [TestMethod]
        public void DeveRetornaUmErroSequalquerInformacaoDoPayPalEstiverInvalida()
        {
            var Command = new CreatePayPalSubscriptionCommand();
            Command.FirstName = "";
            Command.Validate();

            Assert.IsFalse(Command.IsValid);
        }

        [TestMethod]
        public void DeveRetornaSucessoQaundoTodasAsImformacoesDoPayPalEstiverValida()
        {
            var command = new CreatePayPalSubscriptionCommand();
            command.FirstName = "Bruno";
            command.LastName = "Neves";
            command.Number = "12345678";
            command.Email =  "brunoneves_f@hotmail.com";
            command.TransactionCode = "4433334455662200";
            command.PaymentNumber = "100980";
            command.PaidDate = DateTime.UtcNow;
            command.ExpireDate = DateTime.UtcNow.AddMonths(1);
            command.Total = 100;
            command.TotalPaid = 100;
            command.NamePayer = "Luiz Henrique de brito";
            command.Document = "04778440145";
            command.DocumentType = Domain.Enums.EDocumentType.CPF;
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