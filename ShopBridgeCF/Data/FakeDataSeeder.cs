using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopBridgeCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeCF.Data
{
    public class FakeDataSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new ItemContext(
                      serviceProvider
                      .GetRequiredService<DbContextOptions<ItemContext>>());

            if (context.Items.Any()) { return; }

            var items = new List<Item>
            {
                new Item{ Name = "Item1", Description = "Description1", Price = 50},
                new Item{ Name = "Item2", Description = "Description2", Price = 34},
                new Item{ Name = "Item3", Description = "Description3", Price = 56},
                new Item{ Name = "Item4", Description = "Description4", Price = 67},
                new Item{ Name = "Item5", Description = "Description5", Price = 77},
                new Item{ Name = "Item6", Description = "Description6", Price = 45},
                new Item{ Name = "Item7", Description = "Description7", Price = 77},
                new Item{ Name = "Item8", Description = "Description8", Price = 89},
                new Item{ Name = "Item9", Description = "Description9", Price = 13},
                new Item{ Name = "Item10", Description = "Description10", Price = 52},
                new Item{ Name = "Item11", Description = "Description11", Price = 63},
                new Item{ Name = "Item12", Description = "Description12", Price = 76},
            };

           context.Items.AddRange(items);

            context.SaveChanges();
        }
    }
}
