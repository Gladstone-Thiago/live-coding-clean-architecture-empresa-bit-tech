
using api.core.product.domain;

namespace api.core.product.application;
public class ProductValidateStockUsecase
{

    public void Execute(ProductEntity product)
    {
        if (product.MinStock > product.MaxStock)
        {
            throw new ArgumentException("Min stock cannot be greater than max stock.", nameof(product.MinStock));
        }

                //// e outra regras de negócio
    }
}

