using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain;
using Tool_Warehouse_Management_System.DataAccess;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace Tool_Warehouse_Management_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolsController : ControllerBase
    {

        private readonly IMediator mediator;
        public ToolsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllTools([FromQuery] GetToolsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("toolId")]
        public async Task<IActionResult> GetById([FromRoute] int toolId)
        {
            var request = new GetToolByIdRequest()
            {
                ToolId = toolId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
