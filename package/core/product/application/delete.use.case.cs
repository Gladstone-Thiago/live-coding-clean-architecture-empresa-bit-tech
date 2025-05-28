
using api.core.product.infra;

namespace api.core.product.application;
public class ProductDeletelUsecase

{
    readonly ProductDb productDb;
    readonly ProductExistUsecase productExistUsecase;

    public ProductDeletelUsecase()
    {
        productDb = new ProductDb();
        productExistUsecase = new ProductExistUsecase();
    }

    public bool Execute(string id)
    {
        var productExisted = productExistUsecase.Execute(id);
        var deleted = productDb.Delete(productExisted);
        if (!deleted)
            throw new Exception("Deleted product not found");
        return deleted;
    }
}

