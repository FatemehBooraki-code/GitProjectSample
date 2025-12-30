using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GitProject.Models;

namespace GitProject.Data
{
    public class GitProjectContext : DbContext
    {
        public GitProjectContext (DbContextOptions<GitProjectContext> options)
            : base(options)
        {
        }

        public DbSet<GitProject.Models.Members> Members { get; set; } = default!;
    }
}
