using api.core.product.application;
using api.core.product.domain;
using Microsoft.AspNetCore.Mvc;

namespace api.server.product;

[Route("api/product")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<ProductEntity>> GetProducts()
    {
        return Ok(new ProductAllUsecase().Execute());
    }

    [HttpGet("{id}")]
    public ActionResult<ProductEntity> GetProduct([FromRoute] string id)
    {
        try
        {
            var result = new ProductGetlUsecase().Execute(id);
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
    public ActionResult<ProductEntity> CreateProduct([FromBody] ProductEntity product)
    {
        try
        {
            var created = new ProductCreatelUsecase().Execute(product);
            return CreatedAtAction(nameof(GetProduct), new { id = created.Id }, created);
        }
        catch (Exception ex)
        {
            return BadRequest("Error: " + ex.Message); 
        }
    }

    [HttpPut("{id}")]
    public ActionResult<ProductEntity> UpdateProduct([FromRoute] string id, [FromBody] ProductEntity product)
    {
        try
        {
            var updated = new ProductUpdatelUsecase().Execute(id, product);
            return Ok(updated);
        }
        catch (Exception ex)
        {
            return BadRequest("Error: " + ex.Message); 
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct([FromRoute] string id)
    {
        try
        {
            new ProductDeletelUsecase().Execute(id);
            return NoContent();
        }
        catch (Exception ex)
        {
           return BadRequest("Error: " + ex.Message); 
        }
    }

}
