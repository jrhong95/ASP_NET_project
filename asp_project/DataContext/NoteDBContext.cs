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
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=NoteDB;User Id=sa;Password=myPassword;");
            // mssql -> ssms 설치 후 sa 계정 비밀번호 설정 한 후 myPassword 변경할 것
            base.OnConfiguring(optionsBuilder);
        }


    }
}
