
namespace api.core.product.domain;
public class ProductEntity(
    Guid id,
    string name,
    decimal value,
    int minStock,
    int maxStock,
    int stockBalance,
    string supplier,
    bool hasWarranty)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public decimal Value { get; set; } = value;
    public int MinStock { get; set; } = minStock;
    public int MaxStock { get; set; } = maxStock;
    public int StockBalance { get; set; } = stockBalance;
    public string Supplier { get; set; } = supplier;
    public bool HasWarranty { get; set; } = hasWarranty;
}