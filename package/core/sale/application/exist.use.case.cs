using api.core.sale.domain;
using api.core.sale.infra;

namespace api.core.sale.application;

public class SaleExistUsecase
{
    private SaleDb _saleDb;

    public SaleExistUsecase()
    {
        _saleDb = new SaleDb();
    }

    public SaleEntity Execute(string id)
    {
        var exist = _saleDb.Get(id) ?? throw new ArgumentException($"Sale with ID '{id}' does not exist.", nameof(id));
        return exist;
    }
}

