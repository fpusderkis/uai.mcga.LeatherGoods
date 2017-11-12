using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessException.Framework.Exceptions
{
    public class ApiException : Exception
    {

        public String Code { get; set; }

        public ApiException(String _message, String code) : base(_message)
        {
            Code = code;
        }

    }
}
