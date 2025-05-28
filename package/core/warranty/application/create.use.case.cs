using api.core.warranty.domain;
using api.core.warranty.infra;

namespace api.core.warranty.application;
public class WarrantyCreatelUsecase
{
    private WarrantyDb _warrantyDb;
    private WarrantyValidateValueUsecase _warrantyValidateValueUsecase;

    public WarrantyCreatelUsecase()
    {
        _warrantyDb = new WarrantyDb();
        _warrantyValidateValueUsecase = new WarrantyValidateValueUsecase();
    }

    public WarrantyEntity Execute(WarrantyEntity warranty)
    {
        _warrantyValidateValueUsecase.Execute(warranty.Value);
        return _warrantyDb.Add(warranty) ?? throw new Exception("Created warranty not found");
    }
}

