using PowerBlack.Model.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PowerBlack.Dal.Mapeamentos
{
    public class UsuarioMap : BaseMap<Usuario>, IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            DefaultConfigs(NomeTabela: "Usuarios", builder);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(40);

            builder.Property(p => p.CPF)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(40);

            builder.HasOne(p => p.Login);

        }
    }
}
