
using api.core.warranty.domain;

namespace api.core.sale.domain;

public class ItemEntity
{
    public Guid ProductId { get; set; }
    public int Qtd { get; set; }
    public decimal ValueUnit { get; set; }
    public decimal ValueTotal { get; set; }
    public WarrantyEntity? Warranty { get; set; }
}

public class SaleEntity
{
    public Guid Id { get; set; }
    public List<ItemEntity> Items { get; set; } = new List<ItemEntity>();
    public decimal ValueTotal { get; set; }

    public SaleEntity(Guid id, List<ItemEntity> items, decimal valueTotal)
    {
        Id = id;
        Items = items;
        ValueTotal = valueTotal;
    }

}