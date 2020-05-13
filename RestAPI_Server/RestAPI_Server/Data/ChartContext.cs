using Microsoft.EntityFrameworkCore;
using RestAPI_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_Server.Data
{
    public class ChartContext:DbContext
    {
        public ChartContext(DbContextOptions<ChartContext> options):base(options)
        {
        }

        public DbSet<Chart> Charts { get; set; }
    }
}
