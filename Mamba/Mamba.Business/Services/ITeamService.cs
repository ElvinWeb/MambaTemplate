using Mamba.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.Services
{
    public interface ITeamService
    {

        Task CreateAsync(Team entity);
        Task SoftDelete(int id);
        Task Delete(int id);
        Task<Team> GetByIdAsync(int id);
        Task<List<Team>> GetAllAsync();
        Task UpdateAsync(Team entity);
    }

}
