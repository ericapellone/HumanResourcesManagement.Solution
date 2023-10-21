﻿// <auto-generated />
using System;
using HumanResourcesManagementAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HumanResourcesManagementAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.BenefitsContratto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid>("BenefitsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContrattoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BenefitsID");

                    b.HasIndex("ContrattoID");

                    b.ToTable("BenefitsContratti");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.Candidato_Esperienze", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid>("CandidatoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EsperienzeLavorativeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoID");

                    b.HasIndex("EsperienzeLavorativeID");

                    b.ToTable("CandidatiEsperienze");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.HardSkillCandidato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid>("CandidatoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HardSkillID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoID");

                    b.HasIndex("HardSkillID");

                    b.ToTable("HardSkillsCandidati");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.Sede_Dipendente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid>("DipendenteID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DipendenteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SedeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DipendenteID")
                        .IsUnique();

                    b.HasIndex("DipendenteId");

                    b.HasIndex("SedeID");

                    b.ToTable("Sede_Dipendente");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.SoftSkillCandidato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid>("CandidatoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SoftSkillID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoID");

                    b.HasIndex("SoftSkillID");

                    b.ToTable("SoftSkillsCandidati");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.TipologiaColloquio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TipologieColloqui");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.TipologiaContratto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TipologieContratti");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.TipologiaDocumento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TipologieDocumenti");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.TitoloDiStudioCandidato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid>("CandidatoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TitoloDiStudioID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoID");

                    b.HasIndex("TitoloDiStudioID");

                    b.ToTable("TitoliDiStudioCandidati");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Benefits", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Benefits");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Candidato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("CF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cognome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ColloquioID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comune")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDiNascita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecapitoTelefonico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Candidati");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Colloquio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid>("CandidatoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataColloquio")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DipendenteColloquioID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DipendenteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("SedeColloquioID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipologiaColloquioID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoID")
                        .IsUnique();

                    b.HasIndex("DipendenteId");

                    b.HasIndex("SedeColloquioID")
                        .IsUnique();

                    b.HasIndex("TipologiaColloquioID");

                    b.ToTable("Colloqui");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Contratto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid>("LivelloContrattualeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MansioneID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipoContrattoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipologiaContrattoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TipologiaDocumentoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LivelloContrattualeID");

                    b.HasIndex("MansioneID");

                    b.HasIndex("TipologiaContrattoId");

                    b.HasIndex("TipologiaDocumentoID");

                    b.ToTable("Contratti");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Dipendente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("CF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MansioneID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MansioneID");

                    b.ToTable("Dipendenti");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.EsperienzeLavorative", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Azienda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataFine")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInizio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EsperienzeLavorative");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.HardSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Candidato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HardSkills");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.LivelloContrattuale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LivelliContrattuali");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Mansione", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Mansioni");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Sede", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailSede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDReferente")
                        .HasColumnType("int");

                    b.Property<string>("Indirizzo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecapitoTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sedi");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.SoftSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid?>("CandidatoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("SoftSkills");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.TitoloDiStudio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<Guid?>("CandidatoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descrizione")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("TitoliDiStudio");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.BenefitsContratto", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Benefits", "Benefits")
                        .WithMany("BenefitsContratto")
                        .HasForeignKey("BenefitsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Contratto", "Contratto")
                        .WithMany("BenefitsContratto")
                        .HasForeignKey("ContrattoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Benefits");

                    b.Navigation("Contratto");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.Candidato_Esperienze", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Candidato", "Candidato")
                        .WithMany()
                        .HasForeignKey("CandidatoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.EsperienzeLavorative", "EsperienzeLavorative")
                        .WithMany()
                        .HasForeignKey("EsperienzeLavorativeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");

                    b.Navigation("EsperienzeLavorative");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.HardSkillCandidato", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Candidato", "Candidato")
                        .WithMany("HardSkillsCandidato")
                        .HasForeignKey("CandidatoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.HardSkill", "HardSkill")
                        .WithMany("HardSkillsCandidato")
                        .HasForeignKey("HardSkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");

                    b.Navigation("HardSkill");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.Sede_Dipendente", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Dipendente", "Dipendente")
                        .WithOne()
                        .HasForeignKey("HumanResourcesManagementAPI.Models.Associazioni.Sede_Dipendente", "DipendenteID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Dipendente", null)
                        .WithMany("SedeDipendente")
                        .HasForeignKey("DipendenteId");

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Sede", "Sede")
                        .WithMany("SedeDipendente")
                        .HasForeignKey("SedeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Dipendente");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.SoftSkillCandidato", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Candidato", "Candidato")
                        .WithMany()
                        .HasForeignKey("CandidatoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.SoftSkill", "SoftSkill")
                        .WithMany("SoftSkillsCandidato")
                        .HasForeignKey("SoftSkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");

                    b.Navigation("SoftSkill");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Associazioni.TitoloDiStudioCandidato", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Candidato", "Candidato")
                        .WithMany()
                        .HasForeignKey("CandidatoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.TitoloDiStudio", "TitoloDiStudio")
                        .WithMany("TitoliDiStudioCandidato")
                        .HasForeignKey("TitoloDiStudioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");

                    b.Navigation("TitoloDiStudio");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Colloquio", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Candidato", "Candidato")
                        .WithOne("Colloquio")
                        .HasForeignKey("HumanResourcesManagementAPI.Models.Classi.Colloquio", "CandidatoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Dipendente", "Dipendente")
                        .WithMany()
                        .HasForeignKey("DipendenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Sede", "Sede")
                        .WithOne()
                        .HasForeignKey("HumanResourcesManagementAPI.Models.Classi.Colloquio", "SedeColloquioID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Associazioni.TipologiaColloquio", "TipologiaColloquio")
                        .WithMany()
                        .HasForeignKey("TipologiaColloquioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");

                    b.Navigation("Dipendente");

                    b.Navigation("Sede");

                    b.Navigation("TipologiaColloquio");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Contratto", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.LivelloContrattuale", "LivelloContrattuale")
                        .WithMany()
                        .HasForeignKey("LivelloContrattualeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Mansione", "Mansione")
                        .WithMany()
                        .HasForeignKey("MansioneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Associazioni.TipologiaContratto", "TipologiaContratto")
                        .WithMany()
                        .HasForeignKey("TipologiaContrattoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HumanResourcesManagementAPI.Models.Associazioni.TipologiaDocumento", "TipologiaDocumento")
                        .WithMany()
                        .HasForeignKey("TipologiaDocumentoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LivelloContrattuale");

                    b.Navigation("Mansione");

                    b.Navigation("TipologiaContratto");

                    b.Navigation("TipologiaDocumento");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Dipendente", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Mansione", "Mansione")
                        .WithMany()
                        .HasForeignKey("MansioneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mansione");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.SoftSkill", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Candidato", null)
                        .WithMany("SoftSkillsCandidato")
                        .HasForeignKey("CandidatoId");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.TitoloDiStudio", b =>
                {
                    b.HasOne("HumanResourcesManagementAPI.Models.Classi.Candidato", null)
                        .WithMany("TitoliDiStudioCandidato")
                        .HasForeignKey("CandidatoId");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Benefits", b =>
                {
                    b.Navigation("BenefitsContratto");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Candidato", b =>
                {
                    b.Navigation("Colloquio");

                    b.Navigation("HardSkillsCandidato");

                    b.Navigation("SoftSkillsCandidato");

                    b.Navigation("TitoliDiStudioCandidato");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Contratto", b =>
                {
                    b.Navigation("BenefitsContratto");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Dipendente", b =>
                {
                    b.Navigation("SedeDipendente");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.HardSkill", b =>
                {
                    b.Navigation("HardSkillsCandidato");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.Sede", b =>
                {
                    b.Navigation("SedeDipendente");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.SoftSkill", b =>
                {
                    b.Navigation("SoftSkillsCandidato");
                });

            modelBuilder.Entity("HumanResourcesManagementAPI.Models.Classi.TitoloDiStudio", b =>
                {
                    b.Navigation("TitoliDiStudioCandidato");
                });
#pragma warning restore 612, 618
        }
    }
}
