using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutosApp.Repositories;

namespace ProdutosApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        [HttpGet("Categoria-qtoproduto")]
        public IActionResult GetQtdProdutos()
        {
            var categoriaRepository = new CategoriaRepository();
            var response = categoriaRepository.GroupByQtdProdutos();

            return Ok(response);
        }

        [HttpGet("Categoria-mediapreco")]
        public IActionResult GetMediaPreco()
        {
            var categoriaRepository = new CategoriaRepository();
            var response = categoriaRepository.GroupByMediaPreco();
            return Ok(response);
        }
    }
}
