using ApiLogin.Models;
using ApiLogin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiLogin.ViewModels;

namespace ApiLogin.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet("v1/login/{user:string}")]
        public async Task<IActionResult> GetAsync(
            [FromRoute] string user,
            [FromBody] string password,
            [FromServices] ApiLoginDataContext context)
        {
            try
            {
                var logins = await context.Logins.FirstOrDefaultAsync(x => x.User == user);
                if (logins == null)
                    return NotFound("User not found");

                if (logins.Password == password)
                    return Ok(true);
                else
                    return Ok(false);
            }
            catch
            {
                return StatusCode(500, "05X10 - Internal server failure");
            }
        }


        [HttpPost("v1/login/{id:int}")]
        public async Task<IActionResult> PostAsync(
                    [FromRoute] int id,
                    [FromBody] CreateLoginViewModel login ,
                    [FromServices] ApiLoginDataContext context)
        {
            try
            {
                var newLogin = new Login
                {
                    Id = 0,
                    User = login.User,
                    Password = login.Password,
                };
                await context.Logins.AddAsync(newLogin);
                await context.SaveChangesAsync();

                return Created($"v1/categories/{newLogin.Id}", new ResultViewModel<Login>(newLogin));
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, new ResultViewModel<Login>("05XE9 - Could not include"));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<Login>("05X10 - Internal server failure"));
            }
        }
    }

  
}
