using api.core.warranty.domain;
using api.core.sale.mock.warranty;

namespace api.core.warranty.infra;
public class WarrantyDb
{
    private readonly List<WarrantyEntity> _products;

    public WarrantyDb()
    {
        _products = new MockDb()._warranty;
    }

    public List<WarrantyEntity> All()
    {
        return _products.ToList();
    }

    public WarrantyEntity? Get(string id)
    {
        if (!Guid.TryParse(id, out Guid guidId))
        {
            return null;
        }
        return _products.FirstOrDefault(p => p.Id == guidId);
    }

    public bool Delete(WarrantyEntity warranty)
    {
        return _products.Remove(warranty);
    }

    public WarrantyEntity? Update(WarrantyEntity warranty)
    {
        _products.Remove(warranty);
        _products.Add(warranty);
        return warranty;
    }

    public WarrantyEntity Add(WarrantyEntity warranty)
    {
        _products.Add(warranty);
        return warranty;
    }
}