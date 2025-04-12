namespace ProdutosApp.Dtos
{
    /// <summary>
    /// Modelo de dados da consulta de somatório da
    /// quatidade de produtos por cada categoria
    /// </summary>
    public class CategoriaQtdProdutosResponseDto
    {
        public string? Cstegia { get; set; }
        public int QtdProdutos { get; set; }
    }
}
