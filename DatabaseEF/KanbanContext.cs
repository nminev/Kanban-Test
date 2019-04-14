using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseEF
{
    public class KanbanContext : DbContext
    {
        public KanbanContext(DbContextOptions<KanbanContext> options) :
            base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasOne(x => x.PersonOnIt).WithOne(y => y.TodoItem)
                .HasForeignKey<TodoItem>(y => y.PersonOnItID).OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Person>().HasOne(x => x.TodoItem).WithOne(y => y.PersonOnIt)
                .HasForeignKey<Person>(y => y.TodoItemID).OnDelete(DeleteBehavior.ClientSetNull);
            //         var cascadeFKs = modelBuilder.Model.GetEntityTypes()
            //.SelectMany(t => t.GetForeignKeys())
            //  .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            //         foreach (var fk in cascadeFKs)
            //             fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }
    }
}