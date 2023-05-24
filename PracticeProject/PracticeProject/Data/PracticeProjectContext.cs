using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProject.Model;

namespace PracticeProject.Data
{
    public class PracticeProjectContext : DbContext
    {
        public PracticeProjectContext (DbContextOptions<PracticeProjectContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeProject.Model.User> User { get; set; } = default!;
    }
}
