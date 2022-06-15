using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace Tool_Warehouse_Management_System.DataAccess.CQRS.Queries
{
    public class GetToolsCategoriesQuery : QueryBase<List<ToolCategory>>
    {
        public int Id { get; set; }
        
        public override Task<List<ToolCategory>> Execute(ToolWarehouseStorageContext context)
        {
            return context.ToolCategories.ToListAsync();
        }
    }
}
