using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain.Models;

namespace T_W_M_S.ApplicationServices.Mappings
{
    public class ToolsProfile : Profile
    {
        public ToolsProfile()
        {
            this.CreateMap<Tool_Warehouse_Management_System.DataAccess.Entities.Tool, Tool>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
        }
    }
}
