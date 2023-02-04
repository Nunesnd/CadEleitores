﻿// <auto-generated />
using System;
using CadEleitores.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadEleitores.Migrations
{
    [DbContext(typeof(BancoContexto))]
    partial class BancoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CadEleitores.Models.PessoaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PessoaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaCpf");

                    b.Property<string>("Filhos")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaFilhos");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("PessoaNasc");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaNome");

                    b.Property<string>("Pseudonimo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaPsudonimo");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaSexo");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("CadEleitores.Models.ProfissaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProfissaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeProfissao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProfissaoNome");

                    b.HasKey("Id");

                    b.ToTable("Profissao");
                });
#pragma warning restore 612, 618
        }
    }
}
