

using Microsoft.EntityFrameworkCore;
using Pixogram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.DataLayer.Dbcontext
{
    public class ContentDbContext : DbContext
    {
        public ContentDbContext(DbContextOptions<ContentDbContext> options)
       : base(options)
        {
        }

        public DbSet<Content> Content { get; set; }
        public DbSet<User> User { get; set; }
    }
}
