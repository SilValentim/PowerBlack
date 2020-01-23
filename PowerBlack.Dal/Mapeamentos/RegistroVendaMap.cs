using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PowerBlack.Model.Entidades;

namespace PowerBlack.Dal.Mapeamentos
{
    public class RegistroVendaMap : BaseMap<RegistroVenda>, IEntityTypeConfiguration<RegistroVenda>
    { 
        public void Configure(EntityTypeBuilder<RegistroVenda> builder)
        {
            DefaultConfigs(NomeTabela: "Registrosvendas", builder);

            builder.Property(p => p.Qtd)
                .IsRequired()
                .HasColumnType("int");

            builder.HasOne(p => p.Insumo);

        }
    }
}
