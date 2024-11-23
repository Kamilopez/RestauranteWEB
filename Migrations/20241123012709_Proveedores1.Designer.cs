﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestauranteWEB.Data;

#nullable disable

namespace RestauranteWEB.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20241123012709_Proveedores1")]
    partial class Proveedores1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestauranteWEB.Models.DetallesPlato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdIngredientes")
                        .HasColumnType("int");

                    b.Property<int>("IdPlato")
                        .HasColumnType("int");

                    b.Property<int?>("IngredientesId")
                        .HasColumnType("int");

                    b.Property<int?>("PlatoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientesId");

                    b.HasIndex("PlatoId");

                    b.ToTable("DetallesPlatos");
                });

            modelBuilder.Entity("RestauranteWEB.Models.Ingredientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantidadDisponible")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UnidadMedida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("RestauranteWEB.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FechaPedido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdProveedor")
                        .HasColumnType("int");

                    b.Property<int?>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProveedorId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("RestauranteWEB.Models.Plato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Platos");
                });

            modelBuilder.Entity("RestauranteWEB.Models.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("RestauranteWEB.Models.DetallesPlato", b =>
                {
                    b.HasOne("RestauranteWEB.Models.Ingredientes", "Ingredientes")
                        .WithMany("DetallesPlatos")
                        .HasForeignKey("IngredientesId");

                    b.HasOne("RestauranteWEB.Models.Plato", "Plato")
                        .WithMany("DetallesPlatos")
                        .HasForeignKey("PlatoId");

                    b.Navigation("Ingredientes");

                    b.Navigation("Plato");
                });

            modelBuilder.Entity("RestauranteWEB.Models.Pedido", b =>
                {
                    b.HasOne("RestauranteWEB.Models.Proveedor", "Proveedor")
                        .WithMany("Pedidos")
                        .HasForeignKey("ProveedorId");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("RestauranteWEB.Models.Ingredientes", b =>
                {
                    b.Navigation("DetallesPlatos");
                });

            modelBuilder.Entity("RestauranteWEB.Models.Plato", b =>
                {
                    b.Navigation("DetallesPlatos");
                });

            modelBuilder.Entity("RestauranteWEB.Models.Proveedor", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
