using api.core.warranty.infra;
using api.core.warranty.domain;

namespace api.core.warranty.application;

public class WarrantyAllUsecase
{
    private WarrantyDb _WarrantyDb;

    public WarrantyAllUsecase()
    {
        _WarrantyDb = new WarrantyDb();
    }

    public List<WarrantyEntity> Execute()
    {
        return _WarrantyDb.All();
    }
}

