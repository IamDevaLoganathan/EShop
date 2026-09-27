using MediatR;

namespace EShopCore.CQRS
{
    public interface ICommand : ICommand<Unit>
    {

    }
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {

    }
}
