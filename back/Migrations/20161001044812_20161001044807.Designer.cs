using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TodoApi.Models;

namespace app.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161001044812_20161001044807")]
    partial class _20161001044807
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
