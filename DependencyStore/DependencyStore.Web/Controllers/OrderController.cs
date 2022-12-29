using DependencyStore.Core.Orders.Create;
using Microsoft.AspNetCore.Mvc;

namespace DependencyStore.Web.Controllers
{
    public class OrderController : Controller
    {
        public async Task<IActionResult> Place(
        [FromBody] Request request,
        [FromServices] Handler handler)
        {
            try
            {
                var result = await handler.HandleAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
