using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yastoaRecode.Models.Login
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> opt) : base(opt) { }

        public DbSet<Login> Logins { get; set; }
    }
}
