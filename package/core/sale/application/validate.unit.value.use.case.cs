
using api.core.sale.domain;

namespace api.core.sale.application;

public class SaleValidateUnitValueUsecase
{

    public void Execute(ItemEntity item)
    {

        if (item.ValueUnit <= 0)
        {
            throw new ArgumentException("The unit value must be greater than zero.", nameof(item.ValueUnit));
        }

        if (item.ValueUnit > 1000)
        {
            throw new ArgumentException("The unit value cannot exceed the maximum limit of 1000.", nameof(item.ValueUnit));
        }

        if (item.ValueUnit <= item.ValueTotal)
        {
            throw new ArgumentException("The unit value must be greater than the total value.", nameof(item.ValueUnit));
        }
     

        //// e outra regras de negócio
    }
}

