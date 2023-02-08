﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using financeiro.Repositorio.models;

#nullable disable

namespace financeiro.Migrations
{
    [DbContext(typeof(financeiroDbContext))]
    [Migration("20230221020001_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("financeiro.ControleDeContas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDePagamento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NomeDaConta")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Pago")
                        .HasColumnType("boolean");

                    b.Property<int>("Parcelas")
                        .HasColumnType("integer");

                    b.Property<int>("ValorDaConta")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ControleDeContas");
                });
#pragma warning restore 612, 618
        }
    }
}
