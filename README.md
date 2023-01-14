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
      

    
   
  
