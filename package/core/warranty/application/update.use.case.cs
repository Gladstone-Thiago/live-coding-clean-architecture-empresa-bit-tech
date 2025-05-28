using api.core.warranty.domain;
using api.core.warranty.infra;

namespace api.core.warranty.application;
public class WarrantyUpdatelUsecase
{
    private WarrantyDb _WarrantyDb;
    private WarrantyValidateValueUsecase _warrantyValidateValueUsecase;


    public WarrantyUpdatelUsecase()
    {
        _WarrantyDb = new WarrantyDb();
        _warrantyValidateValueUsecase = new WarrantyValidateValueUsecase();
    }

    public WarrantyEntity Execute(string id, WarrantyEntity warranty)
    {
        var warrantyExisted = _WarrantyDb.Get(id) ?? throw new ArgumentException($"Warranty with ID '{id}' does not exist.", nameof(id));
        _warrantyValidateValueUsecase.Execute(warranty.Value);
        
        warrantyExisted.Name = warranty.Name;
        warrantyExisted.Value = warranty.Value;
        warrantyExisted.Extended = warranty.Extended;

        return _WarrantyDb.Update(warranty) ?? throw new Exception("Changed warranty not found");
    }
    
}

