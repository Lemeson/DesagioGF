using Microsoft.EntityFrameworkCore;
using GestaoDeFormulario_WebAPI.Models;

namespace GestaoDeFormulario_WebAPI.Data
{
     public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } //da opções de CRUD -- obrigatório
        public DbSet<Lead> Leads { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            

            builder.Entity<Lead>()
                .HasData(new List<Lead>(){
                    new Lead(1, "Empresa1", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar"),
                    new Lead(2, "Empresa2", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar"),
                    new Lead(3, "Empresa3", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar"),
                    new Lead(4, "Empresa4", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar"),
                    new Lead(5, "Empresa5", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar")
                });


        }
    }
}