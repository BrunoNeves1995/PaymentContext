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
            var Command = new CreateCredCardSubscriptionCommand();
            Command.FirstName = "Bruno";
            Command.Validate();
            
            Assert.IsTrue(Command.IsValid);
        }
    }
}