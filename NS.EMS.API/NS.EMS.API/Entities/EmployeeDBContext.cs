using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NS.EMS.API.Entities
{
    public partial class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext()
        {
        }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<TempEmp> TempEmp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-JURKOJIF\\SQLEXPRESS;Database=EMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("EMP");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.Property(e => e.Eid).HasColumnName("EID");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(150);
            });

            modelBuilder.Entity<TempEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempEMP");

                entity.Property(e => e.Edepartment).HasColumnName("EDepartment");

                entity.Property(e => e.EfirstName).HasColumnName("EFirstName");

                entity.Property(e => e.Eid).HasColumnName("EID");

                entity.Property(e => e.ElastName).HasColumnName("ELastName");

                entity.Property(e => e.Email).HasColumnName("EMail");

                entity.Property(e => e.Ephone)
                    .HasColumnName("EPhone")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
