﻿// <auto-generated />
using System;
using Gateway_Heindall.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gateway_Heindall.Migrations
{
    [DbContext(typeof(PrincipalContext))]
    partial class PrincipalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Gateway_Heindall.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserBancoDestino")
                        .HasColumnType("longtext");

                    b.Property<string>("UserCNPJ")
                        .HasColumnType("longtext");

                    b.Property<string>("UserHost")
                        .HasColumnType("longtext");

                    b.Property<string>("UserHostUser")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserNivel")
                        .HasColumnType("longtext");

                    b.Property<string>("UserNomeEmpresa")
                        .HasColumnType("longtext");

                    b.Property<string>("UserPort")
                        .HasColumnType("longtext");

                    b.Property<string>("UserSenha")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GrupoArea")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoMetodo")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoName")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoPassword")
                        .HasColumnType("longtext");

                    b.Property<int>("GrupoPort")
                        .HasColumnType("int");

                    b.Property<string>("GrupoType")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoURL")
                        .HasColumnType("longtext");

                    b.Property<string>("GrupoUser")
                        .HasColumnType("longtext");

                    b.Property<string>("PrivateKey")
                        .HasColumnType("longtext");

                    b.Property<string>("PublicKey")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.Integrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ApplicationUserId")
                        .HasColumnType("int");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<string>("IntegradorEndpoint")
                        .HasColumnType("longtext");

                    b.Property<string>("IntegradorGrupo")
                        .HasColumnType("longtext");

                    b.Property<string>("IntegradorNome")
                        .HasColumnType("longtext");

                    b.Property<string>("IntegradorPrivateKey")
                        .HasColumnType("longtext");

                    b.Property<string>("IntegradorPublicKey")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("GrupoId");

                    b.ToTable("Integradores");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.IntegradordoUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GrupoPassword")
                        .HasColumnType("longtext");

                    b.Property<int>("GrupoPort")
                        .HasColumnType("int");

                    b.Property<string>("GrupoUser")
                        .HasColumnType("longtext");

                    b.Property<int>("IntegradorId")
                        .HasColumnType("int");

                    b.Property<string>("IntegradorNome")
                        .HasColumnType("longtext");

                    b.Property<string>("PrivateKey")
                        .HasColumnType("longtext");

                    b.Property<string>("PublicKey")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioIDAgencia")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IntegradorId");

                    b.HasIndex("UserId1");

                    b.ToTable("IntegradoresdoUser");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.IntegradordoUserTemp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GrupoPasswordTemp")
                        .HasColumnType("longtext");

                    b.Property<int>("GrupoPortTemp")
                        .HasColumnType("int");

                    b.Property<string>("GrupoUserTemp")
                        .HasColumnType("longtext");

                    b.Property<int>("IntegradorId")
                        .HasColumnType("int");

                    b.Property<string>("IntegradorNomeTemp")
                        .HasColumnType("longtext");

                    b.Property<string>("PrivateKeyTempTemp")
                        .HasColumnType("longtext");

                    b.Property<string>("PublicKeyTemp")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioIDAgenciaTemp")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IntegradorId");

                    b.HasIndex("UserId1");

                    b.ToTable("IntegradoresdoUserTemp");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.Integrador", b =>
                {
                    b.HasOne("Gateway_Heindall.Models.ApplicationUser", null)
                        .WithMany("Integradores")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Gateway_Heindall.Models.Grupo", "Grupo")
                        .WithMany("Integradores")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.IntegradordoUser", b =>
                {
                    b.HasOne("Gateway_Heindall.Models.Integrador", "Integrador")
                        .WithMany("IntegradoresdoUser")
                        .HasForeignKey("IntegradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gateway_Heindall.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Integrador");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.IntegradordoUserTemp", b =>
                {
                    b.HasOne("Gateway_Heindall.Models.Integrador", "Integrador")
                        .WithMany()
                        .HasForeignKey("IntegradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gateway_Heindall.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Integrador");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.ApplicationUser", b =>
                {
                    b.Navigation("Integradores");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.Grupo", b =>
                {
                    b.Navigation("Integradores");
                });

            modelBuilder.Entity("Gateway_Heindall.Models.Integrador", b =>
                {
                    b.Navigation("IntegradoresdoUser");
                });
#pragma warning restore 612, 618
        }
    }
}