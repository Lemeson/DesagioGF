using Microsoft.EntityFrameworkCore;
using GestaoDeFormulario_WebAPI.Models;

namespace GestaoDeFormulario_WebAPI.Data
{
     public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } //da opções de CRUD -- obrigatório
        public DbSet<Lead> Leads { get; set; }
      //  public DbSet<Professor> Professores { get; set; }
        //public DbSet<AgendarReuniao> AgendarReuniaos { get; set; } // para evitar problemas com o banco de dado ao inves de reunioes fica reuniaos //disicplina
        //public DbSet<LeadReuniao> LeadReuniaos { get; set; } // para evitar problemas com o banco de dado ao inves de reunioes fica reuniaos //aluno discuplina

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<LeadReuniao>()
                // .HasKey(AD => new { AD.leadId, AD.agendarReuniaoId }); //vinculo

            //builder.Entity<Professor>()
            //    .HasData(new List<Professor>(){
            //        new Professor(1, "Lauro"),
            //        new Professor(2, "Roberto"),
            //        new Professor(3, "Ronaldo"),
            //        new Professor(4, "Rodrigo"),
            //        new Professor(5, "Alexandre"),
            //    });

           // builder.Entity<AgendarReuniao>()
           //     .HasData(new List<AgendarReuniao>{
           //         new AgendarReuniao(1, "sim", "16/11/2024"),
           //         new AgendarReuniao(2, "não", "16/11/2024"),
           //         new AgendarReuniao(3, "sim", "16/11/2024"),
           //         new AgendarReuniao(4, "não", "16/11/2024"),
           //         new AgendarReuniao(5, "sim", "16/11/2023")
           //     });

            builder.Entity<Lead>()
                .HasData(new List<Lead>(){
                    new Lead(1, "Empresa1", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar","16/11/2024"),
                    new Lead(2, "Empresa2", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar","16/11/2024"),
                    new Lead(3, "Empresa3", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar","16/11/2024"),
                    new Lead(4, "Empresa4", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar","16/11/2024"),
                    new Lead(5, "Empresa5", "07122000", "Rua 0", "1A", "Bairro 1", "Cidade 1", "SP", "email1@mail.com", "1234-1234", "Contato 1", "nada a declarar","16/11/2024")                });

           // builder.Entity<LeadAgendarReuniao>()
           //     .HasData(new List<LeadAgendarReuniao>() {
           //         new LeadAgendarReuniao() {leadId = 1, agendarReuniaoId = 1 },
           //         new LeadAgendarReuniao() {leadId = 2, agendarReuniaoId = 2 },
           //         new LeadAgendarReuniao() {leadId = 3, agendarReuniaoId = 3 },
           //         new LeadAgendarReuniao() {leadId = 4, agendarReuniaoId = 4 },
           //         new LeadAgendarReuniao() {leadId = 5, agendarReuniaoId = 5 }
           //     });
        }
    }
}