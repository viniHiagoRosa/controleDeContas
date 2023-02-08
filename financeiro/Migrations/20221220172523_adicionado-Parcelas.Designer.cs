﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using financeiro.Repositorio.models;

#nullable disable

namespace financeiro.Migrations
{
    [DbContext(typeof(financeiroDbContext))]
    [Migration("20221220172523_adicionado-Parcelas")]
    partial class adicionadoParcelas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("financeiro.ControleDeContas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDePagamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeDaConta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<int>("Parcelar")
                        .HasColumnType("int");

                    b.Property<int>("ValorDaConta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ControleDeContas");
                });
#pragma warning restore 612, 618
        }
    }
}