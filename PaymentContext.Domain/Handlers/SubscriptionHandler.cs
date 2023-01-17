using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.models;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.Services;
using PaymentContext.Domain.ValueObject;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handler;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler :
        Notifiable<Notification>,
        IHandler<CreateBoletoSubscriptionCommand>,
        IHandler<CreatePayPalSubscriptionCommand>,
        IHandler<CreateCredCardSubscriptionCommand>             
     

    {

        private readonly IStudentReposository _repository;
        private readonly IEmailService _emailService;

        public SubscriptionHandler(IStudentReposository reposository, IEmailService emailService)
        {
            _repository = reposository;
            _emailService = emailService;
        }
        public ICommandResult Handler(CreateBoletoSubscriptionCommand command)
        {
            // Fail, Fast Validation
            command.Validate();

            if(!command.IsValid)
            {   
                AddNotifications(command);
                return new CommandResult(false, "Não foi possivel realizar sua assinatura");
            }
               
            // verificar se o documento ja esta cadastrado
            if(_repository.DocumentExists(command.Document))
                AddNotification("Document", "Esse CPF já está cadastrado");

            // verificar se o email ja esta cadastrado
            if(_repository.EmailExists(command.Email))
                AddNotification("Email", "Esse E-mail já está cadastrado");

            // Gerar os Vos
                var name = new Name(command.FirstName, command.LastName);
                var document = new Document(command.Document,command.DocumentType);
                var email = new Email(command.Email);
                var address = new Addres(command.Street, command.NumberCasa, command.Neighborhood, command.City, command.State, command.Country, command.ZipCode);
                var student = new Student(name, document, email);
                var subscription = new Subscriptions(DateTime.UtcNow.AddMonths(1));

            // Geras as entidade
                var payment = new BoletoPayment(
                    command.BarCode, 
                    command.BoletoNumber, 
                    command.PaidDate, 
                    command.ExpireDate, 
                    command.Total, 
                    command.TotalPaid, 
                    command.NamePayer, 
                    document, 
                    address, 
                    email
                );

            // Relacionamentos
                subscription.AddPayment(payment);
                student.AddSubscription(subscription);
            
            // Agrupar as validações
                AddNotifications(name, document, email, address, student, subscription, payment);

            // Checa as Validações
            if(!IsValid)
                return new CommandResult(false, "Não foi possivel realizar sua assinatura");

            // salvar as informações
            _repository.CreateSubscription(student);

            // enviar email de boas vindas
            _emailService.Send(student.Name.ToString(), student.Email.Address, "Bem vindo ao balta.io", "Sua assinatura foi criada com sucesso!", "Balta.oi", "brunoneves_f@hotmail.com");

            // retorna as informações
            return new CommandResult(true, "Assinatura Realizada com sucesso");
        }

        public ICommandResult Handler(CreatePayPalSubscriptionCommand command)
        {
            // Fail, Fast Validation
            command.Validate();
            if(command.IsValid)
            {   
                AddNotifications(command);
                return new CommandResult(false, "Não foi possivel realizar sua assinatura");
            }
               
            // verificar se o documento ja esta cadastrado
            if(_repository.DocumentExists(command.Document))
                AddNotification("Document", "Esse CPF já está cadastrado");

            // verificar se o email ja esta cadastrado
            if(_repository.DocumentExists(command.Email))
                AddNotification("Email", "Esse E-mail já está cadastrado");

            // Gerar os Vos
                var name = new Name(command.FirstName, command.LastName);
                var document = new Document(command.Document,command.DocumentType);
                var email = new Email(command.Email);
                var address = new Addres(command.Street, command.NumberCasa, command.Neighborhood, command.City, command.State, command.Country, command.ZipCode);
                var student = new Student(name, document, email);
                var subscription = new Subscriptions(DateTime.UtcNow.AddMonths(1));

            // Geras as entidade
                var payment = new PayPalPayment(
                    command.TransactionCode,
                    command.PaidDate, 
                    command.ExpireDate, 
                    command.Total, 
                    command.TotalPaid, 
                    command.NamePayer, 
                    document, 
                    address, 
                    email
                );

            // Relacionamentos
                subscription.AddPayment(payment);
                student.AddSubscription(subscription);
            
            // Agrupar as validações
                AddNotifications(name, document, email, address, student, subscription, payment);

            // salvar as informações
            _repository.CreateSubscription(student);

            // enviar email de boas vindas
            _emailService.Send(student.Name.ToString(), student.Email.Address, "Bem vindo ao balta.io", "Sua assinatura foi criada com sucesso!", "Balta.oi", "brunoneves_f@hotmail.com");

            // retorna as informações
            return new CommandResult(true, "Assinatura Realizada com sucesso");
        }

        public ICommandResult Handler(CreateCredCardSubscriptionCommand command)
        {
            // Fail, Fast Validation
            command.Validate();
            if(command.IsValid)
            {   
                AddNotifications(command);
                return new CommandResult(false, "Não foi possivel realizar sua assinatura");
            }
               
            // verificar se o documento ja esta cadastrado
            if(_repository.DocumentExists(command.Document))
                AddNotification("Document", "Esse CPF já está cadastrado");

            // verificar se o email ja esta cadastrado
            if(_repository.EmailExists(command.Email))
                AddNotification("Email", "Esse E-mail já está cadastrado");

            // Gerar os Vos
                var name = new Name(command.FirstName, command.LastName);
                var document = new Document(command.Document,command.DocumentType);
                var email = new Email(command.Email);
                var address = new Addres(command.Street, command.NumberCasa, command.Neighborhood, command.City, command.State, command.Country, command.ZipCode);
                var student = new Student(name, document, email);
                var subscription = new Subscriptions(DateTime.UtcNow.AddMonths(1));

            // Geras as entidade
                var payment = new CreditCardPayment(
                    command.CardHolderName,
                    command.CardNumber,
                    command.LastTransactionNumber,
                    command.PaidDate, 
                    command.ExpireDate, 
                    command.Total, 
                    command.TotalPaid, 
                    command.NamePayer, 
                    document, 
                    address, 
                    email
                );

            // Relacionamentos
                subscription.AddPayment(payment);
                student.AddSubscription(subscription);
            
            // Agrupar as validações
                AddNotifications(name, document, email, address, student, subscription, payment);

            // salvar as informações
            _repository.CreateSubscription(student);

            // enviar email de boas vindas
            _emailService.Send(student.Name.ToString(), student.Email.Address, "Bem vindo ao balta.io", "Sua assinatura foi criada com sucesso!", "Balta.oi", "brunoneves_f@hotmail.com");

            // retorna as informações
            return new CommandResult(true, "Assinatura Realizada com sucesso");
        }
    }
}