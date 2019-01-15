using Microsoft.EntityFrameworkCore;

namespace DatabaseEF
{
    public class KanbanContext : DbContext
    {
        public KanbanContext(DbContextOptions<KanbanContext> options) : 
            base(options)
        { }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().HasOne(x => x.PersonOnIt).WithOne(y => y.Task).HasForeignKey<Task>(y => y.PersonOnItID).OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Person>().HasOne(x => x.Task).WithOne(y => y.PersonOnIt).HasForeignKey<Person>(y => y.TaskID).OnDelete(DeleteBehavior.ClientSetNull);
            //         var cascadeFKs = modelBuilder.Model.GetEntityTypes()
            //.SelectMany(t => t.GetForeignKeys())
            //  .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            //         foreach (var fk in cascadeFKs)
            //             fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }
    }
}
