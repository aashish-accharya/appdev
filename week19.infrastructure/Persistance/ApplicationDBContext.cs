using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week19.application.Common.Interface;
using week19.domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace week19.infrastructure.Persistance;

public class ApplicationDBContext: IdentityDbContext<IdentityUser, IdentityRole, string>, IApplicationDBContext
{
    private readonly IDateTime _dateTime;
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IDateTime dateTime) : base(options) { 
        _dateTime= dateTime;
    }

    public DbSet<Employee> Employee { get; set; }


}
