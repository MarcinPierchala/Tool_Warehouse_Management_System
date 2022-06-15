using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_W_M_S.ApplicationServices.API.Domain.ErrorHandling
{
    public class ErrorModel
    {
        public ErrorModel(string error)
        {
            this.Error = error;
        }

        public string Error { get; }
    }
}
