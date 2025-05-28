
namespace api.core.warranty.domain;
public class WarrantyEntity(
    Guid id,
    string name,
    decimal value,
    int extended)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public decimal Value { get; set; } = value;
    public int Extended { get; set; } = extended;
}