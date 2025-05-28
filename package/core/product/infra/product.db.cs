using api.core.product.domain;
using api.core.product.mock;

namespace api.core.product.infra;
public class ProductDb
{
    private readonly List<ProductEntity> _products;

    public ProductDb()
    {
        _products = new MockDb()._products;
    }

    public List<ProductEntity> All()
    {
        return _products.ToList();
    }

    public ProductEntity? Get(string id)
    {
        if (!Guid.TryParse(id, out var guidId))
        {
            return null;
        }
        return _products.FirstOrDefault(p => p.Id == guidId);
    }

    public bool Delete(ProductEntity product)
    {
        return _products.Remove(product);
    }

    public ProductEntity? Update(ProductEntity product)
    {
        _products.Remove(product);
        _products.Add(product);
        return product;
    }

    public ProductEntity Add(ProductEntity product)
    {
        _products.Add(product);
        return product; 
    }
}