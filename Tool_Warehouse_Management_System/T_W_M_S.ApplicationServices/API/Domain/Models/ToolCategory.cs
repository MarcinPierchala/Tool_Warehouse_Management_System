using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace T_W_M_S.ApplicationServices.API.Domain.Models
{
    public class ToolCategory
    {
        public int Id { get; set; }

        public string Category { get; set; }

        //public List<Tool> Tools { get; set; }
    }
}
