using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutosApp.Entities;

namespace ProdutosApp.Mappings
{
    /// <summary>
    /// Classe de mapeamento para a entidade Produto
    /// </summary>
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //nome da tabela no banco de dados
            builder.ToTable("PRODUTO");

            //chave primaria da tabela 
            builder.HasKey(p => p.Id);

            //mapeamento dos campos da tabela
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
            builder.Property(p => p.Preco).HasColumnName("PRECO").HasColumnType("DECIMAL(10,2)").IsRequired();
            builder.Property(p => p.Quantidade).HasColumnName("QUANTIDADE").IsRequired();
            builder.Property(p => p.CategoriaId).HasColumnName("CATEGORIA_ID").IsRequired();

            //mapeamento do relacionamento
            //e do campo chave estrangeira
            builder.HasOne(p => p.Categoria)//Produto TEM 1 Categoria
                .WithMany(c => c.Produtos)//Categoria TEM Muitos Produtos
                .HasForeignKey(p => p.CategoriaId);//Chave estrangeira do relacionamento
        }
    }
}
