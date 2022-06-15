﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_W_M_S.ApplicationServices.API.Domain
{
    public class DelToolCategoryRequest : IRequest<DelToolCategoryResponse>
    {
        public int Id{ get; set; }
        public string Category { get; set; }
    }
}