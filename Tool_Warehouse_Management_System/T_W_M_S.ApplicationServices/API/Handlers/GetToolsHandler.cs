using AutoMapper;
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
        private readonly IMapper mapper;

        public GetToolsHandler(IRepository<Tool_Warehouse_Management_System.DataAccess.Entities.Tool> toolRepository, IMapper mapper)
        {
            this.toolRepository = toolRepository;
            this.mapper = mapper;
        }

        public Task<GetToolsResponse> Handle(GetToolsRequest request, CancellationToken cancellationToken)
        {
            var tools = this.toolRepository.GetAll();
            var mappedTools = this.mapper.Map<List<Domain.Models.Tool>>(tools);
            var responce = new GetToolsResponse()
            {
                Data = mappedTools
            };

            return Task.FromResult(responce);
        }
    }
}
