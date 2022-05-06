
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductShop.Data;
using ProductShop.DTOs.Export;
using ProductShop.DTOs.Import;
using ProductShop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static IMapper mapper;
        public static void Main(string[] args)
        {
            var contex = new ProductShopContext();
            //Reset(contex);

            //string userXmlAsString = File.ReadAllText("../../../Datasets/users.xml");
            //ImportUsers(contex, userXmlAsString);
            //string productXmlAsString = File.ReadAllText("../../../Datasets/products.xml");
            //ImportProducts(contex, productXmlAsString);
            //string categoryXmlAsString = File.ReadAllText("../../../Datasets/categories.xml");
            //ImportCategories(contex, categoryXmlAsString);
            //string categoryProductsXmlAsString = File.ReadAllText("../../../Datasets/categories-products.xml");
            //ImportCategoryProducts(contex, categoryProductsXmlAsString);

            Console.WriteLine(GetCategoriesByProductsCount(contex));
        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            XmlRootAttribute root = new XmlRootAttribute("Users");

            StringReader reader = new StringReader(inputXml);

            XmlSerializer serializer = new XmlSerializer(typeof(UserInputDto[]), root);

            var dtos = (UserInputDto[])serializer.Deserialize(reader);

            MapperInitializer();
            var mappedUsers = mapper.Map<IEnumerable<User>>(dtos);

            context.Users.AddRange(mappedUsers);
            context.SaveChanges();

            return $"Successfully imported {mappedUsers.Count()}";
        }

        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            XmlRootAttribute root = new XmlRootAttribute("Products");

            StringReader reader = new StringReader(inputXml);

            XmlSerializer serializer = new XmlSerializer(typeof(ProductsInputDto[]), root);

            var products = (ProductsInputDto[])serializer.Deserialize(reader);
            MapperInitializer();

            var mappedProducts = mapper.Map<IEnumerable<Product>>(products);

            context.Products.AddRange(mappedProducts);
            context.SaveChanges();

            return $"Successfully imported {mappedProducts.Count()}";
        }

        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            XmlRootAttribute root = new XmlRootAttribute("Categories");

            StringReader reader = new StringReader(inputXml);

            XmlSerializer serializer = new XmlSerializer(typeof(CategoryInputDto[]), root);

            var categories = (CategoryInputDto[])serializer.Deserialize(reader);
            MapperInitializer();

            var mappedCategories = mapper.Map<IEnumerable<Category>>(categories)
                                         .Where(c => c.Name != null);

            context.Categories.AddRange(mappedCategories);
            context.SaveChanges();

            return $"Successfully imported {mappedCategories.Count()}";

        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            XmlRootAttribute root = new XmlRootAttribute("CategoryProducts");

            StringReader reader = new StringReader(inputXml);

            XmlSerializer serializer = new XmlSerializer(typeof(CategoryProductInputDto[]), root);

            var categoryProducts = (CategoryProductInputDto[])serializer.Deserialize(reader);

            MapperInitializer();

            var mappedCategoryProducts = mapper.Map<IEnumerable<CategoryProduct>>(categoryProducts)
                                               .Where(cp => (cp.CategoryId <= 11 && cp.CategoryId >= 1) &&
                                               (cp.ProductId <= 200 && cp.ProductId >= 1))
                                               .ToList();

            context.CategoryProducts.AddRange(mappedCategoryProducts);
            context.SaveChanges();

            return $"Successfully imported {mappedCategoryProducts.Count()}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                                  .Where(p => p.Price >= 500 && p.Price <= 1000)
                                  .OrderBy(p => p.Price)
                                  .Take(10)
                                  .Select(p => new ProductsExportDto()
                                  {
                                      Name = p.Name,
                                      Price = p.Price.ToString(),
                                      Buyer = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                                  })
                                  .ToArray();

            StringBuilder sb = new StringBuilder();

            XmlRootAttribute root = new XmlRootAttribute("Products");

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            XmlSerializer serializer = new XmlSerializer(typeof(ProductsExportDto[]), root);

            StringWriter sw = new StringWriter(sb);

            serializer.Serialize(sw, products, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                               .Where(u => u.ProductsSold.Any(b => b.BuyerId != null))
                               .Select(u => new SoldProductsDto()
                               {
                                   FirstName = u.FirstName,
                                   LastName = u.LastName,
                                   SoldProducts = u.ProductsSold
                                                   .Where(b=> b.BuyerId != null)
                                                   .Select(p=> new ProductsDto() 
                                                   {
                                                       Name = p.Name,
                                                       Price = p.Price.ToString()
                                                   })
                                                   .ToArray()



                               })
                               .OrderBy(u => u.LastName)
                               .ThenBy(u => u.FirstName)
                               .Take(5)
                               .ToList();

            StringBuilder sb = new StringBuilder();

            StringWriter sw = new StringWriter(sb);

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            //var serializer = GenerateXmlSerializer("Users", typeof(SoldProductsDto[]));
            XmlRootAttribute root = new XmlRootAttribute("Users");
            XmlSerializer serializer = new XmlSerializer(typeof(List<SoldProductsDto>), root);
           

            serializer.Serialize(sw, users, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var sb = new StringBuilder();
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var categories = context.Categories
                .Select(x => new CategoryExportDto
                {
                    Name = x.Name,
                    Count = x.CategoryProducts.Count(),
                    AveragePrice = x.CategoryProducts.Average(p => p.Product.Price),
                    TotalRevenue = x.CategoryProducts.Sum(p => p.Product.Price)
                })
                .OrderByDescending(x => x.Count)
                .ThenBy(x => x.TotalRevenue)
                .ToList();

            var xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Categories";
            var serializer = new XmlSerializer(typeof(List<CategoryExportDto>), xRoot);


            serializer.Serialize(new StringWriter(sb), categories, namespaces);

            return sb.ToString().TrimEnd();

        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var sb = new StringBuilder();
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var users = context.Users
                .ToArray()
                   .Where(x => x.ProductsSold.Any(p => p.BuyerId != null))
                   .OrderByDescending(x => x.ProductsSold.Count)
                   .Select(x => new UserOutputDto
                   {
                       FirstName = x.FirstName,
                       LastName = x.LastName,
                       Age = x.Age,
                       SoldProducts = new ProductCountDto
                       {
                           Count = x.ProductsSold.Count(),
                           Products = x.ProductsSold.Select(s => new ProductOutputDto
                           {
                               Name = s.Name,
                               Price = s.Price

                           })
                           .OrderByDescending(s => s.Price)
                           .ToArray()
                       }
                   })
                   .ToArray();

            var result = new UserWithProductsDto
            {
                Count = users.Count(),
                Users = users.Take(10).ToArray()
            };


            var xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Users";
            var serializer = new XmlSerializer(typeof(UserWithProductsDto), xRoot);


            serializer.Serialize(new StringWriter(sb), result, namespaces);

            return sb.ToString().TrimEnd();

        }

        public static void MapperInitializer()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });

            mapper = config.CreateMapper();
        }

        public static void Reset(ProductShopContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public static XmlSerializer GenerateXmlSerializer(string rootAtribute, Type dtoType)
        {
            XmlRootAttribute root = new XmlRootAttribute(rootAtribute);
            XmlSerializer serializer = new XmlSerializer(dtoType, root);

            return serializer;
        }
    }
}