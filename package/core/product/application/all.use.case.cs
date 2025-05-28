using api.core.product.infra;
using api.core.product.domain;

namespace api.core.product.application;

public class ProductAllUsecase
{
    private ProductDb _ProductDb;

    public ProductAllUsecase()
    {
        _ProductDb = new ProductDb();
    }

    public List<ProductEntity> Execute()
    {
        return _ProductDb.All();
    }
}

