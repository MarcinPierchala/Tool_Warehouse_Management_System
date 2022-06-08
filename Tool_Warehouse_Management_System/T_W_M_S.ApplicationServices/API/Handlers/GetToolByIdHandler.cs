using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain;
using Tool_Warehouse_Management_System.DataAccess;
using Tool_Warehouse_Management_System.DataAccess.CQRS.Queries;

namespace T_W_M_S.ApplicationServices.API.Handlers
{
    public class GetToolByIdHandler : IRequestHandler<GetToolByIdRequest, GetToolByIdResponse>
    {
        public readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetToolByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetToolByIdResponse> Handle(GetToolByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetToolQuery()
            {
                Id = request.ToolId
            };
            var tool = await this.queryExecutor.Execute(query);
            var mappedTool = this.mapper.Map<Domain.Models.Tool>(tool);
            var response = new GetToolByIdResponse()
            {
                Data = mappedTool
            };
            return response;
        }
    }
}
