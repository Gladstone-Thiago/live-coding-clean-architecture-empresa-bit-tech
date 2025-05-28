using api.core.sale.infra;
using api.core.sale.domain;

namespace api.core.sale.application;

public class SaleGetUsecase
{
    private SaleDb _saleDb;

    public SaleGetUsecase()
    {
        _saleDb = new SaleDb();
    }
    public SaleEntity Execute(string id)
    {

        var sale = _saleDb.Get(id);
        if (sale == null)
        {
            throw new InvalidOperationException($"Sale with id '{id}' not found.");
        }
        return sale;
    }
}

