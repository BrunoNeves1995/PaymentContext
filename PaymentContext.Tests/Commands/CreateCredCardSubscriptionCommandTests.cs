using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateCredCardSubscriptionCommandTests
    {
        // Comand que nao testaria, apenas como exemplo

        [TestMethod]
        public void DeveRetornaUmErroSequalquerInformacaoDoCredCardEstiverInvalida()
        {
            var Command = new CreateCredCardSubscriptionCommand();
            Command.FirstName = "";
            Command.Validate();

            Assert.IsFalse(Command.IsValid);
        }

        [TestMethod]
        public void DeveRetornaSucessoQaundoTodasAsImformacoesDoCredCardEstiverValida()
        {
            var command = new CreateCredCardSubscriptionCommand();
            command.FirstName = "Bruno";
            command.LastName = "Neves";
            command.Number = "12345678";
            command.Email = "brunoneves";
            command.CardHolderName = "Luiz Henrique de brito";
            command.CardNumber = "4433334455662200";
            command.LastTransactionNumber = "100280";
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

            Assert.IsTrue(command.IsValid);
        }
    }
}