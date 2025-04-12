using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutosApp.Dtos;
using ProdutosApp.Entities;
using ProdutosApp.Repositories;
using System.Dynamic;

namespace ProdutosApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        /// <summary>
        /// Serviço para cadastro de produto na API.
        /// </summary>
        [HttpPost]
        public IActionResult Post([FromBody] ProdutoRequestDto request)
        {
            var produto = new Produto(); //instanciando produto

            produto.Id = Guid.NewGuid(); //gerando o id do produto
            produto.Nome = request.Nome; //capturando o nome do produto enviado pelo frontend
            produto.Preco = request.Preco.Value; //capturando o preço do produto enviado pelo frontend
            produto.Quantidade = request.Quantidade.Value; //capturando a quantidade do produto enviado pelo frontend
            produto.CategoriaId = request.CategoriaId.Value; //capturando o id da categoria enviado pelo frontend

            //gravar no banco de dados
            var produtoRepository = new ProdutoRepository();
            produtoRepository.Inserir(produto);

            //retornar mensagem de sucesso
            return Ok(new { Mensagem = "Produto cadastrado com sucesso." });
        }

        /// <summary>
        /// Serviço para atualização de produto na API.
        /// </summary>
        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para exclusão de produto na API.
        /// </summary>
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        /// <summary>
        /// Serviço para consulta de produtos na API.
        /// </summary>
        [HttpGet]
        public IActionResult Get([FromQuery] string nome)
        {
            //instanciando a classe do repositório
            var produtoRepository = new ProdutoRepository();
            //executando a consulta de produtos por nome
            var produtos = produtoRepository.ConsultarPorNome(nome);
            //retornando os dados da consulta
             return Ok(produtos);
        }
    }
}

 
