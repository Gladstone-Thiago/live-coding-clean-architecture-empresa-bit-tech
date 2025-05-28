
namespace api.core.sale.application;
public class SaleValidateQtdUsecase
{

    public void Execute(decimal value)
    {
        if (value <= 0){
        throw new ArgumentException("The quantity value must be greater than zero.", nameof(value));
        }

        if (value > 1000){
        throw new ArgumentException("The quantity value cannot exceed the maximum limit of 1000.", nameof(value));
        }

        //// e outra regras de negócio
    }
}

