using Microsoft.EntityFrameworkCore;

namespace WebCadastro.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cadastro> Cadastro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cadastro>()
                .HasKey(c => c.IdUsuario);

            modelBuilder.Entity<Cadastro>()
                .Property(c => c.Email)
                .HasColumnType("varchar(60)")
                .IsRequired(true)
                .HasColumnName("email");

            modelBuilder.Entity<Cadastro>()
                .Property(c => c.senha)
                .HasColumnType("varchar(255)")
                .IsRequired(true)
                .HasColumnName("senha");

            modelBuilder.Entity<Cadastro>()
                .Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired(true)
                .HasColumnName("Nome");

            modelBuilder.Entity<Cadastro>()
                .Property(c => c.CPF)
                .HasColumnType("varchar(13)")
                .IsRequired(true)
                .HasColumnName("CPF");

            modelBuilder.Entity<Cadastro>()
                .Property(c => c.datadeNascimento)
                .HasColumnType("varchar(15)")
                .HasColumnName("datadeNascimento");

            modelBuilder.Entity<Cadastro>()
                .Property(c => c.size)
                .HasColumnType("varchar(6)")
                .HasColumnName("size");

            modelBuilder.Entity<Cadastro>()
                .Property(c => c.datadeCriacao)
                .HasColumnType("datetime")
                .HasColumnName("datadeCriacao");

            modelBuilder.Entity<Cadastro>()
                .Property(c => c.contato)
                .HasColumnType("varchar(20)")
                .HasColumnName("contato");
                

        }

    }
}
