﻿// <auto-generated />
using GestaoDeFormulario_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoDeFormulario_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231116162024_clientes")]
    partial class clientes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("GestaoDeFormulario_WebAPI.Models.Lead", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("contato")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("detalhes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("logradouro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nomeDaEmpresa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Leads");

                    b.HasData(
                        new
                        {
                            id = 1,
                            bairro = "Bairro 1",
                            cep = "07122000",
                            cidade = "Cidade 1",
                            contato = "Contato 1",
                            detalhes = "nada a declarar",
                            email = "email1@mail.com",
                            estado = "SP",
                            logradouro = "Rua 0",
                            nomeDaEmpresa = "Empresa1",
                            numero = "1A",
                            telefone = "1234-1234"
                        },
                        new
                        {
                            id = 2,
                            bairro = "Bairro 1",
                            cep = "07122000",
                            cidade = "Cidade 1",
                            contato = "Contato 1",
                            detalhes = "nada a declarar",
                            email = "email1@mail.com",
                            estado = "SP",
                            logradouro = "Rua 0",
                            nomeDaEmpresa = "Empresa2",
                            numero = "1A",
                            telefone = "1234-1234"
                        },
                        new
                        {
                            id = 3,
                            bairro = "Bairro 1",
                            cep = "07122000",
                            cidade = "Cidade 1",
                            contato = "Contato 1",
                            detalhes = "nada a declarar",
                            email = "email1@mail.com",
                            estado = "SP",
                            logradouro = "Rua 0",
                            nomeDaEmpresa = "Empresa3",
                            numero = "1A",
                            telefone = "1234-1234"
                        },
                        new
                        {
                            id = 4,
                            bairro = "Bairro 1",
                            cep = "07122000",
                            cidade = "Cidade 1",
                            contato = "Contato 1",
                            detalhes = "nada a declarar",
                            email = "email1@mail.com",
                            estado = "SP",
                            logradouro = "Rua 0",
                            nomeDaEmpresa = "Empresa4",
                            numero = "1A",
                            telefone = "1234-1234"
                        },
                        new
                        {
                            id = 5,
                            bairro = "Bairro 1",
                            cep = "07122000",
                            cidade = "Cidade 1",
                            contato = "Contato 1",
                            detalhes = "nada a declarar",
                            email = "email1@mail.com",
                            estado = "SP",
                            logradouro = "Rua 0",
                            nomeDaEmpresa = "Empresa5",
                            numero = "1A",
                            telefone = "1234-1234"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
