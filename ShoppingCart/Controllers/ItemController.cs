using Application.Commands.Item;
using Application.Queries.Item;
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
        public async Task<ActionResult<ItemResponse>> InsertItem([FromBody] ItemInsertCommand command) 
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        [Route("get-item-discount")]
        public async Task<ActionResult<double>> GetItemDiscount([FromHeader] int itemId)
        {
            return await Mediator.Send(new GetItemDiscountQuery { ItemId = itemId });
        }

    }
}
