using System;
using System.Collections.Generic;
using knowledge_hub.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace knowledge_hub.Data;

public partial class LibDbContext : DbContext
{
    public LibDbContext()
    {
    }

    public LibDbContext(DbContextOptions<LibDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Fine> Fines { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserFine> UserFines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=RAMEES\\SQLEXPRESS;Initial Catalog=knowledgehubdb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__Books__447D36EBEBEE9AC5");

            entity.HasMany(d => d.Categories).WithMany(p => p.BookIsbns)
                .UsingEntity<Dictionary<string, object>>(
                    "BookCategory",
                    r => r.HasOne<Category>().WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__BookCateg__Categ__5629CD9C"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BookIsbn")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__BookCateg__BookI__5535A963"),
                    j =>
                    {
                        j.HasKey("BookIsbn", "CategoryId").HasName("PK__BookCate__9F4A4AA99A685DE3");
                        j.ToTable("BookCategories");
                        j.IndexerProperty<string>("BookIsbn")
                            .HasMaxLength(13)
                            .IsUnicode(false)
                            .HasColumnName("BookISBN");
                        j.IndexerProperty<int>("CategoryId").HasColumnName("CategoryID");
                    });
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2B1E88D066");
        });

        modelBuilder.Entity<Fine>(entity =>
        {
            entity.HasKey(e => e.FineId).HasName("PK__Fines__9D4A9BCC6C55A0E8");

            entity.HasOne(d => d.User).WithMany(p => p.Fines).HasConstraintName("FK__Fines__UserID__59063A47");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Transact__55433A4B9EC006ED");

            entity.HasOne(d => d.BookIsbnNavigation).WithMany(p => p.Transactions).HasConstraintName("FK__Transacti__BookI__4F7CD00D");

            entity.HasOne(d => d.User).WithMany(p => p.Transactions).HasConstraintName("FK__Transacti__UserI__4E88ABD4");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACC9F6DC5C");
        });

        modelBuilder.Entity<UserFine>(entity =>
        {
            entity.HasKey(e => e.UserFineId).HasName("PK__UserFine__5D7C31EE6224C34D");

            entity.HasOne(d => d.Fine).WithMany(p => p.UserFines).HasConstraintName("FK__UserFines__FineI__5CD6CB2B");

            entity.HasOne(d => d.User).WithMany(p => p.UserFines).HasConstraintName("FK__UserFines__UserI__5BE2A6F2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
