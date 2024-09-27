using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatBandish.Models;

namespace RecruitCatBandish.Data
{
    public class RecruitCatBandishContext : DbContext
    {
        public RecruitCatBandishContext (DbContextOptions<RecruitCatBandishContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatBandish.Models.BankAccount> BankAccount { get; set; } = default!;
        public DbSet<RecruitCatBandish.Models.AccountHolder> AccountHolder { get; set; } = default!;
        public DbSet<Candidate> Candidate { get; set; } = default!;
        public DbSet<Company> Company { get; set; } = default!;
        public DbSet<Industry> Industry { get; set; } = default!;
        public DbSet<JobTitle> JobTitle { get; set; } = default!;
    }
}
