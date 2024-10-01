using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data
{
    public class EpidemiologyDBContext : DbContext
    {
        public EpidemiologyDBContext(DbContextOptions<EpidemiologyDBContext> options) : base(options)
        {
        }

        public DbSet<Individual> Individuals { get; set; }

    }
}