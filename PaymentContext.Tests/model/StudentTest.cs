using PaymentContext.Domain.Enums;
using PaymentContext.Domain.models;
using PaymentContext.Domain.ValueObject;

namespace PaymentContext.Tests.model
{
    [TestClass]
    public class StudentTest
    {   
        private  Student _student;
        private  Subscriptions _subscription;
         private  Subscriptions _subscription1;
        private  Name? _name=null;
        private  Document _document;
        private  Email _email;
        private  Addres _address;


        public StudentTest()
        {   
            // Gerando um estudante

             _name = new Name("Bruno", "Neves");
             _document = new Document("04778440145", EDocumentType.CPF);
             _email = new Email("nevesbruno814@gmail.com");
             _address = new Addres("Rua 1", "200", "Barro 1", "Mirasssol", "Barsil", "MT", "78280-000");
             _student = new Student(_name, _document, _email);

            // Gerando um assinatura
            _subscription = new Subscriptions(DateTime.UtcNow.AddMonths(1));
            _subscription1 = new Subscriptions(DateTime.UtcNow.AddMonths(1));

            
        }


        [TestMethod]
        public void DeveRetornaUmErroQuandosForAdicionarMaisDeUmaAssinatura()
        {   
            var  total = 11;
            var totalPaid = 10;

            // gerando pagamento
            var payment = new PayPalPayment("1234567890", DateTime.UtcNow, DateTime.UtcNow.AddDays(5), total, totalPaid, "Luis Enrique", _document, _address, _email);
            _subscription.AddPayment(payment);

            // Adicionando inscrição
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription1);
            
            Assert.IsFalse(_student.IsValid);
        }

         [TestMethod]
        public void DeveRetornaUmErroQaundoAssinaturaNaoTiverUmPagamento()
        {
            _student.AddSubscription(_subscription);
            Assert.IsFalse(_student.IsValid);
        }

         [TestMethod]
        public void DeveRetornaSucessoQuandosForAdicionarUmaAsinatura()
        {

            var  valorCompra = 10;
            var valorPago = 10;

            // gerando pagamento
            var payment = new PayPalPayment("1234567890", DateTime.UtcNow, DateTime.UtcNow.AddDays(5), valorCompra, valorPago, "Luis Enrique", _document, _address, _email);
            _subscription.AddPayment(payment);

            // Adicionando inscrição
            _student.AddSubscription(_subscription);
            
            Assert.IsTrue(_student.IsValid);

        }

        
    }
}