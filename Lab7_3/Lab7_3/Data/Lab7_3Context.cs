using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab7_3.Models;

namespace Lab7_3.Data
{
    public class Lab7_3Context : DbContext
    {
        public Lab7_3Context (DbContextOptions<Lab7_3Context> options)
            : base(options)
        {
        }

        public DbSet<Lab7_3.Models.Game> Game { get; set; }
    }
}
