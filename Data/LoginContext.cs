using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDevLab.Data
{

    public class LoginContext : IdentityDbContext<LabUser>
    {
        public LoginContext(DbContextOptions<LoginContext> options)
            : base(options)
        {
        }
    }
}
