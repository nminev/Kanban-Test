﻿// <auto-generated />
using DatabaseEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseEF.Migrations
{
    [DbContext(typeof(KanbanContext))]
    partial class KanbanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabaseEF.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("TodoItemID");

                    b.HasKey("ID");

                    b.HasIndex("TodoItemID")
                        .IsUnique();

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DatabaseEF.TodoItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("PersonOnItID");

                    b.Property<int>("State");

                    b.HasKey("ID");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("DatabaseEF.Person", b =>
                {
                    b.HasOne("DatabaseEF.TodoItem", "TodoItem")
                        .WithOne("PersonOnIt")
                        .HasForeignKey("DatabaseEF.Person", "TodoItemID");
                });
#pragma warning restore 612, 618
        }
    }
}
