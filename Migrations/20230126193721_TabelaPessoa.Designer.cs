﻿// <auto-generated />
using System;
using CadEleitores.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadEleitores.Migrations
{
    [DbContext(typeof(BancoContexto))]
    [Migration("20230126193721_TabelaPessoa")]
    partial class TabelaPessoa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaCpf");

                    b.Property<bool>("Filhos")
                        .HasColumnType("bit")
                        .HasColumnName("PessoaFilhos");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("PessoaNasc");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaNome");

                    b.Property<string>("Pseudonimo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PessoaPsudonimo");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
