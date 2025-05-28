using api.core.sale.domain;
using api.core.sale.infra;

namespace api.core.sale.application;
public class SaleCreatelUsecase
{
    private SaleDb _saleDb;
    readonly SaleExistUsecase saleExistUsecase;
    readonly SaleValidateQtdUsecase saleValidateQtdUsecase = new SaleValidateQtdUsecase();
    readonly SaleValidateUnitValueUsecase saleValidateUnitValueUsecase = new SaleValidateUnitValueUsecase();
    readonly SaleValidateTotalValueUsecase saleValidateTotalValueUsecase = new SaleValidateTotalValueUsecase();


    public SaleCreatelUsecase()
    {
       _saleDb = new SaleDb();
        saleExistUsecase = new SaleExistUsecase();
        saleValidateQtdUsecase = new SaleValidateQtdUsecase();
        saleValidateUnitValueUsecase = new SaleValidateUnitValueUsecase();
        saleValidateTotalValueUsecase = new SaleValidateTotalValueUsecase();
    }

    public SaleEntity Execute(SaleEntity sale)
    {
        saleValidateQtdUsecase.Execute(sale.Items.Count);

        foreach (var item in sale.Items)
        {
            saleValidateQtdUsecase.Execute(item.Qtd);
            saleValidateUnitValueUsecase.Execute(item);
            saleValidateTotalValueUsecase.Execute(item);
        }

        return _saleDb.Add(sale) ?? throw new Exception("Created sale not found");
    }
}

