using PowerBlack.Model.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PowerBlack.Dal.Mapeamentos
{
    public class LoginMap : BaseMap<Login>, IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            DefaultConfigs(NomeTabela:"Logins", builder);

            builder.Property(p => p.Email).IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(60);

            builder.Property(p => p.Senha)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(20);


            builder.Ignore(p => p.DataCriacao);

        }

    }
}
