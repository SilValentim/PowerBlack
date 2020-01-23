using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PowerBlack.Model.Entidades;

namespace PowerBlack.Dal.Mapeamentos
{
    public class InsumoMap : BaseMap<Insumo>, IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            DefaultConfigs(NomeTabela: "Insumos", builder);


            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Nome).HasMaxLength(30);
                

            builder.Property(p => p.Valor).HasColumnType("decimal(6,2)");

            builder.Property(p => p.Tipo)
                .IsRequired().HasColumnType("int");

            builder.HasMany(p => p.RegistrosVendas);
        }
    }
}
