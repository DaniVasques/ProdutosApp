using ProdutosApp.Contexts;
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

    }
}
