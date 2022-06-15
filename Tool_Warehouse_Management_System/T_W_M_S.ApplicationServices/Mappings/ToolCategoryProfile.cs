using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_W_M_S.ApplicationServices.API.Domain;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace T_W_M_S.ApplicationServices.Mappings
{
    public class ToolCategoryProfile : Profile
    {
        public ToolCategoryProfile()
        {
            this.CreateMap<AddToolCategoryRequest, Tool_Warehouse_Management_System.DataAccess.Entities.ToolCategory>()
                .ForMember(x => x.Category, y => y.MapFrom(z => z.Category));

            this.CreateMap<ToolCategory, API.Domain.Models.ToolCategory>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Category, y => y.MapFrom(z => z.Category));

            this.CreateMap< DelToolCategoryRequest, Tool_Warehouse_Management_System.DataAccess.Entities.ToolCategory>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Category, y => y.MapFrom(z => z.Category));
        }
    }
}
