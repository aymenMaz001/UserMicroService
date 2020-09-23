﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("Birthdate")
                        .HasColumnName("birthdata")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnName("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MartialStatus")
                        .HasColumnName("martial_status")
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
                            Adress = "43 St. Tunis, Tunisa",
                            Birthdate = new DateTime(1986, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "agent@agent.com",
                            FirstName = "Agent",
                            Gender = "Male",
                            LastName = "Agent",
                            MartialStatus = "Single",
                            Phone = "22-222-222",
                            UserFK = 1
                        },
                        new
                        {
                            InformationId = 2,
                            Adress = "46  St. Tunis, Tunisia",
                            Birthdate = new DateTime(1977, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            Gender = "Male",
                            LastName = "Admin",
                            MartialStatus = "Married",
                            Phone = "22-666-777",
                            UserFK = 2
                        },
                        new
                        {
                            InformationId = 3,
                            Adress = "24  St. Tunis, Tunisia",
                            Birthdate = new DateTime(1990, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@admin.com",
                            FirstName = "Agent2",
                            Gender = "Female",
                            LastName = "Agent2",
                            MartialStatus = "Married",
                            Phone = "22-444-222",
                            UserFK = 3
                        },
                        new
                        {
                            InformationId = 4,
                            Adress = "27 St. Tunis , Tunisia",
                            Birthdate = new DateTime(1977, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "agent4@agent.com",
                            FirstName = "Agent3",
                            Gender = "Male",
                            LastName = "Agent3",
                            MartialStatus = "Married",
                            Phone = "97-222-333",
                            UserFK = 4
                        },
                        new
                        {
                            InformationId = 5,
                            Adress = "22 St. Tunis , Tunisia",
                            Birthdate = new DateTime(1992, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "agent4@agent.com",
                            FirstName = "Agent4",
                            Gender = "Female",
                            LastName = "Agent4",
                            MartialStatus = "Single",
                            Phone = "22-222-222",
                            UserFK = 5
                        });
                });

            modelBuilder.Entity("Infrastructure.EFDataAcess.Entities.Simulation", b =>
                {
                    b.Property<int>("SimulationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgentId")
                        .HasColumnName("agent_id")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnName("client_id")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnName("product_id")
                        .HasColumnType("int");

                    b.Property<int>("User_fk")
                        .HasColumnType("int");

                    b.HasKey("SimulationId");

                    b.HasIndex("User_fk");

                    b.ToTable("simulations");

                    b.HasData(
                        new
                        {
                            SimulationId = 1,
                            AgentId = 1,
                            ClientId = 1,
                            ProductId = 1,
                            User_fk = 1
                        },
                        new
                        {
                            SimulationId = 2,
                            AgentId = 1,
                            ClientId = 1,
                            ProductId = 1,
                            User_fk = 1
                        },
                        new
                        {
                            SimulationId = 3,
                            AgentId = 1,
                            ClientId = 1,
                            ProductId = 1,
                            User_fk = 1
                        },
                        new
                        {
                            SimulationId = 4,
                            AgentId = 1,
                            ClientId = 1,
                            ProductId = 1,
                            User_fk = 3
                        },
                        new
                        {
                            SimulationId = 5,
                            AgentId = 1,
                            ClientId = 1,
                            ProductId = 1,
                            User_fk = 1
                        },
                        new
                        {
                            SimulationId = 6,
                            AgentId = 1,
                            ClientId = 1,
                            ProductId = 1,
                            User_fk = 3
                        });
                });

            modelBuilder.Entity("Infrastructure.EFDataAcess.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnName("role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnName("username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("c_user")
                        .HasColumnName("c_user")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Password = "agent",
                            Role = 0,
                            UserName = "agent",
                            c_user = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 2,
                            Password = "admin",
                            Role = 1,
                            UserName = "admin",
                            c_user = new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 3,
                            Password = "agent2",
                            Role = 0,
                            UserName = "agent2",
                            c_user = new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 4,
                            Password = "agent3",
                            Role = 0,
                            UserName = "agent3",
                            c_user = new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = 5,
                            Password = "agent4",
                            Role = 0,
                            UserName = "agent4",
                            c_user = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
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

            modelBuilder.Entity("Infrastructure.EFDataAcess.Entities.Simulation", b =>
                {
                    b.HasOne("Infrastructure.EFDataAcess.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("User_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
