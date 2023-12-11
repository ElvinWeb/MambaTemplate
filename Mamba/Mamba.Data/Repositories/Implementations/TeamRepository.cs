using Mamba.Core.Models;
using Mamba.Core.Repositories.Services;
using Mamba.Data.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Data.Repositories.Implementations
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(MambaDbContext context) : base(context)
        {
        }
    }
}
