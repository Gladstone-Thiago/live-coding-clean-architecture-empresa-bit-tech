using api.core.sale.domain;
using api.core.sale.infra;

namespace api.core.sale.application;
public class SaleUpdatelUsecase
{
    private SaleDb _saleDb;
    readonly SaleExistUsecase saleExistUsecase;
    readonly SaleValidateQtdUsecase saleValidateQtdUsecase = new SaleValidateQtdUsecase();
    readonly SaleValidateUnitValueUsecase saleValidateUnitValueUsecase = new SaleValidateUnitValueUsecase();
    readonly SaleValidateTotalValueUsecase saleValidateTotalValueUsecase = new SaleValidateTotalValueUsecase();


    public SaleUpdatelUsecase()
    {
        _saleDb = new SaleDb();
        saleExistUsecase = new SaleExistUsecase();
        saleValidateQtdUsecase = new SaleValidateQtdUsecase();
        saleValidateUnitValueUsecase = new SaleValidateUnitValueUsecase();
        saleValidateTotalValueUsecase = new SaleValidateTotalValueUsecase();
    }

    public SaleEntity Execute(string id ,SaleEntity sale)
    {

        saleValidateQtdUsecase.Execute(sale.Items.Count);

        foreach (var item in sale.Items)
        {
            saleValidateQtdUsecase.Execute(item.Qtd);
            saleValidateUnitValueUsecase.Execute(item);
            saleValidateTotalValueUsecase.Execute(item);
        }
   
        var saleExisted = saleExistUsecase.Execute(id);

        saleExisted.Items = sale.Items;
        saleExisted.ValueTotal = sale.ValueTotal;
        
        return _saleDb.Update(saleExisted) ?? throw new Exception("Changed sale not found");
    }
}

