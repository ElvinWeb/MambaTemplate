using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.CustomExceptions.common
{

    public class InvalidAlreadyExists : Exception
    {
        public string Property { get; set; }
        public InvalidAlreadyExists()
        {

        }

        public InvalidAlreadyExists(string? message) : base(message)
        {

        }
        public InvalidAlreadyExists(string propName, string? message) : base(message)
        {
            Property = propName;
        }
    }
}
