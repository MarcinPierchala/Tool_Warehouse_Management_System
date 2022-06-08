using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_W_M_S.ApplicationServices.API.Domain
{
    public class GetToolByIdRequest : IRequest<GetToolByIdResponse>
    {
        public int ToolId { get; set; }
    }
}
