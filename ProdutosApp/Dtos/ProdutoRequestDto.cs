using System.ComponentModel.DataAnnotations;

namespace ProdutosApp.Dtos
{
    /// <summary>
    /// Modelo de dados para a requisição de cadastro de produtos
    /// </summary>
    public class ProdutoRequestDto
    {
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string? Nome { get; set; }

        [Range(0.01, 999999, ErrorMessage = "Por favor, informe o preço de {1} a {2}.")]
        [Required(ErrorMessage = "Por favor, informe o preço do produto.")]
        public decimal? Preco { get; set; }

        [Range(1, 999999, ErrorMessage = "Por favor, informe a quantidade de {1} a {2}")]
        [Required(ErrorMessage = "Por favor, informe a quantidade do produto.")]
        public int? Quantidade { get; set; }

        [Required(ErrorMessage = "Por favor, informe a categoria do produto.")]
        public Guid? CategoriaId { get; set; }
    }
}
