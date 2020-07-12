using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUnitOfWork repository;

        public UserController(IUnitOfWork unitOfWork) => repository = unitOfWork;

        [HttpPost(Name = "/")]
        public IActionResult Register([FromBody] UserRegisterModel model)
        {
            try
            {
                var result = this.repository.User.Register(model.Name, model.Email, model.Username, model.Password);
                if(result is null)
                {
                    throw new Exception($"Não foi possível registrar o Usuário {model.Name}.");
                }

                UserModel user = new UserModel
                {
                    Id = result.Id,
                    Email = result.Email,
                    Name = result.Name,
                    Username = result.Username,
                    CreatedAt = result.CreatedAt?.ToString("dd/MM/yyyy HH:mm:ss"),
                    UpdatedAt = result.UpdatedAt?.ToString("dd/MM/yyyy HH:mm:ss")
                };

                return Ok(user);
            }
            catch(Exception e) 
            {
                return BadRequest(new { 
                    Result = "Falha na Operação",
                    Message = e.Message,
                    Stacktrace = e.StackTrace
                });
            }
        }
    }
}
