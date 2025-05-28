
namespace api.core.product.application;
public class ProductValidateValueUsecase
{

    public void Execute(decimal value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("Value must be greater than zero.", nameof(value));
        }

        if (value > 1000000)
        {
            throw new ArgumentException("Value exceeds the maximum limit of 1,000,000.", nameof(value));
        }

                //// e outra regras de negócio
    }
}

