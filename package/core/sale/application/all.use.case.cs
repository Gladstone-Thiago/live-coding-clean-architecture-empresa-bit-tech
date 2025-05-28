using api.core.sale.infra;
using api.core.sale.domain;

namespace api.core.sale.application;

public class SaleAllUsecase
{
    private SaleDb _saleDb;

    public SaleAllUsecase()
    {
        _saleDb = new SaleDb();
    }

    public List<SaleEntity> Execute()
    {
        return _saleDb.All();
    }
}
