using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryName="C#"},
                new Category(){CategoryName="Asp.net MVC"},
                new Category(){CategoryName="Asp.net WebForm"},
                new Category(){CategoryName="Windows Form"},
            };
            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();
            List<Blog> blogs = new List<Blog>()
            {
                new Blog(){Title="Title",Description="Description",Body="BodyBodyBodyBodyBodyBodyBodyBody",AddDate=DateTime.Now.AddDays(-10),IsActive=true,IsHome=true,ImageURL="",CategoryId=1},
                new Blog(){Title="Title",Description="Description",Body="BodyBodyBodyBodyBodyBodyBodyBody",AddDate=DateTime.Now.AddDays(-5),IsActive=true,IsHome=false,ImageURL="",CategoryId=2},
                new Blog(){Title="Title",Description="Description",Body="BodyBodyBodyBodyBodyBodyBodyBody",AddDate=DateTime.Now.AddDays(-16),IsActive=true,IsHome=true,ImageURL="",CategoryId=3},
                new Blog(){Title="Title",Description="Description",Body="BodyBodyBodyBodyBodyBodyBodyBody",AddDate=DateTime.Now.AddDays(-2),IsActive=true,IsHome=false,ImageURL="",CategoryId=4},

            };
            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}