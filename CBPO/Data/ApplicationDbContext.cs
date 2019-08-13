using System;
using System.Collections.Generic;
using System.Text;
using CBPO.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CBPO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Demographics> Demographics { get; set; }
        public DbSet<Checklist> Checklists { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
