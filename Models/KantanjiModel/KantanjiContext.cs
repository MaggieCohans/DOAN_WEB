using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DOAN_WEB.Models.KantanjiModel
{
    public partial class KantanjiContext : DbContext
    {
        public KantanjiContext()
            : base("name=KantanjiContext1")
        {
        }

        public virtual DbSet<AUDIO> AUDIOs { get; set; }
        public virtual DbSet<BODE> BODEs { get; set; }
        public virtual DbSet<CAPDO> CAPDOes { get; set; }
        public virtual DbSet<CHUDECHINH> CHUDECHINHs { get; set; }
        public virtual DbSet<DEDOC> DEDOCs { get; set; }
        public virtual DbSet<DENGHE> DENGHEs { get; set; }
        public virtual DbSet<DETVNP> DETVNPs { get; set; }
        public virtual DbSet<DOCHIEU> DOCHIEUx { get; set; }
        public virtual DbSet<FLASHCARD> FLASHCARDs { get; set; }
        public virtual DbSet<KANJI> KANJIs { get; set; }
        public virtual DbSet<NGUCANH> NGUCANHs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THONGTIN> THONGTINs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AUDIO>()
                .Property(e => e.LINKAUDIO)
                .IsFixedLength();

            modelBuilder.Entity<AUDIO>()
                .HasMany(e => e.DENGHEs)
                .WithRequired(e => e.AUDIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODE>()
                .HasMany(e => e.DEDOCs)
                .WithRequired(e => e.BODE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODE>()
                .HasMany(e => e.DENGHEs)
                .WithRequired(e => e.BODE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BODE>()
                .HasMany(e => e.DETVNPs)
                .WithRequired(e => e.BODE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAPDO>()
                .HasMany(e => e.NGUCANHs)
                .WithRequired(e => e.CAPDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUDECHINH>()
                .Property(e => e.LINKANH)
                .IsFixedLength();

            modelBuilder.Entity<CHUDECHINH>()
                .HasMany(e => e.FLASHCARDs)
                .WithRequired(e => e.CHUDECHINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUDECHINH>()
                .HasMany(e => e.NGUCANHs)
                .WithRequired(e => e.CHUDECHINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEDOC>()
                .Property(e => e.CAUHOI)
                .IsFixedLength();

            modelBuilder.Entity<DEDOC>()
                .Property(e => e.DA1)
                .IsFixedLength();

            modelBuilder.Entity<DEDOC>()
                .Property(e => e.DA2)
                .IsFixedLength();

            modelBuilder.Entity<DEDOC>()
                .Property(e => e.DA3)
                .IsFixedLength();

            modelBuilder.Entity<DENGHE>()
                .Property(e => e.DA1)
                .IsFixedLength();

            modelBuilder.Entity<DENGHE>()
                .Property(e => e.DA2)
                .IsFixedLength();

            modelBuilder.Entity<DENGHE>()
                .Property(e => e.DA3)
                .IsFixedLength();

            modelBuilder.Entity<DETVNP>()
                .Property(e => e.CAUHOI)
                .IsFixedLength();

            modelBuilder.Entity<DETVNP>()
                .Property(e => e.DA1)
                .IsFixedLength();

            modelBuilder.Entity<DETVNP>()
                .Property(e => e.DA2)
                .IsFixedLength();

            modelBuilder.Entity<DETVNP>()
                .Property(e => e.DA3)
                .IsFixedLength();

            modelBuilder.Entity<DOCHIEU>()
                .Property(e => e.LINKANH)
                .IsFixedLength();

            modelBuilder.Entity<DOCHIEU>()
                .HasMany(e => e.DEDOCs)
                .WithRequired(e => e.DOCHIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KANJI>()
                .Property(e => e.TUKANJI)
                .IsFixedLength();

            modelBuilder.Entity<KANJI>()
                .Property(e => e.ANHKANJI)
                .IsFixedLength();

            modelBuilder.Entity<KANJI>()
                .Property(e => e.AMON)
                .IsFixedLength();

            modelBuilder.Entity<KANJI>()
                .Property(e => e.AMKUN)
                .IsFixedLength();

            modelBuilder.Entity<KANJI>()
                .Property(e => e.VIDU)
                .IsFixedLength();

            modelBuilder.Entity<NGUCANH>()
                .Property(e => e.LINKANH)
                .IsFixedLength();

            modelBuilder.Entity<NGUCANH>()
                .HasMany(e => e.KANJIs)
                .WithRequired(e => e.NGUCANH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THONGTIN>()
                .Property(e => e.CMND_CCCD)
                .IsFixedLength();

            modelBuilder.Entity<THONGTIN>()
                .Property(e => e.ANH)
                .IsFixedLength();

            modelBuilder.Entity<THONGTIN>()
                .Property(e => e.CAPDO)
                .IsFixedLength();

            modelBuilder.Entity<USER>()
                .Property(e => e.TAIKHOAN)
                .IsFixedLength();

            modelBuilder.Entity<USER>()
                .Property(e => e.ENPASSWORD)
                .IsFixedLength();

            modelBuilder.Entity<USER>()
                .HasMany(e => e.THONGTINs)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);
        }
    }
}
