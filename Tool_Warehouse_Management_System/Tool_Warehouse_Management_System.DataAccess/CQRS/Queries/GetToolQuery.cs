using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace Tool_Warehouse_Management_System.DataAccess.CQRS.Queries
{
    public class GetToolQuery : QueryBase<Tool>
    {
        public int Id { get; set; }

        public override async Task<Tool> Execute(ToolWarehouseStorageContext context)
        {
            var tool = await context.Tools.FirstOrDefaultAsync(x => x.Id == this.Id);
            return tool;
        }
    }
}
