using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutosApp.Entities;

namespace ProdutosApp.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            //nome da tabela no banco de dados
            builder.ToTable("CATEGORIA");

            //chave primária da tabela
            builder.HasKey(c => c.Id);

            //mapeamento dos campos da tabela
            builder.Property(c => c.Id).HasColumnName("ID");
            builder.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(50).IsRequired();

            //mapear o campo "NOME" como único na tabela, ou seja,
            //não deverá permitir valores duplicados
            builder.HasIndex(c => c.Nome).IsUnique();

        }
    }
}
