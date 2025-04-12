namespace ProdutosApp.Dtos
{
    /// <summary>
    /// Modelo de dados da consulta de média de preço
    /// de produtospor cada categoria
    /// </summary>
    public class CategoriaMediaPrecoResponseDto
    {
        public string? Categoria { get; set; }
        public decimal? MediaPreco { get; set; }
    }
}
