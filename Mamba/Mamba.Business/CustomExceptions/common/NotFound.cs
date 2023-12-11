using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.CustomExceptions.common
{
    public class NotFound : Exception
    {

        public string Property { get; set; }
        public NotFound()
        {

        }

        public NotFound(string? message) : base(message)
        {

        }
        public NotFound(string propName, string? message) : base(message)
        {
            Property = propName;
        }
    }
}
