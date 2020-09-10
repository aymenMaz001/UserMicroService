﻿// <auto-generated />
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20200910150107_initialCommit")]
    partial class initialCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infrastructure.EFDataAcess.Entities.Information", b =>
                {
                    b.Property<int>("InformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("information_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnName("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnName("phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserFK")
                        .HasColumnType("int");

                    b.HasKey("InformationId");

                    b.HasIndex("UserFK")
                        .IsUnique();

                    b.ToTable("information");

                    b.HasData(
                        new
                        {
                            InformationId = 1,
                            Adress = "46 Titchfield St. Liverpool L5 8UT, UNITED KINGDOM",
                            Email = "agent@agent.com",
                            Phone = "22-222-222",
                            UserFK = 1
                        },
                        new
                        {
                            InformationId = 2,
                            Adress = "46 Titchfield St. Liverpool L5 8UT, UNITED KINGDOM",
                            Email = "agent@agent.com",
                            Phone = "22-222-222",
                            UserFK = 2
                        });
                });

            modelBuilder.Entity("Infrastructure.EFDataAcess.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnName("role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnName("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            FirstName = "Agent",
                            LastName = "Agent",
                            Password = "agent",
                            Role = 0,
                            UserName = "agent"
                        },
                        new
                        {
                            UserId = 2,
                            FirstName = "Admin",
                            LastName = "Admin",
                            Password = "admin",
                            Role = 1,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Infrastructure.EFDataAcess.Entities.Information", b =>
                {
                    b.HasOne("Infrastructure.EFDataAcess.Entities.User", "User")
                        .WithOne("Information")
                        .HasForeignKey("Infrastructure.EFDataAcess.Entities.Information", "UserFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
