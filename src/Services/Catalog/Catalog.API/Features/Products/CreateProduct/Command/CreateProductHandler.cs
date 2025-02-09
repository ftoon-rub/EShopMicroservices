using BuildingBlocks.Abstractions.CQRS;

namespace Catalog.API.Features.Products.CreateProduct.Command
{
    public class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        /// <summary>
        /// Create product entity from command object.
        /// Save to Database.
        /// return result.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new(name:request.Name,category:request.Category,description: request.Description,imageFile: request.ImageFile,price: request.Price);

            return new CreateProductResult(product.Id);
        }
    }
}
