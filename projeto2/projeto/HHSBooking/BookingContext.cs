using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HHSBooking
{
    public partial class BookingContext : DbContext
    {
        public BookingContext()
        {
        }

        public BookingContext(DbContextOptions<BookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<EspecificacoesQuarto> EspecificacoesQuarto { get; set; }
        public virtual DbSet<Hoteis> Hoteis { get; set; }
        public virtual DbSet<Pagamento> Pagamento { get; set; }
        public virtual DbSet<Precario> Precario { get; set; }
        public virtual DbSet<Regimes> Regimes { get; set; }
        public virtual DbSet<Reservas> Reservas { get; set; }
        public virtual DbSet<ServicosHotel> ServicosHotel { get; set; }
        public virtual DbSet<TipoPagamento> TipoPagamento { get; set; }
        public virtual DbSet<TipoQuarto> TipoQuarto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-IH74466;Initial Catalog=Booking;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Idcliente);

                entity.Property(e => e.Idcliente).HasColumnName("IDCliente");

                entity.Property(e => e.Cc)
                    .IsRequired()
                    .HasColumnName("CC")
                    .HasMaxLength(15);

                entity.Property(e => e.CodPostal).HasMaxLength(15);

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.DataNasc)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Localidade)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Morada)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Sobrenome)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<EspecificacoesQuarto>(entity =>
            {
                entity.HasKey(e => e.Idespecificacao);

                entity.Property(e => e.Idespecificacao).HasColumnName("IDEspecificacao");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdtipoQuarto).HasColumnName("IDTipoQuarto");

                entity.HasOne(d => d.IdtipoQuartoNavigation)
                    .WithMany(p => p.EspecificacoesQuarto)
                    .HasForeignKey(d => d.IdtipoQuarto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EspecificacoesQuarto_TipoQuarto");
            });

            modelBuilder.Entity<Hoteis>(entity =>
            {
                entity.HasKey(e => e.Idhotel);

                entity.Property(e => e.Idhotel).HasColumnName("IDHotel");

                entity.Property(e => e.CodPostal)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Descricao).HasColumnType("ntext");

                entity.Property(e => e.Localidade)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Morada)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.NomeHotel)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.NumEstrelas)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Pagamento>(entity =>
            {
                entity.HasKey(e => e.CodPagamento);

                entity.Property(e => e.Cvv)
                    .HasColumnName("CVV")
                    .HasMaxLength(5);

                entity.Property(e => e.DataValidadeCartao)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Descricao).HasColumnType("ntext");

                entity.Property(e => e.IdtipoPagamento).HasColumnName("IDTipoPagamento");

                entity.Property(e => e.NomeTitular)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.NumCartao)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdtipoPagamentoNavigation)
                    .WithMany(p => p.Pagamento)
                    .HasForeignKey(d => d.IdtipoPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pagamento_TipoPagamento");
            });

            modelBuilder.Entity<Precario>(entity =>
            {
                entity.HasKey(e => new { e.Idregime, e.IdtipoQuarto });

                entity.Property(e => e.Idregime).HasColumnName("IDRegime");

                entity.Property(e => e.IdtipoQuarto).HasColumnName("IDTipoQuarto");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.Preco).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.IdregimeNavigation)
                    .WithMany(p => p.Precario)
                    .HasForeignKey(d => d.Idregime)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Precario_Regimes");

                entity.HasOne(d => d.IdtipoQuartoNavigation)
                    .WithMany(p => p.Precario)
                    .HasForeignKey(d => d.IdtipoQuarto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Precario_TipoQuarto");
            });

            modelBuilder.Entity<Regimes>(entity =>
            {
                entity.HasKey(e => e.Idregime);

                entity.Property(e => e.Idregime)
                    .HasColumnName("IDRegime")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idhotel).HasColumnName("IDHotel");

                entity.Property(e => e.TipoRegime)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdhotelNavigation)
                    .WithMany(p => p.Regimes)
                    .HasForeignKey(d => d.Idhotel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regimes_Hoteis");
            });

            modelBuilder.Entity<Reservas>(entity =>
            {
                entity.HasKey(e => e.Idreserva);

                entity.Property(e => e.Idreserva).HasColumnName("IDReserva");

                entity.Property(e => e.CheckIn).HasColumnType("date");

                entity.Property(e => e.CheckOut).HasColumnType("date");

                entity.Property(e => e.Idcliente).HasColumnName("IDCliente");

                entity.Property(e => e.Idhotel).HasColumnName("IDHotel");

                entity.Property(e => e.Idregime).HasColumnName("IDRegime");

                entity.Property(e => e.IdtipoQuarto).HasColumnName("IDTipoQuarto");

                entity.HasOne(d => d.CodPagamentoNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.CodPagamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservas_Pagamento");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.Idcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservas_Clientes");

                entity.HasOne(d => d.IdhotelNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.Idhotel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservas_Hoteis");

                entity.HasOne(d => d.IdregimeNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.Idregime)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservas_Regimes");

                entity.HasOne(d => d.IdtipoQuartoNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdtipoQuarto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservas_TipoQuarto");
            });

            modelBuilder.Entity<ServicosHotel>(entity =>
            {
                entity.HasKey(e => e.Idservicos);

                entity.Property(e => e.Idservicos).HasColumnName("IDServicos");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Idhotel).HasColumnName("IDHotel");

                entity.HasOne(d => d.IdhotelNavigation)
                    .WithMany(p => p.ServicosHotel)
                    .HasForeignKey(d => d.Idhotel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServicosHotel_Hoteis");
            });

            modelBuilder.Entity<TipoPagamento>(entity =>
            {
                entity.HasKey(e => e.IdtipoPagamento);

                entity.Property(e => e.IdtipoPagamento).HasColumnName("IDTipoPagamento");

                entity.Property(e => e.Designacao)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoQuarto>(entity =>
            {
                entity.HasKey(e => e.IdtipoQuarto);

                entity.Property(e => e.IdtipoQuarto).HasColumnName("IDTipoQuarto");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Idhotel).HasColumnName("IDHotel");

                entity.HasOne(d => d.IdhotelNavigation)
                    .WithMany(p => p.TipoQuarto)
                    .HasForeignKey(d => d.Idhotel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TipoQuarto_Hoteis");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}