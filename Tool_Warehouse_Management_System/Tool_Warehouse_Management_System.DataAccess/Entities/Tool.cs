using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Warehouse_Management_System.DataAccess.Entities
{
    public class Tool
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int YearProduction { get; set; }
    }
}
