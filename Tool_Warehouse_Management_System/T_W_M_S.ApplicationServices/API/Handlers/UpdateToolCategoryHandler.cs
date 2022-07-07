using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain;
using T_W_M_S.ApplicationServices.API.Domain.Models;
using Tool_Warehouse_Management_System.DataAccess;
using Tool_Warehouse_Management_System.DataAccess.CQRS;
using Tool_Warehouse_Management_System.DataAccess.CQRS.Commands;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace T_W_M_S.ApplicationServices.API.Handlers
{
    public class UpdateToolCategoryHandler : IRequestHandler<UpdateToolCategoryRequest, UpdateToolCategoryResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;

        public UpdateToolCategoryHandler(ICommandExecutor commandExecutor, IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }

        public async Task<UpdateToolCategoryResponse> Handle(UpdateToolCategoryRequest request, CancellationToken cancellationToken)
        {
            var toolCategory = this.mapper.Map<Tool_Warehouse_Management_System.DataAccess.Entities.ToolCategory>(request);
            var command = new UpdateToolCategoryComand() { Parameter = toolCategory };
            var toolCategoryFromDB = await this.commandExecutor.Execute(command);
            return new UpdateToolCategoryResponse()
            {
                Data = this.mapper.Map<Domain.Models.ToolCategory>(toolCategoryFromDB)
            };
        }
    
    }
}
