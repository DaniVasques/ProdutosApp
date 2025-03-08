using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProdutosApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        /// <summary>
        /// Serviços de cadsatro de produtos
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        /// <summary>
        /// Serviços para atualização de produtos na API.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        /// <summary>
        /// Serviços para exclusão de produtos na API.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        /// <summary>
        /// Serviços para consulta de produtos na API.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }


    }
}
