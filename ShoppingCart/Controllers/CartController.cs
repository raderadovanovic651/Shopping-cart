using Application.Commands.Cart;
using Application.Queries.Cart;
using Application.Responses.Cart;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Controllers
{
    public class CartController : ApiControllerBase
    {
        [HttpPost]
        [Route("insert-cart-item")]
        public async Task<ActionResult<CartResponse>> InsertCartItem([FromBody] CartInsertCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        [Route("delete-cart-item")]
        public async Task<ActionResult<bool>> DeleteCartItem([FromBody] CartDeleteCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        [Route("get-cart-price-without-discont")]
        public async Task<ActionResult<double>> GetCartPrice()
        {
            return await Mediator.Send(new CartGetPriceQuery());
        }

        [HttpGet]
        [Route("get-cart-price-with-discont")]
        public async Task<ActionResult<double>> GetCartPriceWithDiscont()
        {
            return await Mediator.Send(new CartGetPriceWithDiscontQuery());
        }

        [HttpGet]
        [Route("order")]
        public async Task<ActionResult<CartOrderQueryResponse>> Order()
        {
            return await Mediator.Send(new CartOrderQuery());
        }
    }
}
