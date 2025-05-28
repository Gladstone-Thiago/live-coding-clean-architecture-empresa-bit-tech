using api.core.sale.domain;

namespace api.core.sale.mock;
public class MockDb
{
    public readonly List<ItemEntity> _item;
    public readonly List<SaleEntity> _sale;


    public MockDb()
    {
        var warrantyDb = new api.core.sale.mock.warranty.MockDb();

        _item = new List<ItemEntity>
        {
            new ItemEntity
            {
            ProductId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
            Qtd = 2,
            ValueUnit = 100,
            ValueTotal = 200,
            Warranty = warrantyDb._warranty.FirstOrDefault(w => w.Id == Guid.Parse("368e9c0a-dedd-4e72-a558-0f6020296457"))
            },
            new ItemEntity
            {
            ProductId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
            Qtd = 1,
            ValueUnit = 200,
            ValueTotal = 200,
            Warranty = warrantyDb._warranty.FirstOrDefault(w => w.Id == Guid.Parse("368e9c0a-dedd-4e72-a558-0f6020296458"))
            },
            new ItemEntity
            {
            ProductId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
            Qtd = 3,
            ValueUnit = 150,
            ValueTotal = 450,
            Warranty = warrantyDb._warranty.FirstOrDefault(w => w.Id == Guid.Parse("368e9c0a-dedd-4e72-a558-0f6020296459"))
            }
        };
        _sale = new List<SaleEntity>
        {
            new(Guid.Parse("11111111-1111-1111-1111-111111111111"), _item, 850),
            new(Guid.Parse("22222222-2222-2222-2222-222222222222"), _item, 850),
            new(Guid.Parse("33333333-3333-3333-3333-333333333333"), _item, 850)
        };
    }
}