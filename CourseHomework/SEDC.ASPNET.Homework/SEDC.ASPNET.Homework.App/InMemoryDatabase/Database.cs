using SEDC.ASPNET.Homework.App.Models.Domain;
using SEDC.ASPNET.Homework.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.ASPNET.Homework.App.InMemoryDatabase
{
    public static class Database
    {
        public static List<Product> Products;
        public static List<User> Users;

        static Database()
        {
            Products = new List<Product>
            {
                new Product()
                {
                    Id = 1,
                    Name = "Maddona's Discography",
                    Price = 50.00,
                    Category = ProductCategory.Music,
                    Description = "Queen of pop's discography."
                },
                new Product()
                {
                    Id = 2,
                    Name = "Michael Jackson's Discography",
                    Price = 80.00,
                    Category = ProductCategory.Music,
                    Description = "King of pop's discography."
                },
                new Product()
                {
                    Id = 3,
                    Name = "Beyonce's Discography",
                    Price = 38.00,
                    Category = ProductCategory.Music,
                    Description = "Beyonce's music discography."
                },
                new Product()
                {
                    Id = 4,
                    Name = "Crime and Punishment",
                    Price = 22.00,
                    Category = ProductCategory.EBooks,
                    Description = "The bestseller of a lifetime."
                },
                new Product()
                {
                    Id = 5,
                    Name = "To kill a mockingbird",
                    Price = 20.00,
                    Category = ProductCategory.EBooks,
                    Description = "Harper Lee's masterpiece."
                },
                new Product()
                {
                    Id = 6,
                    Name = "Murder on the Orient Express",
                    Price = 18.00,
                    Category = ProductCategory.EBooks,
                    Description = "Agatha Christie's bestseller."
                },
                new Product()
                {
                    Id = 7,
                    Name = "Inglorious Basterds",
                    Price = 10.00,
                    Category = ProductCategory.Movies,
                    Description = "A few Jewish soldiers are on an undercover mission to bring down the Nazi government and put an end to the war."
                },
                new Product()
                {
                    Id = 8,
                    Name = "Taxi Driver",
                    Price = 10.00,
                    Category = ProductCategory.Movies,
                    Description = "Travis, an ex-marine and Vietnam veteran, works as a taxi driver in New York City. "
                },
                new Product()
                {
                    Id = 9,
                    Name = "Pulp Fiction",
                    Price = 10.00,
                    Category = ProductCategory.Movies,
                    Description = "In the realm of underworld, a series of incidents intertwines the lives of two Los Angeles mobsters, a gangster's wife, a boxer and two small-time criminals."
                },
            };

            Users = new List<User>
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    Phone = 080012312345
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Jill",
                    LastName = "Wayne",
                    Address = "Jill Street",
                    Phone = 08006546345
                }
            };
        }
    }
}
