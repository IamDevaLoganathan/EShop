using MediatR;

namespace Catalogs.API.Products.CreateProduct
{
    // Endpoint trigger area
    public record CreateCompanyProductCommand(string Name, IList<string> Category, string Description, string ImageFile, decimal Price)
        : IRequest<CreateCompanyProductResult>;

    // Result
    public record CreateCompanyProductResult(Guid Id);

    // Here is our handler
    internal class CreateProductCommandHandler : IRequestHandler<CreateCompanyProductCommand, CreateCompanyProductResult>
    {
        public Task<CreateCompanyProductResult> Handle(CreateCompanyProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
