using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot
{
    public class UserContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext()
        {
            Database.EnsureCreated();//Можно юзать EnsureCreatedAsync но в SQLite нет многопоточности поэтому смысла нет 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=SimpleBot.db");
        }
    }
}
