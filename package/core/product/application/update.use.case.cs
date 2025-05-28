using api.core.product.domain;
using api.core.product.infra;

namespace api.core.product.application;
public class ProductUpdatelUsecase
{
    private ProductDb _ProductDb;
    readonly ProductExistUsecase productExistUsecase;
    readonly ProductValidateBalanceStockUsecase productValidateBalanceStockUsecase;
    readonly ProductValidateValueUsecase productValidateValueUsecase;
    readonly ProductValidateMinStockUsecase productValidateMinStockUsecase;
    readonly ProductValidateMaxStockUsecase productValidateMaxStockUsecase;
    readonly ProductValidateStockUsecase productValidateStockUsecase;

    public ProductUpdatelUsecase()
    {
        _ProductDb = new ProductDb();
        productExistUsecase = new ProductExistUsecase();
        productValidateBalanceStockUsecase = new ProductValidateBalanceStockUsecase();
        productValidateValueUsecase = new ProductValidateValueUsecase();
        productValidateMinStockUsecase = new ProductValidateMinStockUsecase();
        productValidateMaxStockUsecase = new ProductValidateMaxStockUsecase();
        productValidateStockUsecase = new ProductValidateStockUsecase();
    }

    public ProductEntity Execute(string id ,ProductEntity product)
    {
        productValidateValueUsecase.Execute(product.Value);
        productValidateBalanceStockUsecase.Execute(product.StockBalance);
        productValidateMinStockUsecase.Execute(product.MinStock);
        productValidateMaxStockUsecase.Execute(product.MaxStock);
        productValidateStockUsecase.Execute(product);
      
        var productExisted = productExistUsecase.Execute(id);

        productExisted.Name = product.Name;
        productExisted.Value = product.Value;
        productExisted.MinStock = product.MinStock;
        productExisted.MaxStock = product.MaxStock;
        productExisted.StockBalance = product.StockBalance;
        productExisted.Supplier = product.Supplier;
        productExisted.HasWarranty = product.HasWarranty;
        
        return _ProductDb.Update(product) ?? throw new Exception("Changed product not found");
    }
}

