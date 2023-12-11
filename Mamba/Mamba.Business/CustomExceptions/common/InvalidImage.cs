using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.CustomExceptions.common
{
    public class InvalidImage : Exception
    {
        public string Property { get; set; }
        public InvalidImage()
        {

        }

        public InvalidImage(string? message) : base(message)
        {

        }
        public InvalidImage(string propName, string? message) : base(message)
        {
            Property = propName;
        }
    }
}
