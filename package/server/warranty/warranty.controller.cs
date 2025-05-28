using api.core.warranty.application;
using api.core.warranty.domain;
using Microsoft.AspNetCore.Mvc;

namespace api.server.warranty;

[Route("api/warranty")]
[ApiController]
public class WarrantyController : ControllerBase
{

    [HttpGet]
    public ActionResult<IEnumerable<WarrantyEntity>> GetWarrantys()
    {
        return Ok(new WarrantyAllUsecase().Execute());
    }

    [HttpGet("{id}")]
    public ActionResult<WarrantyEntity> GetWarranty([FromRoute] string id)
    {
        try
        {
            return Ok(new WarrantyGetlUsecase().Execute(id));
        }
        catch (Exception ex)
        {
           return BadRequest("Error: " + ex.Message); 
        }
    }

    [HttpPost]
    public ActionResult<WarrantyEntity> CreateWarranty([FromBody] WarrantyEntity warranty)
    {
        try
        {
            var result = new WarrantyCreatelUsecase().Execute(warranty);
            return CreatedAtAction(nameof(GetWarranty), new { id = result.Id }, result);
        }
        catch (Exception ex)
        {
            return BadRequest("Error: " + ex.Message); 
        }
    }

    [HttpPut("{id}")]
    public ActionResult<WarrantyEntity> UpdateWarranty([FromRoute] string id, [FromBody] WarrantyEntity warranty)
    {
        try
        {
            return Ok(new WarrantyUpdatelUsecase().Execute(id, warranty));
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
            new WarrantyDeletelUsecase().Execute(id);
            return NoContent();
        }
        catch (Exception ex)
        {
           return BadRequest("Error: " + ex.Message); 
        }
    }
}
