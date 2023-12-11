using Mamba.Core.Models;
using Mamba.Data.DataAccessLayer;
using Microsoft.AspNetCore.Identity;
using System;

namespace Mamba.UI.ViewService
{
    public class LayoutService
    {
        private readonly MambaDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LayoutService(MambaDbContext context, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

        }

        public async Task<User> GetUser()
        {

            User user = null;

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(_httpContextAccessor.HttpContext.User.Identity.Name);
            }

            return user;
        }
    }
}
