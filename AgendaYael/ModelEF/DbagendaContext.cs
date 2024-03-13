﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AgendaYael.ModelEF;

public partial class DbagendaContext : DbContext
{
    public DbagendaContext()
    {
    }

    public DbagendaContext(DbContextOptions<DbagendaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=dbagenda; Convert Zero Datetime=True;", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.21-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PRIMARY");

            entity.ToTable("contacts");

            entity.Property(e => e.ContactId)
                .ValueGeneratedNever()
                .HasColumnName("contactId");
            entity.Property(e => e.Adresse).HasMaxLength(45);
            entity.Property(e => e.DateDeNaissance).HasColumnName("Date de naissance");
            entity.Property(e => e.EMail)
                .HasMaxLength(45)
                .HasColumnName("E-mail");
            entity.Property(e => e.Nom).HasMaxLength(45);
            entity.Property(e => e.NumeroDeTel).HasColumnName("Numero de tel");
            entity.Property(e => e.Prenom).HasMaxLength(45);
            entity.Property(e => e.ResauxSociaux).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
