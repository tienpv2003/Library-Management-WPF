using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibaryManagement.Models;

public partial class LibraryManagementContext : DbContext
{
    public LibraryManagementContext()
    {
    }

    public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookCategory> BookCategories { get; set; }

    public virtual DbSet<BorrowBook> BorrowBooks { get; set; }

    public virtual DbSet<Management> Managements { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-ASUS-F15\\SQLEXPRESS01;Initial Catalog=Library_Management; Trusted_Connection=SSPI;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__Author__70DAFC34E6008A61");

            entity.ToTable("Author");

            entity.Property(e => e.AuthorId).HasMaxLength(50);
            entity.Property(e => e.AuthorName).HasMaxLength(100);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Book__3DE0C20791015A65");

            entity.ToTable("Book");

            entity.Property(e => e.BookId).HasMaxLength(50);
            entity.Property(e => e.AuthorId).HasMaxLength(50);
            entity.Property(e => e.BookName).HasMaxLength(100);
            entity.Property(e => e.PublisherId).HasMaxLength(50);

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__Book__AuthorId__3F466844");

            entity.HasOne(d => d.Category).WithMany(p => p.Books)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Book__CategoryId__3E52440B");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books)
                .HasForeignKey(d => d.PublisherId)
                .HasConstraintName("FK__Book__PublisherI__403A8C7D");
        });

        modelBuilder.Entity<BookCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__BookCate__19093A0B5521BAEE");

            entity.ToTable("BookCategory");

            entity.Property(e => e.CategoryName).HasMaxLength(100);
        });

        modelBuilder.Entity<BorrowBook>(entity =>
        {
            entity.HasKey(e => e.BorrowId).HasName("PK__BorrowBo__4295F83F5200BCA2");

            entity.ToTable("BorrowBook");

            entity.Property(e => e.BookId).HasMaxLength(50);
            entity.Property(e => e.StudentId).HasMaxLength(50);

            entity.HasOne(d => d.Book).WithMany(p => p.BorrowBooks)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BorrowBoo__BookI__4316F928");

            entity.HasOne(d => d.Student).WithMany(p => p.BorrowBooks)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BorrowBoo__Stude__440B1D61");
        });

        modelBuilder.Entity<Management>(entity =>
        {
            entity.HasKey(e => e.ManagementId).HasName("PK__Manageme__D21F1B360549700C");

            entity.ToTable("Management");

            entity.Property(e => e.BookId).HasMaxLength(50);
            entity.Property(e => e.StudentId).HasMaxLength(50);

            entity.HasOne(d => d.Book).WithMany(p => p.Managements)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Managemen__BookI__46E78A0C");

            entity.HasOne(d => d.Borrow).WithMany(p => p.Managements)
                .HasForeignKey(d => d.BorrowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Managemen__Borro__48CFD27E");

            entity.HasOne(d => d.Student).WithMany(p => p.Managements)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Managemen__Stude__47DBAE45");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherId).HasName("PK__Publishe__4C657FAB3C05972E");

            entity.ToTable("Publisher");

            entity.Property(e => e.PublisherId).HasMaxLength(50);
            entity.Property(e => e.PublisherName).HasMaxLength(100);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE1A2B26B3C5");

            entity.ToTable("Role");

            entity.Property(e => e.RoleName).HasMaxLength(100);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B994D5EE3AC");

            entity.ToTable("Student");

            entity.Property(e => e.StudentId).HasMaxLength(50);
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.StudentName).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4CA9C5179E");

            entity.ToTable("User");

            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserPassword).HasMaxLength(100);

            entity.HasOne(d => d.Management).WithMany(p => p.Users)
                .HasForeignKey(d => d.ManagementId)
                .HasConstraintName("FK__User__Management__4E88ABD4");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User__RoleId__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
