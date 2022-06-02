using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Warehouse_Management_System.DataAccess.Entities
{
    public class Tool :EntityBase
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Category { get; set; }
        public int YearProduction { get; set; }
    }
}
