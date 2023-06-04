using Domain.Models;          //add domain reference
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    //set public to use in under layers
    public class SocialDbContext : DbContext 
    {
        public SocialDbContext(DbContextOptions options)  :  base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; }
    }
}
