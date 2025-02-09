using BuildingBlocks.Abstractions.CQRS;

namespace Catalog.API.Features.Products.CreateProduct.Command
{
    public record CreateProductCommand(string Name,List<string>Category,string Description, string ImageFile, decimal Price)
        : ICommand<CreateProductResult>;
}
