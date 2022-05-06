using AutoMapper;
using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static IMapper mapper;
        public static void Main(string[] args)
        {
            var context = new CarDealerContext();
            //Reset(context);
            //string suppliersXmlAsString = File.ReadAllText("../../../Datasets/suppliers.xml");
            //Console.WriteLine(ImportSuppliers(context, suppliersXmlAsString));
            //string partsXmlAsString = File.ReadAllText("../../../Datasets/parts.xml");
            //Console.WriteLine(ImportParts(context, partsXmlAsString));
            //string carsXmlAsString = File.ReadAllText("../../../Datasets/cars.xml");
            //Console.WriteLine(ImportCars(context, carsXmlAsString));
            //string customersXmlAsString = File.ReadAllText("../../../Datasets/customers.xml");
            //Console.WriteLine(ImportCustomers(context, customersXmlAsString));
            //string salesXmlAsString = File.ReadAllText("../../../Datasets/sales.xml");
            //Console.WriteLine(ImportSales(context, salesXmlAsString));

            Console.WriteLine(GetSalesWithAppliedDiscount(context));
        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            StringReader reader = new StringReader(inputXml);

            var serializer = GenerateSerializer("Suppliers", typeof(SupplierInputModel[]));

            var suppliers = (SupplierInputModel[])serializer.Deserialize(reader);
            InitializeMapper();

            var mappedSuppliers = mapper.Map<IEnumerable<Supplier>>(suppliers);

            context.Suppliers.AddRange(mappedSuppliers);
            context.SaveChanges();

            return $"Successfully imported {mappedSuppliers.Count()}";
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            StringReader reader = new StringReader(inputXml);
            var serializer = GenerateSerializer("Parts", typeof(PartInputModel[]));

            InitializeMapper();

            var parts = (PartInputModel[])serializer.Deserialize(reader);

            var mappedParts = mapper.Map<IEnumerable<Part>>(parts)
                                    .Where(x=> x.SupplierId <= 31 && x.SupplierId >= 1)
                                    .ToArray();

            context.Parts.AddRange(mappedParts);
            context.SaveChanges();

            return $"Successfully imported {mappedParts.Count()}";
        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            StringReader reader = new StringReader(inputXml);

            var serializer = GenerateSerializer("Cars", typeof(CarInputModel[]));

            var deserializedCars = (CarInputModel[])serializer.Deserialize(reader);

            ICollection<Car> cars = new HashSet<Car>();
            

            foreach (var car in deserializedCars)
            {
                var currentCar = new Car
                {
                    Make = car.Make,
                    Model = car.Model,
                    TravelledDistance = car.TraveledDistance
                };
                ICollection<PartCar> partCars = new HashSet<PartCar>();
                foreach (var partId in car.Parts.Select(p=> p.PartId).Distinct())
                {
                    Part part = context.Parts
                                       .Find(partId);

                    if (part == null)
                    {
                        continue;
                    }

                    PartCar partCar = new PartCar
                    {
                        Car = currentCar,
                        Part = part
                    };

                    partCars.Add(partCar);
                }
                currentCar.PartCars = partCars;
                cars.Add(currentCar);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            StringReader reader = new StringReader(inputXml);

            var serializer = GenerateSerializer("Customers", typeof(CustomerInputModel[]));

            var customers = (CustomerInputModel[])serializer.Deserialize(reader);
            InitializeMapper();

            var mappedCustomers = mapper.Map<IEnumerable<Customer>>(customers);

            context.Customers.AddRange(mappedCustomers);
            context.SaveChanges();
            
            return $"Successfully imported {mappedCustomers.Count()}";
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            StringReader reader = new StringReader(inputXml);

            var serializer = GenerateSerializer("Sales", typeof(SalesInputModel[]));

            InitializeMapper();

            var sales = (SalesInputModel[])serializer.Deserialize(reader);

            var mappedSales = mapper.Map<IEnumerable<Sale>>(sales)
                                    .Where(x => x.CarId <= 36 && x.CarId >= 1)
                                    .ToArray();

            context.Sales.AddRange(mappedSales);
            context.SaveChanges();

            return $"Successfully imported {mappedSales.Count()}";
        }

        public static string GetCarsWithDistance(CarDealerContext context)
        {

            var sb = new StringBuilder();
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var cars = context.Cars
                .Where(x => x.TravelledDistance > 2000000)
                .Select(x => new CarOutputModel
                {
                    Make = x.Make,
                    Model = x.Model,
                    TravelledDistance = x.TravelledDistance,
                })
                .OrderBy(x => x.Make)
                .ThenBy(x => x.Model)
                .Take(10)
                .ToList();
            var xRoot = new XmlRootAttribute();
            xRoot.ElementName = "cars";
            var serializer = new XmlSerializer(typeof(List<CarOutputModel>), xRoot);


            serializer.Serialize(new StringWriter(sb), cars, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var cars = context.Cars
                              .Where(c => c.Make == "BMW")
                              .OrderBy(c => c.Model)
                              .ThenByDescending(c => c.TravelledDistance)
                              .Select(c => new CarFromMakeBmwOutputModel
                              {
                                  Id = c.Id.ToString(),
                                  Model = c.Model,
                                  TraveledDistance = c.TravelledDistance.ToString()
                              })
                              .ToArray();

            StringBuilder sb = new StringBuilder();

            using StringWriter writer = new StringWriter(sb);

            var serializer = GenerateSerializer("cars", typeof(CarFromMakeBmwOutputModel[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            serializer.Serialize(writer, cars, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var sb = new StringBuilder();
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            var suppliers = context.Suppliers
                .Where(x => x.IsImporter == false)
                .Select(x => new LocalSupplierOutputModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    PartCount = x.Parts.Count,
                })
                .ToList();

            var xRoot = new XmlRootAttribute();
            xRoot.ElementName = "suppliers";
            var serializer = new XmlSerializer(typeof(List<LocalSupplierOutputModel>), xRoot);


            serializer.Serialize(new StringWriter(sb), suppliers, namespaces);

            return sb.ToString().TrimEnd();

        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                              .OrderByDescending(c => c.TravelledDistance)
                              .ThenBy(c => c.Model)
                              .Take(5)
                              .Select(c => new CarWithPartsOutputModel
                              {
                                  Make = c.Make,
                                  Model = c.Model,
                                  TraveledDistance = c.TravelledDistance.ToString(),
                                  Parts = c.PartCars.OrderByDescending(p => p.Part.Price)
                                                    .Select(p => new PartsOutputModel
                                                    {
                                                        Name = p.Part.Name,
                                                        Price = p.Part.Price.ToString()
                                                    })
                                                    .ToArray()
                              })
                              .ToArray();

            StringBuilder sb = new StringBuilder();

            using StringWriter writer = new StringWriter(sb);

            var serializer = GenerateSerializer("cars", typeof(CarWithPartsOutputModel[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            serializer.Serialize(writer, cars, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                                   .ToArray()
                                   .Where(c => c.Sales.Count() > 0)
                                   .Select(c => new CustomerOutputModel
                                   {
                                       FullName = c.Name,
                                       BoughtCars = c.Sales.Count(),
                                       SpentMoney = c.Sales.Sum(s => s.Car.PartCars.Sum(p => p.Part.Price))
                                   })
                                   .OrderByDescending(c => c.SpentMoney)
                                   .ToArray();

            StringBuilder sb = new StringBuilder();

            using StringWriter writer = new StringWriter(sb);

            var serializer = GenerateSerializer("customers", typeof(CustomerOutputModel[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            serializer.Serialize(writer, customers, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales   
                               .Select(s => new SaleWithApliedDiscountOutputModel()
                                {
                                    Car = new CarOutputDto()
                                    {
                                        Make = s.Car.Make,
                                        Model = s.Car.Model,
                                        TravelledDistance = s.Car.TravelledDistance
                                    },
                                    Discount = s.Discount,
                                    CustomerName = s.Customer.Name,
                                    Price = s.Car.PartCars.Sum(x => x.Part.Price),
                                    PriceWithDiscount = s.Car.PartCars.Sum(x => x.Part.Price) - (s.Car.PartCars.Sum(x => x.Part.Price)) * s.Discount * 1.0m / 100.0m
                               })
                               .ToArray();

            StringBuilder sb = new StringBuilder();

            using StringWriter writer = new StringWriter(sb);

            var serializer = GenerateSerializer("sales", typeof(SaleWithApliedDiscountOutputModel[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            serializer.Serialize(writer, sales, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static void Reset(CarDealerContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

        }

        public static void InitializeMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarDealerProfile>();
            });

            mapper = config.CreateMapper();
        }

        public static XmlSerializer GenerateSerializer(string rootElement, Type dtoType)
        {
            XmlRootAttribute root = new XmlRootAttribute(rootElement);

            XmlSerializer serializer = new XmlSerializer(dtoType, root);

            return serializer;
        }
    }
}