using api.core.warranty.infra;

namespace api.core.warranty.application;
public class WarrantyValidateValueUsecase
{

    public void Execute(decimal value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("Warranty value must be greater than zero.", nameof(value));
        }

        if (value > 1000000)
        {
            throw new ArgumentException("Warranty value exceeds the maximum limit of 1,000,000.", nameof(value));
        }
    }
}

