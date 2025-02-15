namespace Catalog.API.Features.Products.CreateProduct.Endpoint
{
    public record CreateProductRequest(string Name, List<string> Category, string Description, string ImageFile, decimal Price);
}
