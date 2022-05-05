using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO;
using CarDealer.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static IMapper mapper;

        public static void Main(string[] args)
        {
            var context = new CarDealerContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //string jsonSuppliersAsStrign = File.ReadAllText("../../../Datasets/suppliers.json");
            //string jsonPartsAsString = File.ReadAllText("../../../Datasets/parts.json");
            //string jsonCarsAsString = File.ReadAllText("../../../Datasets/cars.json");
            //string jsonCustomersAsString = File.ReadAllText("../../../Datasets/customers.json");
            //string jsonSalesAsString = File.ReadAllText("../../../Datasets/sales.json");

            //Console.WriteLine(ImportSuppliers(context, jsonSuppliersAsStrign));
            //Console.WriteLine(ImportParts(context, jsonPartsAsString));
            //Console.WriteLine(ImportCars(context, jsonCarsAsString));
            //Console.WriteLine(ImportCustomers(context, jsonCustomersAsString));
            //Console.WriteLine(ImportCustomers(context, jsonSalesAsString));

            Console.WriteLine(GetSalesWithAppliedDiscount(context));
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var suppliers = JsonConvert.DeserializeObject<IEnumerable<SupplierInputDto>>(inputJson);
            InitizalizeMapper();

            var mappedSuppliers = mapper.Map<IEnumerable<Supplier>>(suppliers);

            context.Suppliers.AddRange(mappedSuppliers);
            context.SaveChanges();


            return $"Successfully imported {mappedSuppliers.Count()}.";
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            InitizalizeMapper();
            var partsDto = JsonConvert.DeserializeObject<ICollection<PartInputDto>>(inputJson)
                .Where(x => x.SupplierId <= 31 && x.SupplierId >= 1)
                .ToList();

            var parts = mapper.Map<ICollection<Part>>(partsDto);

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count()}.";
        }

        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var carsDto = JsonConvert.DeserializeObject<ICollection<CarInputDto>>(inputJson);

            var cars = new List<Car>();

            foreach (var car in carsDto)
            {
                var currentCar = new Car
                {
                    Make = car.Make,
                    Model = car.Model,
                    TravelledDistance = car.TravelledDistance,
                };
                foreach (var carPartId in car.PartsId.Distinct())
                {
                    currentCar.PartCars.Add(new PartCar
                    {
                        Car = currentCar,
                        PartId = carPartId
                    });
                }
                cars.Add(currentCar);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}.";
        }

        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var customers = JsonConvert.DeserializeObject<IEnumerable<CustomerInputDto>>(inputJson);
            InitizalizeMapper();

            var mappedCustomers = mapper.Map<IEnumerable<Customer>>(customers);

            context.Customers.AddRange(mappedCustomers);
            context.SaveChanges();

            return $"Successfully imported {mappedCustomers.Count()}.";
        }

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var sales = JsonConvert.DeserializeObject<IEnumerable<SalesInputDto>>(inputJson);
            InitizalizeMapper();

            var mappedSales = mapper.Map<IEnumerable<Sale>>(sales);

            context.Sales.AddRange(mappedSales);
            context.SaveChanges();

            return $"Successfully imported {mappedSales.Count()}.";
        }

        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(x => x.BirthDate)
                .ThenBy(x => x.IsYoungDriver)
                .Select(x => new
                {
                    x.Name,
                    BirthDate = $"{x.BirthDate.ToString("dd/MM/yyyy")}",
                    x.IsYoungDriver
                })
                .ToList();

            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new DefaultNamingStrategy()
            };

            var options = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            var customersJson = JsonConvert.SerializeObject(customers, options);

            return customersJson;
        }

        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                              .Where(c => c.Make == "Toyota")
                              .OrderBy(c => c.Model)
                              .ThenByDescending(c => c.TravelledDistance)
                              .Select(c => new
                              {
                                  c.Id,
                                  c.Make,
                                  c.Model,
                                  c.TravelledDistance
                              })
                              .ToList();
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new DefaultNamingStrategy()
            };

            var options = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            var result = JsonConvert.SerializeObject(cars, options);

            return result;

        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                                   .Where(s => s.IsImporter == false)
                                   .Select(s => new
                                   {
                                       s.Id,
                                       s.Name,
                                       PartsCount = s.Parts.Count()
                                   })
                                   .ToList();
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new DefaultNamingStrategy()
            };

            var options = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            var result = JsonConvert.SerializeObject(suppliers, options);

            return result;

        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(x => new
                {
                    car = new { Make = x.Make, Model = x.Model, TravelledDistance = x.TravelledDistance },
                    parts = x.PartCars.Select(y => new
                    {
                        Name = y.Part.Name,
                        Price = $"{y.Part.Price:F2}"
                    })
                })
                .ToList();
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new DefaultNamingStrategy()
            };

            var options = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            var result = JsonConvert.SerializeObject(cars, options);

            return result;
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                                   .Where(c => c.Sales.Count() > 0)
                                   .Select(c => new
                                   {
                                       fullName = c.Name,
                                       boughtCars = c.Sales.Count(),
                                       spentMoney = c.Sales.Sum(s => s.Car.PartCars.Sum(p => p.Part.Price))
                                   })
                                   .OrderByDescending(c => c.spentMoney)
                                   .ThenByDescending(c => c.boughtCars)
                                   .ToList();

            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var options = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            var result = JsonConvert.SerializeObject(customers, options);

            return result;
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                               .Take(10)
                               .Select(s => new
                               {
                                   car = new
                                   {
                                       Make = s.Car.Make,
                                       Model = s.Car.Model,
                                       TravelledDistance = s.Car.TravelledDistance

                                   },
                                   customerName = s.Customer.Name,
                                   Discount = s.Discount.ToString("f2"),
                                   price = (s.Car.Sales.Sum(y => y.Car.PartCars.Sum(p => p.Part.Price))).ToString("f2"),
                                   priceWithDiscount =
                                   (s.Car.Sales.Sum(y => y.Car.PartCars.Sum(z => z.Part.Price)) - s.Car.Sales.Sum(y => y.Car.PartCars.Sum(z => z.Part.Price)) * (s.Discount / 100)).ToString("f2")
                               })
                               .ToList();
            string result = JsonConvert.SerializeObject(sales, Formatting.Indented);
            return result;
        }

        public static void InitizalizeMapper()
        {
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<CarDealerProfile>();
            });

            mapper = config.CreateMapper();
        }
    }
}