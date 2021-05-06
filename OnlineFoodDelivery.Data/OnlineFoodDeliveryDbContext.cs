using Microsoft.EntityFrameworkCore;
using OnlineFoodDelivery.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineFoodDelivery.Data
{
    public class OnlineFoodDeliveryDbContext : DbContext
    {
        public OnlineFoodDeliveryDbContext(DbContextOptions<OnlineFoodDeliveryDbContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
