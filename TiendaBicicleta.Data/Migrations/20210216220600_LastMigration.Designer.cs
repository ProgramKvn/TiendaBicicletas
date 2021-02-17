﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaBicicleta.Data;

namespace TiendaBicicleta.Data.Migrations
{
    [DbContext(typeof(AplicacionDbContext))]
    [Migration("20210216220600_LastMigration")]
    partial class LastMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TiendaBicicleta.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TiendaBicicleta.Models.InventarioBicicleta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("InventarioBicicletas");
                });

            modelBuilder.Entity("TiendaBicicleta.Models.RegistroVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasMaxLength(230)
                        .HasColumnType("int");

                    b.Property<int>("InventarioBicicletaId")
                        .HasMaxLength(230)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("InventarioBicicletaId");

                    b.ToTable("RegistroVentas");
                });

            modelBuilder.Entity("TiendaBicicleta.Models.RegistroVenta", b =>
                {
                    b.HasOne("TiendaBicicleta.Models.Cliente", "Cliente")
                        .WithMany("RegistroVentas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TiendaBicicleta.Models.InventarioBicicleta", "InventarioBicicleta")
                        .WithMany("RegistroVentas")
                        .HasForeignKey("InventarioBicicletaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("InventarioBicicleta");
                });

            modelBuilder.Entity("TiendaBicicleta.Models.Cliente", b =>
                {
                    b.Navigation("RegistroVentas");
                });

            modelBuilder.Entity("TiendaBicicleta.Models.InventarioBicicleta", b =>
                {
                    b.Navigation("RegistroVentas");
                });
#pragma warning restore 612, 618
        }
    }
}
