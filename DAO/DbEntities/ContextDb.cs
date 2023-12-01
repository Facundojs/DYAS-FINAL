using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAO
{


    public partial class Model1 : DbContext
    {

    }

    public partial class ContextDb : DbContext
    {
        public ContextDb()
            : base("name=ContextDb")
        {
        }

        public virtual DbSet<EVENTO> EVENTO { get; set; }
        public virtual DbSet<EVENTO_SERVICIO> EVENTO_SERVICIO { get; set; }
        public virtual DbSet<INVITADO> INVITADO { get; set; }
        public virtual DbSet<ORGANIZADOR> ORGANIZADOR { get; set; }
        public virtual DbSet<PAGO> PAGO { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<SERVICIO> SERVICIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EVENTO>()
                .Property(e => e.NOMBRE_EVENTO)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTO>()
                .Property(e => e.LUGAR)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTO>()
                .HasMany(e => e.EVENTO_SERVICIO)
                .WithRequired(e => e.EVENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EVENTO>()
                .HasMany(e => e.INVITADO)
                .WithRequired(e => e.EVENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INVITADO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<INVITADO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<INVITADO>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<ORGANIZADOR>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<ORGANIZADOR>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<ORGANIZADOR>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<ORGANIZADOR>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PROVEEDOR>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO>()
                .Property(e => e.NOMBRE_SERVICIO)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO>()
                .HasMany(e => e.EVENTO_SERVICIO)
                .WithRequired(e => e.SERVICIO)
                .WillCascadeOnDelete(false);
        }
    }
}
