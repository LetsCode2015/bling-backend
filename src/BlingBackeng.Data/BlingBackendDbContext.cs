using BlingBackend.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace BlingBackeng.Data
{
    public class BlingBackendDbContext : DbContext
    {
        public IDbSet<Group> Groups { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<User> Users { get; set; }

        public IDbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasKey(g => g.Id)
                .Property(g => g.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Members);

            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id)
                .Property(g => g.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id)
                .Property(g => g.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Reminder>()
                .HasKey(r => r.Id)
                .Property(g => g.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Reminder>()
               .HasRequired(r => r.Task);

            modelBuilder.Entity<Task>()
                .HasKey(t => t.Id)
                .Property(g => g.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Task>()
                .HasRequired(t => t.Creator);

            modelBuilder.Entity<Task>()
                .HasOptional(t => t.Owner);

            modelBuilder.Entity<Task>()
                .HasRequired(t => t.Category);

            modelBuilder.Entity<Board>()
                .HasKey(b => b.Id)
                .Property(g => g.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Board>()
                .HasMany(b => b.Tasks)
                .WithRequired()
                .HasForeignKey(t => t.BoardId);

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BlingBackendDbContext>());
        }
    }
}