using api.core.warranty.domain;
using api.core.warranty.infra;

namespace api.core.warranty.application;
public class WarrantyExistUsecase
{
    private WarrantyDb _warrantyDb;

    public WarrantyExistUsecase()
    {
        _warrantyDb = new WarrantyDb();
    }

    public WarrantyEntity Execute(string id)
    {
        var exist = _warrantyDb.Get(id) ?? throw new ArgumentException($"Warranty with ID '{id}' does not exist.", nameof(id));
        return exist;
    }
}

