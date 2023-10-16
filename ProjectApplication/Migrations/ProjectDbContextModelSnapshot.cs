﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectApplication.Persistence;

#nullable disable

namespace ProjectApplication.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectApplication.Persistence.ProjectDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("ProjectDbs");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreatedDate = new DateTime(2023, 10, 11, 14, 11, 1, 835, DateTimeKind.Local).AddTicks(2190),
                            Title = "Learning ASP.NET Core with MVC"
                        });
                });

            modelBuilder.Entity("ProjectApplication.Persistence.TaskDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("TaskDbs");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Description = "Follow the turtorials",
                            LastUpdated = new DateTime(2023, 10, 11, 14, 11, 1, 835, DateTimeKind.Local).AddTicks(2415),
                            ProjectId = -1,
                            Status = 1
                        },
                        new
                        {
                            Id = -2,
                            Description = "Do it yourself!",
                            LastUpdated = new DateTime(2023, 10, 11, 14, 11, 1, 835, DateTimeKind.Local).AddTicks(2419),
                            ProjectId = -1,
                            Status = 0
                        });
                });

            modelBuilder.Entity("ProjectApplication.Persistence.TaskDb", b =>
                {
                    b.HasOne("ProjectApplication.Persistence.ProjectDb", "ProjectDb")
                        .WithMany("TaskDbs")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectDb");
                });

            modelBuilder.Entity("ProjectApplication.Persistence.ProjectDb", b =>
                {
                    b.Navigation("TaskDbs");
                });
#pragma warning restore 612, 618
        }
    }
}
