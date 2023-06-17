using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week19.domain.Entities;

namespace week19.application.Common.Interface
{
    public interface IApplicationDBContext
    {
        DbSet<Employee> Employee { get; set; }
    }
}
