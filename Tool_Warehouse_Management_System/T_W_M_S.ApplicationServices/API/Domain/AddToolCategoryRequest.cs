using MediatR;

namespace T_W_M_S.ApplicationServices.API.Domain
{
    public class AddToolCategoryRequest : IRequest<AddToolCategoryResponse>
    {
        public string Category { get; set; }

    }
}
