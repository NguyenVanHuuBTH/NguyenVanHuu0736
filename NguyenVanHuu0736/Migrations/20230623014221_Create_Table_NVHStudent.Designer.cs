﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NguyenVanHuu0736.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230623014221_Create_Table_NVHStudent")]
    partial class Create_Table_NVHStudent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("NguyenVanHuu0736.Models.NVHStudent", b =>
                {
                    b.Property<string>("NVHStudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("NVHStudentDIACHI")
                        .HasColumnType("TEXT");

                    b.Property<string>("NVHStudentName")
                        .HasColumnType("TEXT");

                    b.HasKey("NVHStudentId");

                    b.ToTable("NVHStudent");
                });
#pragma warning restore 612, 618
        }
    }
}
