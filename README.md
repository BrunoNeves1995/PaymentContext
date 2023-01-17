# PaymentContext

  #### Entendendo os domínios
    
  - PaymentContext.Domain
    
      - É nosso modelo rico
      
  - PaymentContext.Shared
    
      - É quando estamos trabalhando com multiplos domínios
      
  - PaymentContext.Tests
    
      - É os tests que serão executados
      

  #### Codigo anti corrupção
  
     public class Student
    {   
       private readonly IList<Subscriptions> _subscriptions;
       public Student(string name, string document, string email)
      {
          Name = name;
          Document = document;
          Email = email;
          _subscriptions = new List<Subscriptions>();
     }

       // Aluno(Student) tem varias assinatura(Subscription)

        public string Name { get; private set; } = null!;
        public string Document { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string? Address { get; private set; }

        public IReadOnlyCollection<Subscriptions> Subscriptions { get {return _subscriptions.ToArray();}}

        public void AletarNome(string nome){
            Name = nome;
        }

        public void AddSubscription(Subscriptions subscription)
        {
            foreach (var sub in Subscriptions)
                sub.Activete();

            _subscriptions.Add(subscription);
        }
        
  ### Criando objeto complexo 
    
   - Exemplo de tipos primitivos
    
          public string Document { get; private set; } = null!;
          public string Email { get; private set; } = null!;
          public string? Address { get; private set; }
  
  - Criando ValueObject ou Objeto de Valores
    - São tipo que compoem uma entidade
    - Diferença entre um ValueObject e um Model -> model tera um Guid para identificação 
    
          public class Email  : ObjetoValor
          {
          public Email(string address)
          {
              Address = address;
          }

          public string Address { get; private set; } = null!;

          public void AlterarEmail(string address)
          {
              Address = address;
          }
      }
      

  ### Command
  
  - Command 
  - É a junção de todas as informações que a gente precisa para criar um subscription
  - São objeto de transporte, passage, de uma camada para a outra 
  - Todas as classe Devem implementar [Notifiable<Notification>, ICommand]
  
          public class CreateBoletoSubscriptionCommand  : Notifiable<Notification>, ICommand
          {   
              public string? FirstName { get; set; }
 
              public void Validate()
              {
                  AddNotifications(
                      new Contract<CreateBoletoSubscriptionCommand>()
                      .Requires()
                      .IsNotNullOrEmpty(FirstName, "FirstName", "Nome inválido")
                  );
              }
 
    - Exemplo completo de como implemtar Command e handler
      
            Payment.Shared
                   Pasta Command

                        passo 1 	ICommand  ->  Tem um metodo Validade boleano
                                           public interface ICommand 
                                           {
                                                void Validate();
                                           }

                        passo 2 	ICommandResult -> É apenas uma interface para tipação do retorno

                Pasta Handler

                      passo 3 	IHandler -> Tem um metodo que manipula apenas Classes que implementa : passo 1 e retorna passo 3
                                        public interface IHandler<T> where T : ICommand
                                        {   
                                            ICommandResult Handler(T command);
                                        }

          Payment.Domain
                 Pasta Command

                     Passo 4   CommandResult -> Tem 2 construtor um vazil e outro que recebe 2 parametro bool  success, string  message;
                                                     
                                 public CommandResult()
                                  {

                                  public CommandResult(bool success, string message)
                                  {
                                        Success = success;
                                        Message = message;
                                  }

                                       public bool Success { get; set; }
                                       public string? Message { get; set; }
                                      


                Pasta Handler

                      Passo 5	 SubscriptionHandler -> implementa Notifiable e IHandler que manipula as classe que recebe o json e retorna um ICommandResult
                      
                               public class SubscriptionHandler : Notifiable<Notification>, IHandler<CreateBoletoSubscriptionCommand>
                              {
                                  public ICommandResult Handler(CreateBoletoSubscriptionCommand command)
                                  {
                                      throw new NotImplementedException();
                                  }
                              }

  
   ### Repository Pattern
   
   - Repository Fake
   
          public interface IStudentReposository
          {
              bool DocumentExists(string document);
              bool EmailExists(string document);

              public void CreateSubscription(Student student);
          }
  
 ### Queries
  
       public static class StudentQueries
        {   
            // Exemplo de expression

            public static Expression<Func<Student, bool>> GetStudentInfo(string document)
            {
                return x => x.Document.Number == document;
            }
        }
