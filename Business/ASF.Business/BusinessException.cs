using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessException.Framework.Exceptions;

namespace BusinessException.Business
{
    public class BusinessException : ApiException
    {
        public BusinessException(string message) : base(message,"B")
        {
        }
    }
}
