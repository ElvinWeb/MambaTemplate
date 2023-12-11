using Mamba.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.Services
{
    public interface IProfessionService
    {
        Task CreateAsync(Profession entity);
        Task Delete(int id);
        Task<Profession> GetByIdAsync(int id);
        Task<List<Profession>> GetAllAsync();
        Task UpdateAsync(Profession entity);
    }
}
