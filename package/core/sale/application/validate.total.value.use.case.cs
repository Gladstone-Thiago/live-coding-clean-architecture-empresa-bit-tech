
using api.core.sale.domain;

namespace api.core.sale.application;

public class SaleValidateTotalValueUsecase
{

    public void Execute(ItemEntity item)
    {
        if (item.ValueTotal <= 0)
        {
            throw new ArgumentException("Total value must be greater than zero.", nameof(item.ValueTotal));
        }

        if (item.ValueTotal > 1000)
        {
            throw new ArgumentException("Total value exceeds the maximum limit of 1000.", nameof(item.ValueTotal));
        }

        if (item.ValueTotal <= item.ValueUnit) {
            throw new ArgumentException("The total value must be greater than the unit value.", nameof(item.ValueUnit));
        }

        //// e outra regras de negócio
    }
}

