using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain;
using Tool_Warehouse_Management_System.DataAccess.CQRS;
using Tool_Warehouse_Management_System.DataAccess.CQRS.Commands;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace T_W_M_S.ApplicationServices.API.Handlers
{
    public class AddToolCategoryHandler : IRequestHandler<AddToolCategoryRequest, AddToolCategoryResponse>
    {
        private readonly ICommandExecutor commandExeecutor;
        private readonly IMapper mapper;

        public AddToolCategoryHandler(ICommandExecutor commandExeecutor, IMapper mapper)
        {
            this.commandExeecutor = commandExeecutor;
            this.mapper = mapper;
        }

        public async Task<AddToolCategoryResponse> Handle(AddToolCategoryRequest request, CancellationToken cancellationToken)
        {
            var toolCategory = this.mapper.Map<ToolCategory>(request);
            var command = new AddToolCategoryComand() { Parameter = toolCategory };
            var toolCategoryFromDB = await this.commandExeecutor.Execute(command);
            return new AddToolCategoryResponse()
            {
                Data = this.mapper.Map<Domain.Models.ToolCategory>(toolCategoryFromDB)
            };
        }
    }
}
