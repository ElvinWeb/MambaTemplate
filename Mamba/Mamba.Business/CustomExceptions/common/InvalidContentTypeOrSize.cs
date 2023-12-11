using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.CustomExceptions.common
{
    public class InvalidContentTypeOrSize : Exception
    {
        public string Property { get; set; }
        public InvalidContentTypeOrSize()
        {

        }

        public InvalidContentTypeOrSize(string? message) : base(message)
        {

        }
        public InvalidContentTypeOrSize(string propName, string? message) : base(message)
        {
            Property = propName;
        }
    }
}
