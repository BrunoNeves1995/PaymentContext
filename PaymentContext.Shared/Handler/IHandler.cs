using PaymentContext.Shared.Commands;

namespace PaymentContext.Shared.Handler
{
    public interface IHandler<T> where T : ICommand
    {   
        // só vai manipular command
        ICommandResult Handler(T command);
    }
}