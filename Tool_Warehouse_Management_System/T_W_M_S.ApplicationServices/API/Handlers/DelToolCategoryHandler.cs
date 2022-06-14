using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain;
using Tool_Warehouse_Management_System.DataAccess.CQRS;
using Tool_Warehouse_Management_System.DataAccess.CQRS.Commands;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace T_W_M_S.ApplicationServices.API.Handlers
{
    public class DelToolCategoryHandler : IRequestHandler<DelToolCategoryRequest, DelToolCategoryResponse>
    {

        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DelToolCategoryHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DelToolCategoryResponse> Handle(DelToolCategoryRequest request, CancellationToken cancellationToken)
        {
            var deletedToolCategory = this.mapper.Map<ToolCategory>(request);
            var command = new DelToolCategoryCommand() { Parameter = deletedToolCategory };
            var deletedToolCategoryFromDB = await this.commandExecutor.Execute(command);
            return new DelToolCategoryResponse()
            {
                Data = this.mapper.Map<Domain.Models.ToolCategory>(deletedToolCategoryFromDB)
            };

        }
    }
}
