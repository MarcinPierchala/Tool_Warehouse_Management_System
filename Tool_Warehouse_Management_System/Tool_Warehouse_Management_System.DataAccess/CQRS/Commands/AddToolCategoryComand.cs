using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace Tool_Warehouse_Management_System.DataAccess.CQRS.Commands
{
    public class AddToolCategoryComand : CommandBase<Entities.ToolCategory, Entities.ToolCategory>
    {
        public override async Task<ToolCategory> Execute(ToolWarehouseStorageContext context)
        {
            await context.ToolCategories.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
