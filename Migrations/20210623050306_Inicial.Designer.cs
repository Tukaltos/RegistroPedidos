﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroPedidos.DAL;

namespace RegistroPedidos.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210623050306_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("RegistroPedidos.Models.Ordenes", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("SuplidorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("RegistroPedidos.Models.OrdenesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.HasIndex("ProductoId");

                    b.ToTable("OrdenesDetalle");
                });

            modelBuilder.Entity("RegistroPedidos.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Inventario")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Costo = 20f,
                            Descripcion = "Pepsi",
                            Inventario = 100f
                        },
                        new
                        {
                            ProductoId = 2,
                            Costo = 15f,
                            Descripcion = "Kola Real",
                            Inventario = 100f
                        },
                        new
                        {
                            ProductoId = 3,
                            Costo = 20f,
                            Descripcion = "Pastelito",
                            Inventario = 100f
                        },
                        new
                        {
                            ProductoId = 4,
                            Costo = 25f,
                            Descripcion = "Chokies",
                            Inventario = 100f
                        },
                        new
                        {
                            ProductoId = 5,
                            Costo = 30f,
                            Descripcion = "Jugo Petit",
                            Inventario = 100f
                        },
                        new
                        {
                            ProductoId = 6,
                            Costo = 25f,
                            Descripcion = "Café",
                            Inventario = 100f
                        },
                        new
                        {
                            ProductoId = 7,
                            Costo = 10f,
                            Descripcion = "Pan",
                            Inventario = 100f
                        });
                });

            modelBuilder.Entity("RegistroPedidos.Models.Suplidores", b =>
                {
                    b.Property<int>("SuplidorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SuplidorId");

                    b.ToTable("Suplidores");

                    b.HasData(
                        new
                        {
                            SuplidorId = 1,
                            Nombres = "Anneury Andrés Sosa Abreu"
                        },
                        new
                        {
                            SuplidorId = 2,
                            Nombres = "Monserrat Blasco"
                        },
                        new
                        {
                            SuplidorId = 3,
                            Nombres = "Guillem Moron"
                        },
                        new
                        {
                            SuplidorId = 4,
                            Nombres = "Carme Aznar"
                        },
                        new
                        {
                            SuplidorId = 5,
                            Nombres = "Andrea Costas"
                        });
                });

            modelBuilder.Entity("RegistroPedidos.Models.OrdenesDetalle", b =>
                {
                    b.HasOne("RegistroPedidos.Models.Ordenes", null)
                        .WithMany("Detalle")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistroPedidos.Models.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("RegistroPedidos.Models.Ordenes", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
