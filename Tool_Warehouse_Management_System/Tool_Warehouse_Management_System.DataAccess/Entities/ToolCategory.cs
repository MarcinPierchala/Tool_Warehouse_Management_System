using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Warehouse_Management_System.DataAccess.Entities
{
    public class ToolCategory : EntityBase
    {
        [Required]
        [MaxLength(100)]
        public string Category { get; set; }

        public List<Tool> Tools { get; set; }

        
    }
}
