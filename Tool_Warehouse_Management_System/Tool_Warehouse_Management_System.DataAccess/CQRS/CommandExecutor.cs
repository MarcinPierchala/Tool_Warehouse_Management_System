using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.CQRS.Commands;

namespace Tool_Warehouse_Management_System.DataAccess.CQRS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly ToolWarehouseStorageContext context;

        public CommandExecutor(ToolWarehouseStorageContext context)
        {
            this.context = context;
        }

        public Task<TResult> Execute<TParameters, TResult>(CommandBase<TParameters, TResult> command)
        {
            return command.Execute(this.context);
        }
    }
}
