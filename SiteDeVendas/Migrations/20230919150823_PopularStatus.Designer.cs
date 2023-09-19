﻿// <auto-generated />
using System;
using KontrolaPoc.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KontrolaPoc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230919150823_PopularStatus")]
    partial class PopularStatus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KontrolaPoc.Models.Chamado", b =>
                {
                    b.Property<int>("ChamadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChamadoId"));

                    b.Property<string>("Conclusao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataFechamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diagnostico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GravidadeId")
                        .HasColumnType("int");

                    b.Property<int>("ModalidadeId")
                        .HasColumnType("int");

                    b.Property<string>("Pendencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TendenciaId")
                        .HasColumnType("int");

                    b.Property<int>("UrgenciaId")
                        .HasColumnType("int");

                    b.HasKey("ChamadoId");

                    b.HasIndex("GravidadeId");

                    b.HasIndex("ModalidadeId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TendenciaId");

                    b.HasIndex("UrgenciaId");

                    b.ToTable("Chamados");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnderecoId"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Cep")
                        .HasColumnType("decimal(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FilialId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("EnderecoId");

                    b.HasIndex("FilialId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Equipamento", b =>
                {
                    b.Property<int>("EquipamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipamentoId"));

                    b.Property<int>("FilialId")
                        .HasColumnType("int");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroSerie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Potencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipamentoId");

                    b.HasIndex("FilialId");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Filial", b =>
                {
                    b.Property<int>("FilialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilialId"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilialId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Filiais");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Gravidade", b =>
                {
                    b.Property<int>("GravidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GravidadeId"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GravidadeId");

                    b.ToTable("Gravidades");
                });

            modelBuilder.Entity("KontrolaPoc.Models.ItemChamado", b =>
                {
                    b.Property<int>("ItemChamadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemChamadoId"));

                    b.Property<int>("ChamadoId")
                        .HasColumnType("int");

                    b.Property<int>("EquipamentoId")
                        .HasColumnType("int");

                    b.HasKey("ItemChamadoId");

                    b.HasIndex("ChamadoId");

                    b.HasIndex("EquipamentoId");

                    b.ToTable("ItemChamados");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Modalidade", b =>
                {
                    b.Property<int>("ModalidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModalidadeId"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModalidadeId");

                    b.ToTable("Modalidades");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusId"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Tendencia", b =>
                {
                    b.Property<int>("TendenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TendenciaId"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TendenciaId");

                    b.ToTable("Tendencias");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Urgencia", b =>
                {
                    b.Property<int>("UrgenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrgenciaId"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrgenciaId");

                    b.ToTable("Urgencias");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Chamado", b =>
                {
                    b.HasOne("KontrolaPoc.Models.Gravidade", "Gravidade")
                        .WithMany("Chamados")
                        .HasForeignKey("GravidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KontrolaPoc.Models.Modalidade", "Modalidade")
                        .WithMany("Chamados")
                        .HasForeignKey("ModalidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KontrolaPoc.Models.Status", "Status")
                        .WithMany("Chamados")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KontrolaPoc.Models.Tendencia", "Tendencia")
                        .WithMany("Chamados")
                        .HasForeignKey("TendenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KontrolaPoc.Models.Urgencia", "Urgencia")
                        .WithMany("Chamados")
                        .HasForeignKey("UrgenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gravidade");

                    b.Navigation("Modalidade");

                    b.Navigation("Status");

                    b.Navigation("Tendencia");

                    b.Navigation("Urgencia");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Endereco", b =>
                {
                    b.HasOne("KontrolaPoc.Models.Filial", "Filial")
                        .WithMany("Enderecos")
                        .HasForeignKey("FilialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Equipamento", b =>
                {
                    b.HasOne("KontrolaPoc.Models.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("FilialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Filial", b =>
                {
                    b.HasOne("KontrolaPoc.Models.Cliente", "Cliente")
                        .WithMany("Filiais")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("KontrolaPoc.Models.ItemChamado", b =>
                {
                    b.HasOne("KontrolaPoc.Models.Chamado", "Chamado")
                        .WithMany("ItemChamados")
                        .HasForeignKey("ChamadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KontrolaPoc.Models.Equipamento", "Equipamento")
                        .WithMany("itemChamados")
                        .HasForeignKey("EquipamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chamado");

                    b.Navigation("Equipamento");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Chamado", b =>
                {
                    b.Navigation("ItemChamados");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Cliente", b =>
                {
                    b.Navigation("Filiais");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Equipamento", b =>
                {
                    b.Navigation("itemChamados");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Filial", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Gravidade", b =>
                {
                    b.Navigation("Chamados");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Modalidade", b =>
                {
                    b.Navigation("Chamados");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Status", b =>
                {
                    b.Navigation("Chamados");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Tendencia", b =>
                {
                    b.Navigation("Chamados");
                });

            modelBuilder.Entity("KontrolaPoc.Models.Urgencia", b =>
                {
                    b.Navigation("Chamados");
                });
#pragma warning restore 612, 618
        }
    }
}
