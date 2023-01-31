using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trilha_tech_test_api_tech.Models;

namespace trilha_tech_test_api_tech.Context
{
    public class SalerContext: DbContext
    {
        public SalerContext(DbContextOptions<SalerContext> options): base(options)
        {

        }

        public DbSet<Saler> Salers {get; set;}
    }
}
