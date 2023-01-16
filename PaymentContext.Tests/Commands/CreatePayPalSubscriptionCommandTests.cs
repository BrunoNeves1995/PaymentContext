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
        public void DeveRetornaSucessoQaundoTodasAsImformacoesDoPayPalEstiver()
        {
            var Command = new CreatePayPalSubscriptionCommand();
            Command.FirstName = "Bruno";
            Command.Validate();
            
            Assert.IsTrue(Command.IsValid);
        }
    }
}