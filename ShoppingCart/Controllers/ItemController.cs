using Application.Commands.Item;
using Application.Responses.Item;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Controllers
{
    public class ItemController : ApiControllerBase
    {
        [HttpPost]
        [Route("insert-item")]
        public async Task<ActionResult<ItemResponse>> InsertItem([FromBody] ItemInsertCommand command, [FromHeader] string id) 
        {
            return await Mediator.Send(command);
        }

    }
}
