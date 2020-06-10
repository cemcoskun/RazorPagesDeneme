using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesDeneme.Models
{
    public class OkulContext : DbContext
    {
        //install-package Microsoft.EntityFrameworkCore
        //install-package Microsoft.EntityFrameworkCore.Tools
        //install-package Microsoft.EntityFrameworkCore.SqlServer
        //install-package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation

        public OkulContext(DbContextOptions<OkulContext> options): base(options)
        {

        }
        public DbSet<Kisi> Kisiler { get; set; }
    }
}
