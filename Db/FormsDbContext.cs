using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssaForms.Models;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace IssaForms.Db
{
    public class FormsDbContext : DbContext
    {
        public FormsDbContext()
            : base("Forms")
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseNpgsql("Server=10.10.0.69;Port=5000;Database=ISPDb;User Id=postgres;Password=PASSWORD;");

        //    optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Forms;Integrated Security=True");
        //    //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Forms"].ConnectionString);
        //}
        public DbSet<Colon> Colons { get; set; }
        public DbSet<Stomach> Stomaches { get; set; }
    }
}
