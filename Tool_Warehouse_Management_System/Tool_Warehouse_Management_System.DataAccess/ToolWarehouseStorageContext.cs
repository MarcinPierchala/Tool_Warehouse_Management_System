using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace Tool_Warehouse_Management_System.DataAccess
{
    public class ToolWarehouseStorageContext : DbContext
    {
        public ToolWarehouseStorageContext(DbContextOptions<ToolWarehouseStorageContext> opt) : base(opt)
        {

        }

        public DbSet<Tool> Tools { get; set; }

        public DbSet<ToolCategory> ToolCategories { get; set; }

    }
}
