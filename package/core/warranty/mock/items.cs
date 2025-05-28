using api.core.warranty.domain;

namespace api.core.sale.mock.warranty;

public class MockDb
{
    public readonly List<WarrantyEntity> _warranty;

    public MockDb()
    {
        _warranty = new List<WarrantyEntity>
        {
            new(Guid.Parse("368e9c0a-dedd-4e72-a558-0f6020296457"), "Warranty 1", 100, 10),
            new(Guid.Parse("368e9c0a-dedd-4e72-a558-0f6020296458"), "Warranty 2", 200, 20),
            new(Guid.Parse("368e9c0a-dedd-4e72-a558-0f6020296459"), "Warranty 3", 300, 30)
        };
    }

}