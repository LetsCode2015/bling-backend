using BlingBackend.Model;
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
                .HasMany(g => g.Members);

            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Reminder>()
                .HasKey(r => r.Id)
                .HasRequired(r => r.Task);

            modelBuilder.Entity<Task>()
                .HasKey(t => t.Id)
                .HasRequired(t => t.Creator);

            modelBuilder.Entity<Task>()
                .HasOptional(t => t.Owner);

            modelBuilder.Entity<Task>()
                .HasRequired(t => t.Category);

            modelBuilder.Entity<Board>()
                .HasMany(b => b.Tasks);
        }
    }
}