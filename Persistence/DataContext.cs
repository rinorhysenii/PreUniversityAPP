using Domain;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public partial class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Parent> Parents { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<StudentGroup> StudentGroups { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__Student__Id");

                entity.Property(e => e.StudentNumber)
                .IsRequired()
                .HasMaxLength(20);

                entity.Property(e => e.RoleId)
                .IsRequired();
            });

            modelBuilder.Entity<Student>()
            .HasOne(p => p.Parent)
            .WithMany()
            .HasForeignKey(p => p.ParentId)
            .HasConstraintName("FK_Parent_ParentId");

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__Teacher__Id");

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

                entity.Property(e => e.Grade)
                .HasMaxLength(20);

                entity.Property(e => e.RoleId)
                .IsRequired();
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__Parent__Id");

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

                entity.Property(e => e.RoleId)
                .IsRequired();
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__Course__Id");

                entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(500);
            });

            modelBuilder.Entity<Course>()
            .HasOne(p => p.Teacher)
            .WithMany()
            .HasForeignKey(p => p.TeacherId)
            .HasConstraintName("FK_Teacher_TeacherId");

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__Group__Id");

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(500);
            });

            modelBuilder.Entity<StudentGroup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__StudentGroup__Id");
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__StudentCourse__Id");
            });

            modelBuilder.Entity<StudentGroup>()
             .HasOne(p => p.Group)
             .WithMany()
             .HasForeignKey(p => p.GroupId)
             .HasConstraintName("FK_Group_GroupId");

            modelBuilder.Entity<StudentGroup>()
            .HasOne(p => p.Student)
            .WithMany()
            .HasForeignKey(p => p.StudentId)
            .HasConstraintName("FK_StudentGroup_StudentId");

            modelBuilder.Entity<StudentCourse>()
            .HasOne(p => p.Course)
            .WithMany()
            .HasForeignKey(p => p.CourseId)
            .HasConstraintName("FK_Course_CourseId");

            modelBuilder.Entity<StudentCourse>()
            .HasOne(p => p.Student)
            .WithMany()
            .HasForeignKey(p => p.StudentId)
            .HasConstraintName("FK_StudentCourse_StudentId");

            base.OnModelCreating(modelBuilder);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}