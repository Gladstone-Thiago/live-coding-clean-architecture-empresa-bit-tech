
using api.core.sale.infra;

namespace api.core.sale.application;
public class SaleDeletelUsecase

{
    private SaleDb _saleDb;
    private SaleExistUsecase _saleExistUsecase;


    public SaleDeletelUsecase()
    {
        _saleDb = new SaleDb();
        _saleExistUsecase = new SaleExistUsecase();
    }

    public bool Execute(string id)
    {
        var productExisted = _saleExistUsecase.Execute(id);
        var deleted = _saleDb.Delete(productExisted);
        if (!deleted)
            throw new Exception("Deleted sale not found");
        return deleted;
    }
}

