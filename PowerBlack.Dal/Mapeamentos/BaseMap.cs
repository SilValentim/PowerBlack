using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PowerBlack.Model.Entidades;


namespace PowerBlack.Dal.Mapeamentos
{
    public class BaseMap<T>  where T : EntidadeBase
    {
        public void DefaultConfigs(string NomeTabela, EntityTypeBuilder<T> builder)
        {
            builder.ToTable(NomeTabela);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Sincronizado)
                .HasDefaultValue(false);
            builder.Property(p => p.DataCriacao)
                .HasColumnType("datetime2");
            builder.Property(p => p.DataModificacao)
                .HasColumnType("datetime2");
        }
    }

    
}
