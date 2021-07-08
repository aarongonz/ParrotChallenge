﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20210708000905_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("API.Model.DetalleOrden", b =>
                {
                    b.Property<int>("DetalleOrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleOrdenId");

                    b.HasIndex("OrdenId");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetalleOrden");
                });

            modelBuilder.Entity("API.Model.Orden", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Total")
                        .HasColumnType("Money");

                    b.Property<string>("UsuarioEmail")
                        .HasColumnType("TEXT");

                    b.HasKey("OrdenId");

                    b.HasIndex("UsuarioEmail");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("API.Model.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("Money");

                    b.HasKey("ProductoId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("API.Model.Usuario", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("API.Model.DetalleOrden", b =>
                {
                    b.HasOne("API.Model.Orden", "Orden")
                        .WithMany("Detalles")
                        .HasForeignKey("OrdenId");

                    b.HasOne("API.Model.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId");

                    b.Navigation("Orden");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("API.Model.Orden", b =>
                {
                    b.HasOne("API.Model.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioEmail");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("API.Model.Orden", b =>
                {
                    b.Navigation("Detalles");
                });
#pragma warning restore 612, 618
        }
    }
}
