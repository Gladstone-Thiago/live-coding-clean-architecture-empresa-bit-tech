using api.core.product.domain;
using api.core.product.infra;

namespace api.core.product.application;
public class ProductGetlUsecase
{
    private ProductDb _ProductDb;

    public ProductGetlUsecase()
    {
        _ProductDb = new ProductDb();
    }

    public ProductEntity Execute(string id)
    {
        var product = _ProductDb.Get(id);
        if (product == null)
        {
            throw new InvalidOperationException($"Product with id '{id}' not found.");
        }
        return product;
    }
}

