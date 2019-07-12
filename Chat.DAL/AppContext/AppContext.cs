using Chat.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DAL.AppContext
{
    public class AppContext:DbContext
    {
        public DbSet<ChatUser> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        public AppContext(DbContextOptions<AppContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
