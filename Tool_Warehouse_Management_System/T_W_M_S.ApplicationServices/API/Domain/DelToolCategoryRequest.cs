using MediatR;

namespace T_W_M_S.ApplicationServices.API.Domain
{
    public class DelToolCategoryRequest : IRequest<DelToolCategoryResponse>
    {
        public int Id { get; set; }
                
    }
}
