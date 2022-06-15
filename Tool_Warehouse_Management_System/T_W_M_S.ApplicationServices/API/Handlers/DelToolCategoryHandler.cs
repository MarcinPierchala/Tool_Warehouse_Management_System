using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain;
using T_W_M_S.ApplicationServices.API.Domain.ErrorHandling;
using Tool_Warehouse_Management_System.DataAccess;
using Tool_Warehouse_Management_System.DataAccess.CQRS;
using Tool_Warehouse_Management_System.DataAccess.CQRS.Commands;
using Tool_Warehouse_Management_System.DataAccess.CQRS.Queries;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace T_W_M_S.ApplicationServices.API.Handlers
{
    public class DelToolCategoryHandler : IRequestHandler<DelToolCategoryRequest, DelToolCategoryResponse>
    {

        private readonly ICommandExecutor commandExecutor;
        private readonly IQueryExecutor queryExecutor;
        private readonly IMapper mapper;

        public DelToolCategoryHandler(ICommandExecutor commandExecutor, IQueryExecutor queryExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.queryExecutor = queryExecutor;
            this.mapper = mapper;
        }

        public async Task<DelToolCategoryResponse> Handle(DelToolCategoryRequest request, CancellationToken cancellationToken)
        {
            var query = new GetToolsCategoriesQuery()
            {
                Id = request.Id
            };

            //var categories = await this.queryExecutor.Execute(query);

            //if(categories == null)
            //{
            //    return new DelToolCategoryResponse();
            //    {
            //        Error = new ErrorModel(ErrorType.NotFound)
            //    };
            //}

            var deletedToolCategory = this.mapper.Map<ToolCategory>(request);
            var command = new DelToolCategoryCommand() { Parameter = deletedToolCategory };
            var deletedToolCategoryFromDB = await this.commandExecutor.Execute(command);
            return new DelToolCategoryResponse()
            {
                Data = this.mapper.Map<Domain.Models.ToolCategory>(deletedToolCategoryFromDB)
                //Data = deletedToolCategoryFromDB
            };

        }
    }
}
