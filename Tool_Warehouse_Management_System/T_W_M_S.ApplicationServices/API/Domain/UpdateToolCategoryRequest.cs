using MediatR;

namespace T_W_M_S.ApplicationServices.API.Domain
{
    public class UpdateToolCategoryRequest : IRequest<UpdateToolCategoryResponse>
    {
        public int Id { get; set; } 

        public string Category { get; set; }
    }
}
