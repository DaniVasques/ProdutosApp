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

    }
}
