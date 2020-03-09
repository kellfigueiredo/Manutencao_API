using Cadastro.Models;
using Microsoft.EntityFrameworkCore;


namespace Cadastro.Data
{
    public class PessoaFisica_Context : DbContext
    {
        public PessoaFisica_Context(DbContextOptions<PessoaFisica_Context> options) : base(options) { } 
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<PessoaFisica>()
                               .HasOne(c => c.Telefone).WithOne(b => b.PessoaFisica)
                               .HasForeignKey<PessoaFisica>(a=>a.TelefoneId) 
                               .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<PessoaFisica>()
                            .HasOne(a => a.Endereco).WithOne(b => b.PessoaFisica)
                             .HasForeignKey<PessoaFisica>(a => a.EnderecoId) 
                            .OnDelete(DeleteBehavior.Cascade); 
            modelBuilder.Entity<PessoaFisica>().ToTable("PessoaFisica").HasKey(x => x.PessoaFisicaId);
            modelBuilder.Entity<Telefone>().ToTable("Telefone").HasKey(x => x.TelefoneId);
            modelBuilder.Entity<Endereco>().ToTable("Endereco").HasKey(x => x.EnderecoId); 


        }


    }
}
