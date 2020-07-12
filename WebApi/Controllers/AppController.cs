using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private IUnitOfWork repository;

        public AppController(IUnitOfWork unitOfWork) => this.repository = unitOfWork;

        [HttpGet]
        public IActionResult Index()
        {
            var result = new {
                Name = "Registro de Logs",
                Autor = "Antonio José",
                GitHub = "https://www.github.com/falecomoantonio"
            };

            return Ok(result);
        }

    }
}
