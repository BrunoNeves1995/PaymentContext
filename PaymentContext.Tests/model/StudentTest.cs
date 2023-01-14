using PaymentContext.Domain.model;

namespace PaymentContext.Tests.model
{   
    [TestClass]
    public class StudentTest
    {

    [TestMethod]
    public void TestMethod1()
    {   
        var sub = new Subscriptions(DateTime.UtcNow);
        var student = new Student("bruno", "123456", "nevesbruno@gmail.com");
        student.AletarNome("Fabio");
        student.AddSubscription(sub);
        
    }


    }
}