using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspNetMySQL.Models
{
    public partial class quizContext : DbContext
    {
        public quizContext()
        {
        }

        public quizContext(DbContextOptions<quizContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Options> Options { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Rank> Rank { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAnswer> UserAnswer { get; set; }

        // Unable to generate entity type for table 'feedback'. Please see the warning messages.
        // Unable to generate entity type for table 'quiz'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
             //   optionsBuilder.UseMySql("server=localhost;userid=root;password=root;database=quiz;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("answer");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Ansid)
                    .IsRequired()
                    .HasColumnName("ansid")
                    .HasColumnType("text");

                entity.Property(e => e.Qid)
                    .IsRequired()
                    .HasColumnName("qid")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("history");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Correct)
                    .HasColumnName("correct")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("text");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ScoreUpdated)
                    .IsRequired()
                    .HasColumnName("score_updated")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("bigint(50)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Wrong)
                    .HasColumnName("wrong")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Options>(entity =>
            {
                entity.ToTable("options");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Option)
                    .IsRequired()
                    .HasColumnName("option")
                    .HasColumnType("varchar(5000)");

                entity.Property(e => e.Optionid)
                    .IsRequired()
                    .HasColumnName("optionid")
                    .HasColumnType("text");

                entity.Property(e => e.Qid)
                    .IsRequired()
                    .HasColumnName("qid")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.ToTable("questions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Choice)
                    .HasColumnName("choice")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("text");

                entity.Property(e => e.Qid)
                    .IsRequired()
                    .HasColumnName("qid")
                    .HasColumnType("text");

                entity.Property(e => e.Qns)
                    .IsRequired()
                    .HasColumnName("qns")
                    .HasColumnType("text");

                entity.Property(e => e.Sn)
                    .HasColumnName("sn")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.ToTable("rank");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PRIMARY");

                entity.ToTable("user");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnName("branch")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(100)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Phno)
                    .HasColumnName("phno")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Rollno)
                    .IsRequired()
                    .HasColumnName("rollno")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<UserAnswer>(entity =>
            {
                entity.ToTable("user_answer");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(100)");

                entity.Property(e => e.Ans)
                    .IsRequired()
                    .HasColumnName("ans")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Correctans)
                    .IsRequired()
                    .HasColumnName("correctans")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Qid)
                    .IsRequired()
                    .HasColumnName("qid")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}
