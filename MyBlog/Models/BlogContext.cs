﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class BlogContext:DbContext
    {
        public BlogContext() : base("BlogDB")
        {
            Database.SetInitializer(new BlogInitializer());
        }       
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}