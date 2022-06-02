using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Warehouse_Management_System.DataAccess
{
    public class ToolWarehouseStorageContextFactory : IDesignTimeDbContextFactory<ToolWarehouseStorageContext>
    {
        private const string ConnectionString = "Data Source=DESKTOP-RRLI5LA\\TOOLWARDATABASE;Initial Catalog=ToolWarehouseStorage;Integrated Security=True";

        public ToolWarehouseStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ToolWarehouseStorageContext>();
            optionsBuilder.UseSqlServer(ConnectionString);
            return new ToolWarehouseStorageContext(optionsBuilder.Options);
        }
    }
}
