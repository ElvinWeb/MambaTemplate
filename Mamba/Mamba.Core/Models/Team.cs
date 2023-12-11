using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Core.Models
{
    public class Team : BaseEntity
    {
        public string FullName { get; set; }
        public int ProfessionId { get; set; }
        public Profession? Profession { get; set; }

        [StringLength(maximumLength: 100)]
        public string? ImgUrl { get; set; }
        public string RedirectUrl { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

    }
}
