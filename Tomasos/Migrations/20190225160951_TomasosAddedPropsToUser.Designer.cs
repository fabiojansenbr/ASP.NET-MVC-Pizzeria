﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tomasos.Models;

namespace Tomasos.Migrations
{
    [DbContext(typeof(TomasosContext))]
    [Migration("20190225160951_TomasosAddedPropsToUser")]
    partial class TomasosAddedPropsToUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Tomasos.IdentityModels.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Postcode");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Street");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Tomasos.Models.Bestallning", b =>
                {
                    b.Property<int>("BestallningId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BestallningID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BestallningDatum")
                        .HasColumnType("datetime");

                    b.Property<int>("KundId")
                        .HasColumnName("KundID");

                    b.Property<bool>("Levererad");

                    b.Property<int>("Totalbelopp");

                    b.HasKey("BestallningId");

                    b.HasIndex("KundId");

                    b.ToTable("Bestallning");
                });

            modelBuilder.Entity("Tomasos.Models.BestallningMatratt", b =>
                {
                    b.Property<int>("MatrattId")
                        .HasColumnName("MatrattID");

                    b.Property<int>("BestallningId")
                        .HasColumnName("BestallningID");

                    b.Property<int>("Antal")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((1))");

                    b.HasKey("MatrattId", "BestallningId");

                    b.HasIndex("BestallningId");

                    b.ToTable("BestallningMatratt");
                });

            modelBuilder.Entity("Tomasos.Models.Kund", b =>
                {
                    b.Property<int>("KundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KundID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnvandarNamn")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Gatuadress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Losenord")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Namn")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Postnr")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Postort")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Telefon")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("KundId");

                    b.ToTable("Kund");
                });

            modelBuilder.Entity("Tomasos.Models.Matratt", b =>
                {
                    b.Property<int>("MatrattId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MatrattID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beskrivning")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("MatrattNamn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("MatrattTyp");

                    b.Property<int>("Pris");

                    b.HasKey("MatrattId");

                    b.HasIndex("MatrattTyp");

                    b.ToTable("Matratt");
                });

            modelBuilder.Entity("Tomasos.Models.MatrattProdukt", b =>
                {
                    b.Property<int>("MatrattId")
                        .HasColumnName("MatrattID");

                    b.Property<int>("ProduktId")
                        .HasColumnName("ProduktID");

                    b.HasKey("MatrattId", "ProduktId");

                    b.HasIndex("ProduktId");

                    b.ToTable("MatrattProdukt");
                });

            modelBuilder.Entity("Tomasos.Models.MatrattTyp", b =>
                {
                    b.Property<int>("MatrattTyp1")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MatrattTyp")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beskrivning")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("MatrattTyp1");

                    b.ToTable("MatrattTyp");
                });

            modelBuilder.Entity("Tomasos.Models.Produkt", b =>
                {
                    b.Property<int>("ProduktId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProduktID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProduktNamn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("ProduktId");

                    b.ToTable("Produkt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Tomasos.IdentityModels.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Tomasos.IdentityModels.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tomasos.IdentityModels.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Tomasos.IdentityModels.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tomasos.Models.Bestallning", b =>
                {
                    b.HasOne("Tomasos.Models.Kund", "Kund")
                        .WithMany("Bestallning")
                        .HasForeignKey("KundId")
                        .HasConstraintName("FK_Bestallning_Kund");
                });

            modelBuilder.Entity("Tomasos.Models.BestallningMatratt", b =>
                {
                    b.HasOne("Tomasos.Models.Bestallning", "Bestallning")
                        .WithMany("BestallningMatratt")
                        .HasForeignKey("BestallningId")
                        .HasConstraintName("FK_BestallningMatratt_Bestallning");

                    b.HasOne("Tomasos.Models.Matratt", "Matratt")
                        .WithMany("BestallningMatratt")
                        .HasForeignKey("MatrattId")
                        .HasConstraintName("FK_BestallningMatratt_Matratt");
                });

            modelBuilder.Entity("Tomasos.Models.Matratt", b =>
                {
                    b.HasOne("Tomasos.Models.MatrattTyp", "MatrattTypNavigation")
                        .WithMany("Matratt")
                        .HasForeignKey("MatrattTyp")
                        .HasConstraintName("FK_Matratt_MatrattTyp");
                });

            modelBuilder.Entity("Tomasos.Models.MatrattProdukt", b =>
                {
                    b.HasOne("Tomasos.Models.Matratt", "Matratt")
                        .WithMany("MatrattProdukt")
                        .HasForeignKey("MatrattId")
                        .HasConstraintName("FK_MatrattProdukt_Matratt");

                    b.HasOne("Tomasos.Models.Produkt", "Produkt")
                        .WithMany("MatrattProdukt")
                        .HasForeignKey("ProduktId")
                        .HasConstraintName("FK_MatrattProdukt_Produkt");
                });
#pragma warning restore 612, 618
        }
    }
}
