using api.core.product.domain;

namespace api.core.product.mock;
public class MockDb
{
    public readonly List<ProductEntity> _products;

    public MockDb()
    {
        _products = new List<ProductEntity>
        {
            new(Guid.Parse("11111111-1111-1111-1111-111111111111"), "Product 1", 100, 10, 5, 2, "Magazine 1", true),
            new(Guid.Parse("22222222-2222-2222-2222-222222222222"), "Product 2", 200, 20, 10, 4, "Magazine 2", true),
            new(Guid.Parse("33333333-3333-3333-3333-333333333333"), "Product 3", 300, 30, 15, 6, "Magazine 3", true)
        };
    }

}