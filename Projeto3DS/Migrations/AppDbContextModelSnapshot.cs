﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto3DS.Controllers;

#nullable disable

namespace Projeto3DS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Projeto3DS.Models.Categoria", b =>
                {
                    b.Property<int>("Categoriaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Descrisao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Categoriaid");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Projeto3DS.Models.Lanche", b =>
                {
                    b.Property<int>("Lancheid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Categoriaid")
                        .HasColumnType("int");

                    b.Property<string>("Descrisaocurta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Descrisaodetalhada")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Emestoque")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImagemULR")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Imagemiminiauta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Lanchepreferido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Lancheid");

                    b.HasIndex("Categoriaid");

                    b.ToTable("Lanche");
                });

            modelBuilder.Entity("Projeto3DS.Models.Lanche", b =>
                {
                    b.HasOne("Projeto3DS.Models.Categoria", "Categoria")
                        .WithMany("Lanche")
                        .HasForeignKey("Categoriaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Projeto3DS.Models.Categoria", b =>
                {
                    b.Navigation("Lanche");
                });
#pragma warning restore 612, 618
        }
    }
}
