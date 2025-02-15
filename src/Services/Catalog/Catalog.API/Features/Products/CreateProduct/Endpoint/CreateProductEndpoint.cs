using Catalog.API.Features.Products.CreateProduct.Command;
using Mapster;

namespace Catalog.API.Features.Products.CreateProduct.Endpoint
{
    public class CreateProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/products",
                async (CreateProductRequest request, ISender sender) =>
            {
                CreateProductCommand command = request.Adapt<CreateProductCommand>();
                CreateProductResult result = await sender.Send(command);
                CreateProductResponse response = result.Adapt<CreateProductResponse>();

                return Results.Created($"/products/{response.Id}",response);
            })
            .WithName("CreateProductName")
            .Produces<CreateProductResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Create Product Summary")
            .WithDescription("Create Product Description")
            ;
        }
    }
}
