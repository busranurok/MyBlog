using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyPersonalBlog.Entities.Concrete;

namespace MyPersonalBlog.Concrete.EntityFramework
{
    public class EfBlogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Seminar> Seminars { get; set; }
        public DbSet<Liked> Likeds { get; set; }
        public DbSet<JobExperience> JobExperiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Displayed> Displayeds { get; set; }
        public DbSet<Disliked> Dislikeds { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<AdditionalInfo> AdditionalInfos { get; set; }

        //connectionstring stringi görsün diye yapılır
        public EfBlogContext() : base("Blog")
        {

        }
    }
}
