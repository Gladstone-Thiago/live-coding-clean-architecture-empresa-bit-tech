using api.core.product.domain;
using api.core.product.infra;

namespace api.core.product.application;
public class ProductCreatelUsecase
{
    private ProductDb _ProductDb;
    readonly ProductExistUsecase productExistUsecase;
    readonly ProductValidateBalanceStockUsecase productValidateBalanceStockUsecase;
    readonly ProductValidateValueUsecase productValidateValueUsecase;
    readonly ProductValidateMinStockUsecase productValidateMinStockUsecase;
    readonly ProductValidateMaxStockUsecase productValidateMaxStockUsecase;
    readonly ProductValidateStockUsecase productValidateStockUsecase;


    public ProductCreatelUsecase()
    {
        _ProductDb = new ProductDb();
         productExistUsecase = new ProductExistUsecase();
        productValidateBalanceStockUsecase = new ProductValidateBalanceStockUsecase();
        productValidateValueUsecase = new ProductValidateValueUsecase();
        productValidateMinStockUsecase = new ProductValidateMinStockUsecase();
        productValidateMaxStockUsecase = new ProductValidateMaxStockUsecase();
        productValidateStockUsecase = new ProductValidateStockUsecase();
    }

    public ProductEntity Execute(ProductEntity product)
    {
         productValidateValueUsecase.Execute(product.Value);
        productValidateBalanceStockUsecase.Execute(product.StockBalance);
        productValidateMinStockUsecase.Execute(product.MinStock);
        productValidateMaxStockUsecase.Execute(product.MaxStock);
        productValidateStockUsecase.Execute(product);
  
        return _ProductDb.Add(product) ?? throw new Exception("Created product not found");
    }
}

