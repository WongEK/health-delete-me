﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealthAPI.Data.Migrations
{
    [DbContext(typeof(HealthContext))]
    [Migration("20220128195443_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HealthAPI.Models.Ailment", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("PatientId");

                    b.ToTable("Ailment", (string)null);

                    b.HasData(
                        new
                        {
                            Name = "Headache",
                            PatientId = 1
                        },
                        new
                        {
                            Name = "Tummy pain",
                            PatientId = 1
                        },
                        new
                        {
                            Name = "Flu",
                            PatientId = 2
                        },
                        new
                        {
                            Name = "Bone fracture",
                            PatientId = 3
                        },
                        new
                        {
                            Name = "Covid",
                            PatientId = 2
                        });
                });

            modelBuilder.Entity("HealthAPI.Models.Medication", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Doses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("PatientId");

                    b.ToTable("Medication", (string)null);

                    b.HasData(
                        new
                        {
                            Name = "Tylenol",
                            Doses = "2 tablets per day",
                            PatientId = 1
                        },
                        new
                        {
                            Name = "Aspirin",
                            Doses = "3 tablets per day",
                            PatientId = 1
                        },
                        new
                        {
                            Name = "Advil",
                            Doses = "1 tablet per day",
                            PatientId = 2
                        },
                        new
                        {
                            Name = "Robaxin",
                            Doses = "2 teaspoons per day",
                            PatientId = 3
                        },
                        new
                        {
                            Name = "Voltarin",
                            Doses = "apply cream twice per day",
                            PatientId = 2
                        });
                });

            modelBuilder.Entity("HealthAPI.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("PatientId");

                    b.ToTable("Patient", (string)null);

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            Name = "Jim Jones"
                        },
                        new
                        {
                            PatientId = 2,
                            Name = "Ann Smith"
                        },
                        new
                        {
                            PatientId = 3,
                            Name = "Tom Myers"
                        });
                });

            modelBuilder.Entity("HealthAPI.Models.Ailment", b =>
                {
                    b.HasOne("HealthAPI.Models.Patient", "Patient")
                        .WithMany("Ailments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HealthAPI.Models.Medication", b =>
                {
                    b.HasOne("HealthAPI.Models.Patient", "Patient")
                        .WithMany("Medications")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HealthAPI.Models.Patient", b =>
                {
                    b.Navigation("Ailments");

                    b.Navigation("Medications");
                });
#pragma warning restore 612, 618
        }
    }
}
