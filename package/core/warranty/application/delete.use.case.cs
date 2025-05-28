
using api.core.warranty.infra;

namespace api.core.warranty.application;
public class WarrantyDeletelUsecase

{
    readonly WarrantyDb _warrantyDb;
    readonly WarrantyExistUsecase warrantyExistUsecase;

    public WarrantyDeletelUsecase()
    {
        _warrantyDb = new WarrantyDb();
        warrantyExistUsecase = new WarrantyExistUsecase();
    }

    public bool Execute(string id)
    {

        var productExisted = warrantyExistUsecase.Execute(id);
        var deleted = _warrantyDb.Delete(productExisted);
        if (!deleted)
            throw new Exception("Deleted product not found");
        return deleted;
    }
}

