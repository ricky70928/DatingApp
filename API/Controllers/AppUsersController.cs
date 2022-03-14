using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUsersController : ControllerBase
    {
        private readonly DataContext context;
        public AppUsersController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers() {
            return await this.context.AppUsers.ToListAsync();
        }

        // api/appusers/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetAppUser(int id) {
            return await this.context.AppUsers.FindAsync(id);
        }

    }
}