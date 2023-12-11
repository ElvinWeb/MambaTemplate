using Mamba.Business.CustomExceptions.common;
using Mamba.Core.Models;
using Mamba.Core.Repositories.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.Services.Implementations
{
    public class ProfessionService : IProfessionService
    {
        private readonly IProfessionRepository _professionRepository;
        public ProfessionService(IProfessionRepository professionRepository)
        {
            _professionRepository = professionRepository;
        }
        public async Task CreateAsync(Profession entity)
        {
            if (_professionRepository.Table.Any(x => x.Name.ToLower() == entity.Name.ToLower()))
            {
                throw new InvalidAlreadyExists("Name", "Name has already created!");
            }

            await _professionRepository.CreateAsync(entity);
            await _professionRepository.CommitAsync();
        }

        public async Task Delete(int id)
        {
            Profession profession = await _professionRepository.GetByIdAsync(x => x.IsDeleted == false && x.Id == id);

            if (profession is null) throw new NullReferenceException();

            _professionRepository.Delete(profession);
            await _professionRepository.CommitAsync();

        }

        public async Task<List<Profession>> GetAllAsync()
        {
            return await _professionRepository.GetAllAsync(p => p.IsDeleted == false);
        }

        public async Task<Profession> GetByIdAsync(int id)
        {
            return await _professionRepository.GetByIdAsync(p => p.IsDeleted == false && p.Id == id);
        }

        public async Task UpdateAsync(Profession profession)
        {
            Profession existProfession = await _professionRepository.GetByIdAsync(x => x.Id == profession.Id && x.IsDeleted == false);

            if (_professionRepository.Table.Any(x => x.Name.ToLower() == profession.Name.ToLower() && existProfession.Id != profession.Id))
            {
                throw new InvalidAlreadyExists("Name", "Name has already created!");
            }

            existProfession.Name = profession.Name;

            await _professionRepository.CommitAsync();
        }
    }
}
