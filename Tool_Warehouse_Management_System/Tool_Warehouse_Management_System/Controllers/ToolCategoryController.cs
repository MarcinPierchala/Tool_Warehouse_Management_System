using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain;

namespace Tool_Warehouse_Management_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolCategoryController : ControllerBase
    {
        private readonly IMediator mediator;

        public ToolCategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [Route("")]

        public async Task<IActionResult> AddToolCategory([FromBody] AddToolCategoryRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]

        public async Task<IActionResult> DelToolCategory([FromRoute] int id)
        {
            var request = new DelToolCategoryRequest()
                {
                    Id = id
                };
            return this.Ok(request);
        }

    }
}
