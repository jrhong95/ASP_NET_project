using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.DataContext
{
    public class NoteDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
<<<<<<< HEAD
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=NoteDB;User Id=sa;Password=sa1234;");
=======
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=NoteDB;User Id=sa;Password=myPassword;");
            // myPassword = ssms -> sa's password
>>>>>>> 43d0b0bde52aa8330cbf920a334f25ee1883e825
            base.OnConfiguring(optionsBuilder);
        }


    }
}
