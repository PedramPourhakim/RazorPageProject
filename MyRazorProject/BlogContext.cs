using Microsoft.EntityFrameworkCore;
using MyRazorProject.Mapping;
using MyRazorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorProject
{
    public class BlogContext :DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public BlogContext(DbContextOptions<BlogContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var assembly = typeof(ArticleMapping).Assembly;
            //modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
