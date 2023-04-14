using Chapter.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivrosRepository _livrosRepository;
        
        public LivrosController(LivrosRepository livrosRepository)
        {
            _livrosRepository = livrosRepository;
        }

        [HttpGet]
        public IActionResult Listar () 
        {
            try
            {
                return Ok(_livrosRepository.Listar);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        
        }

    }
}
