using System.Text.Json.Serialization;

namespace ProdutosApp.Entities
{
    public class Categoria
    {
        #region Propriedades

        public Guid Id { get; set; }
        public string? Nome { get; set; }

        #endregion

        #region Relacionamentos
        [JsonIgnore]
        public List<Produto>? Produtos { get; set; }

        #endregion
    }
}
