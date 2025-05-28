using api.core.sale.domain;
using api.core.sale.mock;

namespace api.core.sale.infra;
public class SaleDb
{
    private readonly List<SaleEntity> _sale;

    public SaleDb()
    {
        _sale = new MockDb()._sale;
    }

    public List<SaleEntity> All()
    {
        return _sale.ToList();
    }

    public SaleEntity? Get(string id)
    {
        if (Guid.TryParse(id, out Guid guidId))
        {
            return _sale.FirstOrDefault(p => p.Id == guidId);
        }
        return null;
    }

    public bool Delete(SaleEntity sale)
    {
        return _sale.Remove(sale);
    }

    public SaleEntity? Update(SaleEntity sale)
    {
        _sale.Remove(sale);
        _sale.Add(sale);
        return sale;
    }

    public SaleEntity Add(SaleEntity sale)
    {
        _sale.Add(sale);
        return sale; 
    }
}