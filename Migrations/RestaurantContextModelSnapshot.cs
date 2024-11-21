﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestauranteWEB.Data;

#nullable disable

namespace RestauranteWEB.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("DetallesPlato");
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

            modelBuilder.Entity("RestauranteWEB.Models.Ingredientes", b =>
                {
                    b.Navigation("DetallesPlatos");
                });

            modelBuilder.Entity("RestauranteWEB.Models.Plato", b =>
                {
                    b.Navigation("DetallesPlatos");
                });
#pragma warning restore 612, 618
        }
    }
}
