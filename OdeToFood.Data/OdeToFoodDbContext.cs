using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {

        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options)
            :base(options)
        {

        }

        //These represent the kind of data, we going to use like storage.
        public  DbSet<Restaurant> Restaurants { get; set; }
    }
}
