using api.core.product.domain;
using api.core.product.infra;

namespace api.core.product.application;

public class ProductExistUsecase
{
    private ProductDb _ProductDb;

    public ProductExistUsecase()
    {
        _ProductDb = new ProductDb();
    }

    public ProductEntity Execute(string id)
    {
        var exist = _ProductDb.Get(id) ?? throw new ArgumentException($"Product with ID '{id}' does not exist.", nameof(id));
        return exist;
    }
}

