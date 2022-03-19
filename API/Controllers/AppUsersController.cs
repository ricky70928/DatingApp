using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AppUsersController : BaseApiController
    {
        private readonly DataContext context;
        public AppUsersController(DataContext context)
        {
            this.context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers() {
            return await this.context.AppUsers.ToListAsync();
        }

        // api/appusers/3
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetAppUser(int id) {
            return await this.context.AppUsers.FindAsync(id);
        }

    }
}