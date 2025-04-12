using Microsoft.EntityFrameworkCore;
using ProdutosApp.Contexts;
using ProdutosApp.Dtos;
using ProdutosApp.Entities;

namespace ProdutosApp.Repositories
{
    /// <summary>
    /// Classe de repositario dados para categoria
    /// </summary>
    public class CategoriaRepository
    {
        public List<Categoria> Consultar()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext
                    .Set<Categoria>()//consultando dados da tabela de categorias
                    .OrderBy(p=> p.Nome)//ordem alfabetica
                    .ToList();//retornar uma listagem com todas as categorias
            }
        }

        //Método para retornar o somatorio da quantidade de produtos 
        //por cada categoria,usando a função GROUP BY do banco de dados
        public List<CategoriaQtdProdutosResponseDto> GroupByQtdProdutos() 
        {
            using (var dataContext = new DataContext())
            {
                return dataContext
                    .Set<Produto>()//consulta a entidade produto
                    .Include(p => p.Categoria)//junção (JOIN) com a entidade Categoria 
                    .GroupBy(p => p.Categoria.Nome)//agrupando pelo nome da categoria
                    .Select(p => new CategoriaQtdProdutosResponseDto//projeção dos dados
                    {
                        Cstegia = p.Key,//chave do agrupamento(nome da Categoria)
                        QtdProdutos = p.Sum(p => p.Quantidade)//calculo do agrupamento
                    })
                    .OrderByDescending(dto => dto.QtdProdutos)//ordem decrescente
                    .ToList();//retornando a lista de resultado
            }
        }
        //Método para retornar o somatorio da quantidade de produtos 
        //por cada categoria,usando a função GROUP BY do banco de dados
        public List<CategoriaMediaPrecoResponseDto> GroupByMediaPreco()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext
                    .Set<Produto>()//consulta a entidade produto
                    .Include(p => p.Categoria)//junção (JOIN) com a entidade Categoria 
                    .GroupBy(p => p.Categoria.Nome)//agrupando pelo nome da categoria
                    .Select(p => new CategoriaMediaPrecoResponseDto//projeção dos dados
                    {
                        Categoria = p.Key,//chave do agrupamento(nome da Categoria)
                        MediaPreco = p.Average(p => p.Preco)//calculo do agrupamento
                    })
                    .OrderByDescending(dto => dto.MediaPreco)//ordem decrescente
                    .ToList();//retornando a lista de resultado
            }
        }

    }
}
