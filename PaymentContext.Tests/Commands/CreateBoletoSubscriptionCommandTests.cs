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
            var Command = new CreateBoletoSubscriptionCommand();
            Command.FirstName = "Bruno";
            Command.Validate();
            
            Assert.IsTrue(Command.IsValid);
        }
    }
}