﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordStore.Data;

#nullable disable

namespace RecordStore1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220113161146_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RecordStore.Models.Artiste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artistes");
                });

            modelBuilder.Entity("RecordStore.Models.Disque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Annee")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("LabelId")
                        .HasColumnType("int");

                    b.Property<string>("Pressing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("LabelId");

                    b.ToTable("Disques");
                });

            modelBuilder.Entity("RecordStore.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DisqueGenre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("RecordStore.Models.JointDisqueArtiste", b =>
                {
                    b.Property<int>("DisqueId")
                        .HasColumnType("int");

                    b.Property<int>("ArtisteId")
                        .HasColumnType("int");

                    b.HasKey("DisqueId", "ArtisteId");

                    b.HasIndex("ArtisteId");

                    b.ToTable("JointDisqueArtistes");
                });

            modelBuilder.Entity("RecordStore.Models.Label", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("RecordStore.Models.Disque", b =>
                {
                    b.HasOne("RecordStore.Models.Genre", "Genre")
                        .WithMany("Disques")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecordStore.Models.Label", "Label")
                        .WithMany("Disques")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Label");
                });

            modelBuilder.Entity("RecordStore.Models.JointDisqueArtiste", b =>
                {
                    b.HasOne("RecordStore.Models.Artiste", "Artiste")
                        .WithMany("JointDisqueArtistes")
                        .HasForeignKey("ArtisteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecordStore.Models.Disque", "Disque")
                        .WithMany("JointDisqueArtistes")
                        .HasForeignKey("DisqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artiste");

                    b.Navigation("Disque");
                });

            modelBuilder.Entity("RecordStore.Models.Artiste", b =>
                {
                    b.Navigation("JointDisqueArtistes");
                });

            modelBuilder.Entity("RecordStore.Models.Disque", b =>
                {
                    b.Navigation("JointDisqueArtistes");
                });

            modelBuilder.Entity("RecordStore.Models.Genre", b =>
                {
                    b.Navigation("Disques");
                });

            modelBuilder.Entity("RecordStore.Models.Label", b =>
                {
                    b.Navigation("Disques");
                });
#pragma warning restore 612, 618
        }
    }
}
