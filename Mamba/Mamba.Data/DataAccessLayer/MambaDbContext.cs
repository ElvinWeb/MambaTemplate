using Mamba.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Data.DataAccessLayer
{
    public class MambaDbContext : IdentityDbContext
    {
        public MambaDbContext(DbContextOptions<MambaDbContext> options) : base(options) { }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
     
    }
}
