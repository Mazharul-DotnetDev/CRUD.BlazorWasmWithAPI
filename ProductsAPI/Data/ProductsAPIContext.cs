using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Data
{
    public class ProductsAPIContext : DbContext
    {
        public ProductsAPIContext (DbContextOptions<ProductsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProductCategory> ProductCategory { get; set; } = default!;
        public DbSet<Product> Product {  get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProductsDB;Trusted_Connection=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory[]
            {
                new ProductCategory
                {
                    ProductCategoryID = 1,
                    Name = "Bikes"
                },
                new ProductCategory
                {
                    ProductCategoryID = 2,
                    Name = "Components"
                },
                new ProductCategory
                {
                    ProductCategoryID = 3,
                    Name = "Clothing"
                },
                new ProductCategory
                {
                    ProductCategoryID = 4,
                    Name = "Accessories"
                },
                new ProductCategory
                {
                    ProductCategoryID = 5,
                    Name = "Mountain Bikes"
                },
                new ProductCategory
                {
                    ProductCategoryID = 6,
                    Name = "Road Bikes"
                },
                new ProductCategory
                {
                    ProductCategoryID = 7,
                    Name = "Touring Bikes"
                },
                new ProductCategory
                {
                    ProductCategoryID = 8,
                    Name = "Handlebars"
                },
                new ProductCategory
                {
                    ProductCategoryID = 9,
                    Name = "Bottom Brackets"
                },
                new ProductCategory
                {
                    ProductCategoryID = 10,
                    Name = "Brakes"
                },
                new ProductCategory
                {
                    ProductCategoryID = 11,
                    Name = "Chains"
                },
                new ProductCategory
                {
                    ProductCategoryID = 12,
                    Name = "Cranksets"
                },
                new ProductCategory
                {
                    ProductCategoryID = 13,
                    Name = "Derailleurs"
                },
                new ProductCategory
                {
                    ProductCategoryID = 14,
                    Name = "Forks"
                },
                new ProductCategory
                {
                    ProductCategoryID = 15,
                    Name = "Headsets"
                },
                new ProductCategory
                {
                    ProductCategoryID = 16,
                    Name = "Mountain Frames"
                },
                new ProductCategory
                {
                    ProductCategoryID = 17,
                    Name = "Pedals"
                },
                new ProductCategory
                {
                    ProductCategoryID = 18,
                    Name = "Road Frames"
                },
                new ProductCategory
                {
                    ProductCategoryID = 19,
                    Name = "Saddles"
                },
                new ProductCategory
                {
                    ProductCategoryID = 20,
                    Name = "Touring Frames"
                },
                new ProductCategory
                {
                    ProductCategoryID = 21,
                    Name = "Wheels"
                },
                new ProductCategory
                {
                    ProductCategoryID = 22,
                    Name = "Bib-Shorts"
                },
                new ProductCategory
                {
                    ProductCategoryID = 23,
                    Name = "Caps"
                },
                new ProductCategory
                {
                    ProductCategoryID = 24,
                    Name = "Gloves"
                },
                new ProductCategory
                {
                    ProductCategoryID = 25,
                    Name = "Jerseys"
                },
                new ProductCategory
                {
                    ProductCategoryID = 26,
                    Name = "Shorts"
                },
                new ProductCategory
                {
                    ProductCategoryID = 27,
                    Name = "Socks"
                },
                new ProductCategory
                {
                    ProductCategoryID = 28,
                    Name = "Tights"
                },
                new ProductCategory
                {
                    ProductCategoryID = 29,
                    Name = "Vests"
                },
                new ProductCategory
                {
                    ProductCategoryID = 30,
                    Name = "Bike Racks"
                },
                new ProductCategory
                {
                    ProductCategoryID = 31,
                    Name = "Bike Stands"
                },
                new ProductCategory
                {
                    ProductCategoryID = 32,
                    Name = "Bottles and Cages"
                },
                new ProductCategory
                {
                    ProductCategoryID = 33,
                    Name = "Cleaners"
                },
                new ProductCategory
                {
                    ProductCategoryID = 34,
                    Name = "Fenders"
                },
                new ProductCategory
                {
                    ProductCategoryID = 35,
                    Name = "Helmets"
                },
                new ProductCategory
                {
                    ProductCategoryID = 36,
                    Name = "Hydration Packs"
                },
                new ProductCategory
                {
                    ProductCategoryID = 37,
                    Name = "Lights"
                },
                new ProductCategory
                {
                    ProductCategoryID = 38,
                    Name = "Locks"
                },
                new ProductCategory
                {
                    ProductCategoryID = 39,
                    Name = "Panniers"
                },
                new ProductCategory
                {
                    ProductCategoryID = 40,
                    Name = "Pumps"
                },
                new ProductCategory
                {
                    ProductCategoryID = 41,
                    Name = "Tires and Tubes"
                }
            });

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product
                {
                    ProductID = 1,
                    Name = "LL Road Frame - Red, 44",
                    ProductNumber = "FR-R38R-44",
                    Color = "Red",
                    StandardCost = 187.1571M,
                    ListPrice = 337.22M,
                    Size = 44,
                    Weight = 1052.33M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 2,
                    Name = "LL Road Frame - Red, 48",
                    ProductNumber = "FR-R38R-48",
                    Color = "Red",
                    StandardCost = 187.1571M,
                    ListPrice = 337.22M,
                    Size = 48,
                    Weight = 1070.47M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 3,
                    Name = "LL Road Frame - Red, 52",
                    ProductNumber = "FR-R38R-52",
                    Color = "Red",
                    StandardCost = 187.1571M,
                    ListPrice = 337.22M,
                    Size = 52,
                    Weight = 1088.62M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 4,
                    Name = "LL Road Frame - Red, 58",
                    ProductNumber = "FR-R38R-58",
                    Color = "Red",
                    StandardCost = 187.1571M,
                    ListPrice = 337.22M,
                    Size = 58,
                    Weight = 1115.83M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 5,
                    Name = "LL Road Frame - Red, 60",
                    ProductNumber = "FR-R38R-60",
                    Color = "Red",
                    StandardCost = 187.1571M,
                    ListPrice = 337.22M,
                    Size = 60,
                    Weight = 1124.9M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 6,
                    Name = "LL Road Frame - Red, 62",
                    ProductNumber = "FR-R38R-62",
                    Color = "Red",
                    StandardCost = 187.1571M,
                    ListPrice = 337.22M,
                    Size = 62,
                    Weight = 1133.98M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 7,
                    Name = "ML Road Frame - Red, 44",
                    ProductNumber = "FR-R72R-44",
                    Color = "Red",
                    StandardCost = 352.1394M,
                    ListPrice = 594.83M,
                    Size = 44,
                    Weight = 1006.97M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 8,
                    Name = "ML Road Frame - Red, 48",
                    ProductNumber = "FR-R72R-48",
                    Color = "Red",
                    StandardCost = 352.1394M,
                    ListPrice = 594.83M,
                    Size = 48,
                    Weight = 1025.11M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 9,
                    Name = "ML Road Frame - Red, 52",
                    ProductNumber = "FR-R72R-52",
                    Color = "Red",
                    StandardCost = 352.1394M,
                    ListPrice = 594.83M,
                    Size = 52,
                    Weight = 1043.26M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 10,
                    Name = "ML Road Frame - Red, 58",
                    ProductNumber = "FR-R72R-58",
                    Color = "Red",
                    StandardCost = 352.1394M,
                    ListPrice = 594.83M,
                    Size = 58,
                    Weight = 1070.47M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 11,
                    Name = "ML Road Frame - Red, 60",
                    ProductNumber = "FR-R72R-60",
                    Color = "Red",
                    StandardCost = 352.1394M,
                    ListPrice = 594.83M,
                    Size = 60,
                    Weight = 1079.54M,
                    ProductCategoryID = 18
                },
                new Product
                {
                    ProductID = 12,
                    Name = "HL Mountain Frame - Silver, 44",
                    ProductNumber = "FR-M94S-44",
                    Color = "Silver",
                    StandardCost = 706.811M,
                    ListPrice = 1364.5M,
                    Size = 44,
                    Weight = 1251.91M,
                    ProductCategoryID = 16
                },
                new Product
                {
                    ProductID = 13,
                    Name = "HL Mountain Frame - Silver, 48",
                    ProductNumber = "FR-M94S-52",
                    Color = "Silver",
                    StandardCost = 706.811M,
                    ListPrice = 1364.5M,
                    Size = 48,
                    Weight = 1270.05M,
                    ProductCategoryID = 16
                },
                new Product
                {
                    ProductID = 14,
                    Name = "HL Mountain Frame - Black, 44",
                    ProductNumber = "FR-M94B-44",
                    Color = "Black",
                    StandardCost = 699.0928M,
                    ListPrice = 1349.6M,
                    Size = 44,
                    Weight = 1251.91M,
                    ProductCategoryID = 16
                },
                new Product
                {
                    ProductID = 15,
                    Name = "HL Mountain Frame - Black, 48",
                    ProductNumber = "FR-M94B-48",
                    Color = "Black",
                    StandardCost = 699.0928M,
                    ListPrice = 1349.6M,
                    Size = 48,
                    Weight = 1270.05M,
                    ProductCategoryID = 16
                },
                new Product
                {
                    ProductID = 16,
                    Name = "Road-150 Red, 62",
                    ProductNumber = "BK-R93R-62",
                    Color = "Red",
                    StandardCost = 2171.2942M,
                    ListPrice = 3578.27M,
                    Size = 62,
                    Weight = 6803.85M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 17,
                    Name = "Road-150 Red, 44",
                    ProductNumber = "BK-R93R-44",
                    Color = "Red",
                    StandardCost = 2171.2942M,
                    ListPrice = 3578.27M,
                    Size = 44,
                    Weight = 6245.93M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 18,
                    Name = "Road-150 Red, 48",
                    ProductNumber = "BK-R93R-48",
                    Color = "Red",
                    StandardCost = 2171.2942M,
                    ListPrice = 3578.27M,
                    Size = 48,
                    Weight = 6409.23M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 19,
                    Name = "Road-150 Red, 52",
                    ProductNumber = "BK-R93R-52",
                    Color = "Red",
                    StandardCost = 2171.2942M,
                    ListPrice = 3578.27M,
                    Size = 52,
                    Weight = 6540.77M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 20,
                    Name = "Road-150 Red, 56",
                    ProductNumber = "BK-R93R-56",
                    Color = "Red",
                    StandardCost = 2171.2942M,
                    ListPrice = 3578.27M,
                    Size = 56,
                    Weight = 6658.7M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 21,
                    Name = "Road-450 Red, 58",
                    ProductNumber = "BK-R68R-58",
                    Color = "Red",
                    StandardCost = 884.7083M,
                    ListPrice = 1457.99M,
                    Size = 58,
                    Weight = 8069.37M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 22,
                    Name = "Road-450 Red, 60",
                    ProductNumber = "BK-R68R-60",
                    Color = "Red",
                    StandardCost = 884.7083M,
                    ListPrice = 1457.99M,
                    Size = 60,
                    Weight = 8119.26M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 23,
                    Name = "Road-450 Red, 44",
                    ProductNumber = "BK-R68R-44",
                    Color = "Red",
                    StandardCost = 884.7083M,
                    ListPrice = 1457.99M,
                    Size = 44,
                    Weight = 7606.7M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 24,
                    Name = "Road-450 Red, 48",
                    ProductNumber = "BK-R68R-48",
                    Color = "Red",
                    StandardCost = 884.7083M,
                    ListPrice = 1457.99M,
                    Size = 48,
                    Weight = 7770,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 25,
                    Name = "Road-450 Red, 52",
                    ProductNumber = "BK-R68R-52",
                    Color = "Red",
                    StandardCost = 884.7083M,
                    ListPrice = 1457.99M,
                    Size = 52,
                    Weight = 7901.54M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 26,
                    Name = "Road-650 Red, 58",
                    ProductNumber = "BK-R50R-58",
                    Color = "Red",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 58,
                    Weight = 8976.55M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 27,
                    Name = "Road-650 Red, 60",
                    ProductNumber = "BK-R50R-60",
                    Color = "Red",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 60,
                    Weight = 9026.44M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 28,
                    Name = "Road-650 Red, 62",
                    ProductNumber = "BK-R50R-62",
                    Color = "Red",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 62,
                    Weight = 9071.8M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 29,
                    Name = "Road-650 Red, 44",
                    ProductNumber = "BK-R50R-44",
                    Color = "Red",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 44,
                    Weight = 8513.88M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 30,
                    Name = "Road-650 Red, 48",
                    ProductNumber = "BK-R50R-48",
                    Color = "Red",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 48,
                    Weight = 8677.18M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 31,
                    Name = "Road-650 Red, 52",
                    ProductNumber = "BK-R50R-52",
                    Color = "Red",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 52,
                    Weight = 8808.72M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 32,
                    Name = "Road-650 Black, 58",
                    ProductNumber = "BK-R50B-58",
                    Color = "Black",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 58,
                    Weight = 8976.55M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 33,
                    Name = "Road-650 Black, 60",
                    ProductNumber = "BK-R50B-60",
                    Color = "Black",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 60,
                    Weight = 9026.44M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 34,
                    Name = "Road-650 Black, 62",
                    ProductNumber = "BK-R50B-62",
                    Color = "Black",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 62,
                    Weight = 9071.8M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 35,
                    Name = "Road-650 Black, 44",
                    ProductNumber = "BK-R50B-44",
                    Color = "Black",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 44,
                    Weight = 8513.88M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 36,
                    Name = "Road-650 Black, 48",
                    ProductNumber = "BK-R50B-48",
                    Color = "Black",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 48,
                    Weight = 8677.18M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 37,
                    Name = "Road-650 Black, 52",
                    ProductNumber = "BK-R50B-52",
                    Color = "Black",
                    StandardCost = 486.7066M,
                    ListPrice = 782.99M,
                    Size = 52,
                    Weight = 8808.72M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 38,
                    Name = "Mountain-100 Silver, 38",
                    ProductNumber = "BK-M82S-38",
                    Color = "Silver",
                    StandardCost = 1912.1544M,
                    ListPrice = 3399.99M,
                    Size = 38,
                    Weight = 9230.56M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 39,
                    Name = "Mountain-100 Silver, 42",
                    ProductNumber = "BK-M82S-42",
                    Color = "Silver",
                    StandardCost = 1912.1544M,
                    ListPrice = 3399.99M,
                    Size = 42,
                    Weight = 9421.06M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 40,
                    Name = "Mountain-100 Silver, 44",
                    ProductNumber = "BK-M82S-44",
                    Color = "Silver",
                    StandardCost = 1912.1544M,
                    ListPrice = 3399.99M,
                    Size = 44,
                    Weight = 9584.36M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 41,
                    Name = "Mountain-100 Silver, 48",
                    ProductNumber = "BK-M82S-48",
                    Color = "Silver",
                    StandardCost = 1912.1544M,
                    ListPrice = 3399.99M,
                    Size = 48,
                    Weight = 9715.9M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 42,
                    Name = "Mountain-100 Black, 38",
                    ProductNumber = "BK-M82B-38",
                    Color = "Black",
                    StandardCost = 1898.0944M,
                    ListPrice = 3374.99M,
                    Size = 38,
                    Weight = 9230.56M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 43,
                    Name = "Mountain-100 Black, 42",
                    ProductNumber = "BK-M82B-42",
                    Color = "Black",
                    StandardCost = 1898.0944M,
                    ListPrice = 3374.99M,
                    Size = 42,
                    Weight = 9421.06M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 44,
                    Name = "Mountain-100 Black, 44",
                    ProductNumber = "BK-M82B-44",
                    Color = "Black",
                    StandardCost = 1898.0944M,
                    ListPrice = 3374.99M,
                    Size = 44,
                    Weight = 9584.36M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 45,
                    Name = "Mountain-100 Black, 48",
                    ProductNumber = "BK-M82B-48",
                    Color = "Black",
                    StandardCost = 1898.0944M,
                    ListPrice = 3374.99M,
                    Size = 48,
                    Weight = 9715.9M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 46,
                    Name = "Mountain-300 Black, 38",
                    ProductNumber = "BK-M47B-38",
                    Color = "Black",
                    StandardCost = 598.4354M,
                    ListPrice = 1079.99M,
                    Size = 38,
                    Weight = 11498.51M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 47,
                    Name = "Mountain-300 Black, 40",
                    ProductNumber = "BK-M47B-40",
                    Color = "Black",
                    StandardCost = 598.4354M,
                    ListPrice = 1079.99M,
                    Size = 40,
                    Weight = 11689.01M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 48,
                    Name = "Mountain-300 Black, 44",
                    ProductNumber = "BK-M47B-44",
                    Color = "Black",
                    StandardCost = 598.4354M,
                    ListPrice = 1079.99M,
                    Size = 44,
                    Weight = 11852.31M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 49,
                    Name = "Mountain-300 Black, 48",
                    ProductNumber = "BK-M47B-48",
                    Color = "Black",
                    StandardCost = 598.4354M,
                    ListPrice = 1079.99M,
                    Size = 48,
                    Weight = 11983.85M,
                    ProductCategoryID = 5
                },
                new Product
                {
                    ProductID = 50,
                    Name = "Road-250 Red, 44",
                    ProductNumber = "BK-R89R-44",
                    Color = "Red",
                    StandardCost = 1518.7864M,
                    ListPrice = 2443.35M,
                    Size = 44,
                    Weight = 6699.52M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 51,
                    Name = "Road-250 Red, 48",
                    ProductNumber = "BK-R89R-48",
                    Color = "Red",
                    StandardCost = 1518.7864M,
                    ListPrice = 2443.35M,
                    Size = 48,
                    Weight = 6862.82M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 52,
                    Name = "Road-250 Red, 52",
                    ProductNumber = "BK-R89R-52",
                    Color = "Red",
                    StandardCost = 1518.7864M,
                    ListPrice = 2443.35M,
                    Size = 52,
                    Weight = 6994.36M,
                    ProductCategoryID = 6
                },
                new Product
                {
                    ProductID = 53,
                    Name = "ML Mountain Frame - Black, 38",
                    ProductNumber = "FR-M63B-38",
                    Color = "Black",
                    StandardCost = 185.8193M,
                    ListPrice = 348.76M,
                    Size = 38,
                    Weight = 1238.3M,
                    ProductCategoryID = 16
                },
                new Product
                {
                    ProductID = 54,
                    Name = "ML Mountain Frame - Black, 40",
                    ProductNumber = "FR-M63B-40",
                    Color = "Black",
                    StandardCost = 185.8193M,
                    ListPrice = 348.76M,
                    Size = 40,
                    Weight = 1256.44M,
                    ProductCategoryID = 16
                },
                new Product
                {
                    ProductID = 55,
                    Name = "ML Mountain Frame - Black, 44",
                    ProductNumber = "FR-M63B-44",
                    Color = "Black",
                    StandardCost = 185.8193M,
                    ListPrice = 348.76M,
                    Size = 44,
                    Weight = 1274.59M,
                    ProductCategoryID = 16
                },
                new Product
                {
                    ProductID = 56,
                    Name = "ML Mountain Frame - Black, 48",
                    ProductNumber = "FR-M63B-48",
                    Color = "Black",
                    StandardCost = 185.8193M,
                    ListPrice = 348.76M,
                    Size = 48,
                    Weight = 1292.73M,
                    ProductCategoryID = 16
                }
            });
            //base.OnModelCreating(modelBuilder);
        }
    }
}
