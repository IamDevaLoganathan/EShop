using MediatR;

namespace EShopCore.CQRS
{
    public interface IQuery<out TResposne> : IRequest<TResposne> where TResposne : notnull
    {
    }
}
