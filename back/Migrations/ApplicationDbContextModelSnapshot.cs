using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TodoApi.Models;

namespace app.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("TodoApi.Models.TodoItem", b =>
                {
                    b.Property<string>("Key");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Name");

                    b.HasKey("Key");

                    b.ToTable("Todos");
                });
        }
    }
}
