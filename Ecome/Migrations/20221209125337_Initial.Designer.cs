﻿// <auto-generated />
using System;
using Ecome.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecome.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221209125337_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecome.Models.Acteur", b =>
                {
                    b.Property<int>("ActeurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActeurId"));

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActeurId");

                    b.ToTable("Acteur");
                });

            modelBuilder.Entity("Ecome.Models.Auteur", b =>
                {
                    b.Property<int>("AuteurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuteurId"));

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuteurId");

                    b.ToTable("Auteur");
                });

            modelBuilder.Entity("Ecome.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateSortie")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("NomAutheurFilmeAuteurId")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NomAutheurFilmeAuteurId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Ecome.Models.FilmActeur", b =>
                {
                    b.Property<int>("ActeurId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ActeurId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmActeurs");
                });

            modelBuilder.Entity("Ecome.Models.FilmUser", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmUsers");
                });

            modelBuilder.Entity("Ecome.Models.Livre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuteurId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateSortie")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuteurId");

                    b.ToTable("Livres");
                });

            modelBuilder.Entity("Ecome.Models.LivreAuteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuteurId")
                        .HasColumnType("int");

                    b.Property<int>("LivreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuteurId");

                    b.HasIndex("LivreId");

                    b.ToTable("LivreAuteurs");
                });

            modelBuilder.Entity("Ecome.Models.LivreUser", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("LivreId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "LivreId");

                    b.HasIndex("LivreId");

                    b.ToTable("LivreUsers");
                });

            modelBuilder.Entity("Ecome.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ecome.Models.Film", b =>
                {
                    b.HasOne("Ecome.Models.Auteur", "NomAutheurFilme")
                        .WithMany()
                        .HasForeignKey("NomAutheurFilmeAuteurId");

                    b.Navigation("NomAutheurFilme");
                });

            modelBuilder.Entity("Ecome.Models.FilmActeur", b =>
                {
                    b.HasOne("Ecome.Models.Acteur", "Acteur")
                        .WithMany("FilmActeurs")
                        .HasForeignKey("ActeurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecome.Models.Film", "Film")
                        .WithMany("FilmActeurs")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acteur");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("Ecome.Models.FilmUser", b =>
                {
                    b.HasOne("Ecome.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecome.Models.User", "User")
                        .WithMany("FilmUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecome.Models.Livre", b =>
                {
                    b.HasOne("Ecome.Models.Auteur", "Auteur")
                        .WithMany()
                        .HasForeignKey("AuteurId");

                    b.Navigation("Auteur");
                });

            modelBuilder.Entity("Ecome.Models.LivreAuteur", b =>
                {
                    b.HasOne("Ecome.Models.Auteur", "Auteur")
                        .WithMany("LivreAuteurs")
                        .HasForeignKey("AuteurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecome.Models.Livre", "Livre")
                        .WithMany("LivreAuteurs")
                        .HasForeignKey("LivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auteur");

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("Ecome.Models.LivreUser", b =>
                {
                    b.HasOne("Ecome.Models.Livre", "Livre")
                        .WithMany()
                        .HasForeignKey("LivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecome.Models.User", "User")
                        .WithMany("LivreUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ecome.Models.Acteur", b =>
                {
                    b.Navigation("FilmActeurs");
                });

            modelBuilder.Entity("Ecome.Models.Auteur", b =>
                {
                    b.Navigation("LivreAuteurs");
                });

            modelBuilder.Entity("Ecome.Models.Film", b =>
                {
                    b.Navigation("FilmActeurs");
                });

            modelBuilder.Entity("Ecome.Models.Livre", b =>
                {
                    b.Navigation("LivreAuteurs");
                });

            modelBuilder.Entity("Ecome.Models.User", b =>
                {
                    b.Navigation("FilmUsers");

                    b.Navigation("LivreUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
