using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MemberRegistrationMVC.Models
{
    public class MemberRegistrationMVCContext : DbContext
    {
        public MemberRegistrationMVCContext (DbContextOptions<MemberRegistrationMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MemberRegistrationMVC.Models.Member> Member { get; set; }
    }
}
