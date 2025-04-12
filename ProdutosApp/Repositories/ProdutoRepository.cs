using Microsoft.EntityFrameworkCore;
using ProdutosApp.Contexts;
using ProdutosApp.Entities;

namespace ProdutosApp.Repositories
{
    /// <summary>
    /// Classe de repositario daddos para produto
    /// </summary>
    public class ProdutoRepository
    {
        //Método para inserir(gravar) um produto no banco de dados
        public void Inserir(Produto produto)
        {
            //abrindo conexão com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                dataContext.Add(produto);//
                dataContext.SaveChanges();
            }

        }

        public void Atualizar(Produto produto)
        {
            //abrindo conexão com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                dataContext.Update(produto);
                dataContext.SaveChanges();
            }

        }

        public void Excluir(Produto produto)
        {
            //abrindo conexão com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(produto);
                dataContext.SaveChanges();
            }

        }

        public Produto? ObterPorId(Guid id)
        {
            //abrindo conexão com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                return dataContext
                    .Set<Produto>()
                    .Where(p => p.Id == id)
                    .FirstOrDefault();

            }
        }
        //Método para pode consultar todos os produtos que contenham um determinado nome
        public List<Produto> ConsultarPorNome(string nome)
        {
            //abrindo conexão com banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            { 
                return dataContext
                    .Set<Produto>()//consultando os dados da entidade produto
                    .Include(p => p.Categoria)//incluindo os dados da categoria
                    .Where(p => p.Nome.Contains(nome))//filtrando produtos pelo nome
                    .OrderBy(p => p.Nome)//oredem alfabética de nome
                    .ToList();//retornando uma lista com todos os produtos encontrados
            }
        }

    }
}
