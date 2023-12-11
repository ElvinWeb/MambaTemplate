using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Core.Models
{
    public class Profession : BaseEntity
    {
        public string Name { get; set; }
        public List<Team>? Teams { get; set; }
    }
}
