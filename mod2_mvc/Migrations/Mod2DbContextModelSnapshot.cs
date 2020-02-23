﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mod2_mvc.BD;

namespace mod2_Ativ1.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class Mod2DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mod2_mvc.Models.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Paises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "55",
                            Nome = "Brasil"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "54",
                            Nome = "Argentina"
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "591",
                            Nome = "Bolívia"
                        },
                        new
                        {
                            Id = 4,
                            Codigo = "não",
                            Nome = "Paraguai"
                        },
                        new
                        {
                            Id = 5,
                            Codigo = "598",
                            Nome = "Uruguai"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
