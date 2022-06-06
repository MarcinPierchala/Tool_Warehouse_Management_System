using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain;
using T_W_M_S.ApplicationServices.API.Domain.Models;
using Tool_Warehouse_Management_System.DataAccess;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace T_W_M_S.ApplicationServices.API.Handlers
{
    public class GetToolsHandler : IRequestHandler<GetToolsRequest, GetToolsResponse>
    {
        private readonly IRepository<Tool_Warehouse_Management_System.DataAccess.Entities.Tool> toolRepository;

        public GetToolsHandler(IRepository<Tool_Warehouse_Management_System.DataAccess.Entities.Tool> toolRepository)
        {
            this.toolRepository = toolRepository;
        }

        public Task<GetToolsResponse> Handle(GetToolsRequest request, CancellationToken cancellationToken)
        {
            var tools = this.toolRepository.GetAll();
            var domainTools = tools.Select(x => new Domain.Models.Tool()
            {
                Id = x.Id,
                Name = x.Name
            });

            var responce = new GetToolsResponse()
            {
                Data = domainTools.ToList()
            };

            return Task.FromResult(responce);
        }
    }
}
