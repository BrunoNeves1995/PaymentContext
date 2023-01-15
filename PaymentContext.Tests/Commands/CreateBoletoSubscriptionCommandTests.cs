using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.Commands;

namespace PaymentContext.Tests.Commands
{   
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        // Comand que nao testaria, apenas como exemplo
        
        [TestMethod]
        public void DeveRetornaUmErroSequalquerInformacaoEstiverInvalida()
        {
            var Command = new CreateBoletoSubscriptionCommand();
            Command.FirstName = "";
            Command.Validate();

            Assert.IsFalse(Command.IsValid);
        }

        [TestMethod]
        public void DeveRetornaSucessoQaundoAstiverTodasAsImformacoes()
        {
            var Command = new CreateBoletoSubscriptionCommand();
            Command.FirstName = "Bruno";
            Command.Validate();
            
            Assert.IsTrue(Command.IsValid);
        }
    }
}