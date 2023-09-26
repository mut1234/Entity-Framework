using Microsoft.EntityFrameworkCore;

using Update_Bulk_Delete_Bulk.Models;

namespace Update_Bulk_Delete_Bulk.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        //---------------------------------


        //one to one
        public DbSet<Blog> Blogs { get; set; }

       //---------------------------------

       //many to many
       DbSet<Post> Posts { get; set; }
       DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>().HasData(
            new Employee { EmployeeId = 1, Name = "Ahmad", Email = "Ahmad3223@gmail.com" },
                new Employee { EmployeeId = 2, Name = "Ali", Email = "Ali3323@gmail.com" },
                new Employee { EmployeeId = 3, Name = "Yaser", Email = "Yaser4323@gmail.com" },
                new Employee { EmployeeId = 4, Name = "khaled", Email = "khaled4323@gmail.com" },
                new Employee { EmployeeId = 5, Name = "mhmod", Email = "mhmod4323@gmail.com" },
                new Employee { EmployeeId = 6, Name = "mustafa", Email = "mustafa4323@gmail.com" }
                );


            //one to one
            modelBuilder.Entity<Blog>()
                .HasOne(e => e.blogImage)
                .WithOne(e => e.Blog)
                .HasForeignKey<BlogImage>(e => e.BolgForeignKey);


            //many to many Fluent API

            modelBuilder.Entity<Post>()
              .HasMany(e => e.Tags)
              .WithMany(t => t.Posts)
              .UsingEntity(j => j.ToTable("PostTagsTest"));// name of join table



            //another way many to many



            //modelBuilder.Entity<Post>()
            //  .HasMany(e => e.Tags)
            //  .WithMany(t => t.Posts)
            //  .UsingEntity<PostTag>(

            //    j => j
            //    .HasOne(e => e.Tag)
            //    .WithMany(t => t.PostTags)
            //    .HasForeignKey(j => j.TagId),


            //    j => j
            //    .HasOne(e => e.Post)
            //    .WithMany(t => t.PostTags)
            //    .HasForeignKey(j => j.postId),


            //    j =>
            //    {
            //        j.Property(e => e.AddedOn).HasDefaultValue("GETDATE");
            //        j.HasKey(e => new { e.postId, e.TagId });
            //    }



            //   ) ;

        }



    }
}

