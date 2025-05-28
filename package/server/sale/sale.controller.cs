using api.core.sale.application;
using api.core.sale.domain;
using Microsoft.AspNetCore.Mvc;

namespace api.server.sale;

[Route("api/sale")]
[ApiController]
public class SaleController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<SaleEntity>> GetSales()
    {
        return Ok(new SaleAllUsecase().Execute());
    }

    [HttpGet("{id}")]
    public ActionResult<SaleEntity> GetSale([FromRoute] string id)
    {
        try
        {
            var result = new SaleGetUsecase().Execute(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        catch (Exception ex)
        {
           return BadRequest("Error: " + ex.Message); 
        }
    }

    [HttpPost]
    public ActionResult<SaleEntity> CreateProduct([FromBody] SaleEntity sale)
    {
        try
        {

        var created = new SaleCreatelUsecase().Execute(sale);
        return CreatedAtAction(nameof(GetSale), new { id = created.Id }, created);
        }
        catch (Exception ex)
        {
            return BadRequest("Error: " + ex.Message); 
        }
    }

    [HttpPut("{id}")]
    public ActionResult<SaleEntity> UpdateProduct([FromRoute] string id, [FromBody] SaleEntity sale)
    {
        try
        {
            var updated = new SaleUpdatelUsecase().Execute(id, sale);
            return Ok(updated);
        }
        catch (Exception ex)
        {
            return BadRequest("Error: " + ex.Message); 
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteWarranty([FromRoute] string id)
    {
        try
        {
            new SaleDeletelUsecase().Execute(id);
            return NoContent();
        }
        catch (Exception ex)
        {
          return BadRequest("Error: " + ex.Message); 
        }
    }
}
