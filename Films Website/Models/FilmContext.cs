using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NewFilms.Models;

public partial class FilmContext : DbContext
{
    public FilmContext()
    {
    }

    public FilmContext(DbContextOptions<FilmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActionFilm> ActionFilms { get; set; }

    public virtual DbSet<ComedyFilm> ComedyFilms { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<HorrorFilm> HorrorFilms { get; set; }

    public virtual DbSet<RomcomFilm> RomcomFilms { get; set; }

    public virtual DbSet<ScifiFilm> ScifiFilms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER19;  Initial Catalog=Film; Trusted_Connection=True; Integrated Security=True; Trust Server Certificate=True; ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActionFilm>(entity =>
        {
            entity.HasKey(e => e.FilmId).HasName("PK__action_f__C036FF51278C39E9");

            entity.ToTable("action_films");

            entity.HasIndex(e => e.FilmName, "UQ__action_f__B13B39500FB4AE57").IsUnique();

            entity.Property(e => e.FilmId)
                .ValueGeneratedNever()
                .HasColumnName("filmId");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .HasColumnName("director");
            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .HasColumnName("film_name");
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .HasColumnName("genre");
            entity.Property(e => e.Imdb).HasColumnName("imdb");
            entity.Property(e => e.LeadActor)
                .HasMaxLength(50)
                .HasColumnName("lead_actor");
            entity.Property(e => e.ReleasedDate)
                .HasColumnType("date")
                .HasColumnName("released_date");
        });

        modelBuilder.Entity<ComedyFilm>(entity =>
        {
            entity.HasKey(e => e.FilmId).HasName("PK__comedy_f__C036FF51F6333520");

            entity.ToTable("comedy_films");

            entity.HasIndex(e => e.FilmName, "UQ__comedy_f__B13B3950CDD5B8F5").IsUnique();

            entity.Property(e => e.FilmId)
                .ValueGeneratedNever()
                .HasColumnName("filmId");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .HasColumnName("director");
            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .HasColumnName("film_name");
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .HasColumnName("genre");
            entity.Property(e => e.Imdb).HasColumnName("imdb");
            entity.Property(e => e.LeadActor)
                .HasMaxLength(50)
                .HasColumnName("lead_actor");
            entity.Property(e => e.ReleasedDate)
                .HasColumnType("date")
                .HasColumnName("released_date");
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasKey(e => e.FilmId).HasName("PK__films__C036FF510AA3D684");

            entity.ToTable("films");

            entity.HasIndex(e => e.FilmName, "UQ__films__B13B3950DDD5A5A0").IsUnique();

            entity.Property(e => e.FilmId)
                .ValueGeneratedNever()
                .HasColumnName("filmId");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .HasColumnName("director");
            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .HasColumnName("film_name");
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .HasColumnName("genre");
            entity.Property(e => e.Imdb).HasColumnName("imdb");
            entity.Property(e => e.LeadActor)
                .HasMaxLength(50)
                .HasColumnName("lead_actor");
            entity.Property(e => e.ReleasedDate)
                .HasColumnType("date")
                .HasColumnName("released_date");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenreId).HasName("PK__genres__3C547682BDC72EED");

            entity.ToTable("genres");

            entity.Property(e => e.GenreId)
                .ValueGeneratedNever()
                .HasColumnName("genreId");
            entity.Property(e => e.GenreName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("genre_name");
        });

        modelBuilder.Entity<HorrorFilm>(entity =>
        {
            entity.HasKey(e => e.FilmId).HasName("PK__horror_f__C036FF5145406929");

            entity.ToTable("horror_films");

            entity.HasIndex(e => e.FilmName, "UQ__horror_f__B13B39503F2FD4A6").IsUnique();

            entity.Property(e => e.FilmId)
                .ValueGeneratedNever()
                .HasColumnName("filmId");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .HasColumnName("director");
            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .HasColumnName("film_name");
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .HasColumnName("genre");
            entity.Property(e => e.Imdb).HasColumnName("imdb");
            entity.Property(e => e.LeadActor)
                .HasMaxLength(50)
                .HasColumnName("lead_actor");
            entity.Property(e => e.ReleasedDate)
                .HasColumnType("date")
                .HasColumnName("released_date");
        });

        modelBuilder.Entity<RomcomFilm>(entity =>
        {
            entity.HasKey(e => e.FilmId).HasName("PK__romcom_f__C036FF516DD3B4C1");

            entity.ToTable("romcom_films");

            entity.HasIndex(e => e.FilmName, "UQ__romcom_f__B13B39505791810A").IsUnique();

            entity.Property(e => e.FilmId)
                .ValueGeneratedNever()
                .HasColumnName("filmId");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .HasColumnName("director");
            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .HasColumnName("film_name");
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .HasColumnName("genre");
            entity.Property(e => e.Imdb).HasColumnName("imdb");
            entity.Property(e => e.LeadActor)
                .HasMaxLength(50)
                .HasColumnName("lead_actor");
            entity.Property(e => e.ReleasedDate)
                .HasColumnType("date")
                .HasColumnName("released_date");
        });

        modelBuilder.Entity<ScifiFilm>(entity =>
        {
            entity.HasKey(e => e.FilmId).HasName("PK__scifi_fi__C036FF512537FE06");

            entity.ToTable("scifi_films");

            entity.HasIndex(e => e.FilmName, "UQ__scifi_fi__B13B39507DEE3692").IsUnique();

            entity.Property(e => e.FilmId)
                .ValueGeneratedNever()
                .HasColumnName("filmId");
            entity.Property(e => e.Director)
                .HasMaxLength(50)
                .HasColumnName("director");
            entity.Property(e => e.FilmName)
                .HasMaxLength(50)
                .HasColumnName("film_name");
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .HasColumnName("genre");
            entity.Property(e => e.Imdb).HasColumnName("imdb");
            entity.Property(e => e.LeadActor)
                .HasMaxLength(50)
                .HasColumnName("lead_actor");
            entity.Property(e => e.ReleasedDate)
                .HasColumnType("date")
                .HasColumnName("released_date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
