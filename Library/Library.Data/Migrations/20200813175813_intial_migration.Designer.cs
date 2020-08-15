using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Library.Data;

namespace Library.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20200813175813_intial_migration")]
    partial class intial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Data.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<short?>("IsActive");

                    b.Property<DateTime?>("LastUpdatedDate");

                    b.Property<string>("Phone");

                    b.Property<int?>("UpdatedBy");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Library.Data.Models.Users", b =>
                {
                    b.HasOne("Library.Data.Models.Users", "user1")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Library.Data.Models.Users", "user2")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });
        }
    }
}
