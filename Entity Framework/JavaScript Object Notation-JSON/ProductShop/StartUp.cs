using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductShop.Data;
using ProductShop.DTOs;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //string inputUser = File.ReadAllText("../../../Datasets/users.json");
            //string inputProduct = File.ReadAllText("../../../Datasets/products.json");
            //string inputCategory = File.ReadAllText("../../../Datasets/categories.json");
            //string inputCategoryProduct = File.ReadAllText("../../../Datasets/categories-products.json");

            //Console.WriteLine(ImportUsers(context, inputUser));
            //Console.WriteLine(ImportProducts(context, inputProduct));
            //Console.WriteLine(ImportCategories(context, inputCategory));
            //Console.WriteLine(ImportCategoryProducts(context, inputCategoryProduct));

            Console.WriteLine(GetUsersWithProducts(context));

        }
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<IEnumerable<UserInputDto>>(inputJson);
            var mapper = MapperInitializer();

            var mappedUsers = mapper.Map<IEnumerable<User>>(users);

            context.Users.AddRange(mappedUsers);
            context.SaveChanges();

            return $"Successfully imported {mappedUsers.Count()}";
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var products = JsonConvert.DeserializeObject<IEnumerable<ProductsInputDto>>(inputJson);
            var mapper = MapperInitializer();

            var mappedProducts = mapper.Map<IEnumerable<Product>>(products);

            context.Products.AddRange(mappedProducts);
            context.SaveChanges();

            return $"Successfully imported {mappedProducts.Count()}";
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<IEnumerable<CategoriesInputDto>>(inputJson)
                .Where(x => !string.IsNullOrEmpty(x.Name));
            var mapper = MapperInitializer();

            var mappedCategories = mapper.Map<IEnumerable<Category>>(categories);

            context.Categories.AddRange(mappedCategories);
            context.SaveChanges();

            return $"Successfully imported {mappedCategories.Count()}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var categoriesProducts = JsonConvert.DeserializeObject<IEnumerable<CategoriesProductsInputDto>>(inputJson);
            var mapper = MapperInitializer();

            var mappedCategoriesProducts = mapper.Map<IEnumerable<CategoryProduct>>(categoriesProducts);

            context.CategoryProducts.AddRange(mappedCategoriesProducts);
            context.SaveChanges();

            return $"Successfully imported {mappedCategoriesProducts.Count()}";

        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                                  .Where(p => p.Price >= 500 && p.Price <= 1000)
                                  .OrderBy(p => p.Price)
                                  .Select(p => new
                                  {
                                      Name = p.Name,
                                      Price = p.Price,
                                      Seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                                  })
                                  .ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var options = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string result = JsonConvert.SerializeObject(products, options);

            return result;

        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                               .Where(u => u.ProductsSold.Any(ps=> ps.Buyer != null))
                               .Select(u => new
                               {
                                   FirstName = u.FirstName,
                                   LastName = u.LastName,
                                   SoldProducts = u.ProductsSold
                                                   .Where(b=> b.Buyer != null)
                                                   .Select(ps => new
                                                   {
                                                       Name = ps.Name,
                                                       Price = ps.Price,
                                                       BuyerFirstName = ps.Buyer.FirstName,
                                                       BuyerLastName = ps.Buyer.LastName
                                                   })

                               })
                               .OrderBy(u => u.LastName)
                               .ThenBy(u => u.FirstName)
                               .ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string result = JsonConvert.SerializeObject(users, jsonSettings);

            return result;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                                    .OrderByDescending(c => c.CategoryProducts.Select(cp => cp.Product).Count())
                                    .Select(c => new
                                    {
                                        Category = c.Name,
                                        ProductsCount = c.CategoryProducts.Select(cp => cp.Product).Count(),
                                        AveragePrice = c.CategoryProducts.Average(cp => cp.Product.Price).ToString("f2"),
                                        TotalRevenue = c.CategoryProducts.Sum(cp => cp.Product.Price).ToString("f2")
                                    })

                                    .ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string result = JsonConvert.SerializeObject(categories, jsonSettings);

            return result;
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var usersDb = context.Users
                .Include(x => x.ProductsSold)
                .ToList()
                .Where(x => x.ProductsSold.Any(p => p.BuyerId != null))
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    age = x.Age,
                    soldProducts = new
                    {
                        count = x.ProductsSold.Where(p => p.BuyerId != null).Count(),
                        products = x.ProductsSold.Where(p => p.BuyerId != null)
                        .Select(y => new
                        {
                            name = y.Name,
                            price = y.Price
                        })
                    }
                }).ToArray()
                .OrderByDescending(x => x.soldProducts.count)
                .ToList();

            var usersOutput = new
            {
                usersCount = usersDb.Count,
                users = usersDb
            };
            

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver,
                NullValueHandling = NullValueHandling.Ignore
            };

            string jsonString = JsonConvert.SerializeObject(usersOutput, jsonSettings);
                            

            return jsonString;
        }

        private static IMapper MapperInitializer()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });

            var mapper = new Mapper(config);

            return mapper;
        }

        //private static JsonSerializerSettings JsonSettings()
        //{
        //    DefaultContractResolver contractResolver = new DefaultContractResolver
        //    {
        //        NamingStrategy = new CamelCaseNamingStrategy()
        //    };

        //    var jsonSettings = new JsonSerializerSettings
        //    {
        //        Formatting = Formatting.Indented,
        //        ContractResolver = contractResolver
        //    };

        //    return jsonSettings;

        //}
    }
}