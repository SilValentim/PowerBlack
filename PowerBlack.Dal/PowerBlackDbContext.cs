using Microsoft.EntityFrameworkCore;
using PowerBlack.Dal.Mapeamentos;
using PowerBlack.Model.Entidades;

namespace PowerBlack.Dal
{
    public class PowerBlackDbContext : DbContext
    {
        public DbSet<Insumo> Insumos{ get; set; }
        public DbSet<RegistroVenda> RegistrosVendas { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        private string StringConnection { get; set; }

        public string _StringConection
        {
            get { return StringConnection; }
            set { StringConnection = value; }
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            optionsBuilder.UseSqlServer(@"Data Source=ASPIREVX\ASPIREVX;initial catalog=PowerBlackDB;persist security info=True;user id=sa;password=1234");
#else
            optionsBuilder.UseSqlServer(StringConnection);   
#endif
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Insumo>().ToTable("Insumos");
            //modelBuilder.Entity<Insumo>().Property(p => p.Nome).HasMaxLength(30);
            //modelBuilder.Entity<Insumo>().Property(p => p.Valor).HasColumnType("decimal(6,2)");

            modelBuilder.ApplyConfiguration(new InsumoMap());
            modelBuilder.ApplyConfiguration(new RegistroVendaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new LoginMap());
        }

    }
}
