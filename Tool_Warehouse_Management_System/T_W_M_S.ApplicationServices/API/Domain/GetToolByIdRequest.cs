using MediatR;

namespace T_W_M_S.ApplicationServices.API.Domain
{
    public class GetToolByIdRequest : IRequest<GetToolByIdResponse>
    {
        public int Id { get; set; }
    }
}
