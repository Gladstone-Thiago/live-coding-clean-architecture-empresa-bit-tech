using api.core.warranty.domain;
using api.core.warranty.infra;

namespace api.core.warranty.application;
public class WarrantyGetlUsecase
{
    private WarrantyDb _warrantyDb;

    public WarrantyGetlUsecase()
    {
        _warrantyDb = new WarrantyDb();
    }

    public WarrantyEntity Execute(string id)
    {
        var warranty = _warrantyDb.Get(id);
        if (warranty == null)
        {
            throw new InvalidOperationException($"Warranty with id '{id}' not found.");
        }
        return warranty;
    }
}

