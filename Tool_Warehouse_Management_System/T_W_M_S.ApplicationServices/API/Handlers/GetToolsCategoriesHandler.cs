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
using Tool_Warehouse_Management_System.DataAccess.CQRS.Queries;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace T_W_M_S.ApplicationServices.API.Handlers
{
    internal class GetToolsCategoriesHandler : IRequestHandler<GetToolsCategoriesRequest, GetToolsCategoriesResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetToolsCategoriesHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetToolsCategoriesResponse> Handle(GetToolsCategoriesRequest request, CancellationToken cancellationToken)
        {
            var query = new GetToolsCategoriesQuery();
            var toolsCategories = await this.queryExecutor.Execute(query);
            var mappedToolsCAtegories = this.mapper.Map<List<Domain.Models.ToolCategory>>(toolsCategories);
            var responce = new GetToolsCategoriesResponse()
            {
                Data = mappedToolsCAtegories
            };

            return responce;
        }
    }

}
