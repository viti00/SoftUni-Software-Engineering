using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private string make = "Opel";
        private string model = "Astra";
        private double fuelConsumption = 10;
        private double fuelCapacity = 100;
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);
        }

        [Test]
        [TestCase (null, "Model", 7, 100)]
        [TestCase("", "Model", 7, 100)]
        [TestCase("Make", "", 7, 100)]
        [TestCase("Make", null, 7, 100)]
        [TestCase("Make", "Model", 0, 100)]
        [TestCase("Make", "Model", -10, 100)]
        [TestCase("Make", "Model", 7, 0)]
        [TestCase("Make", "Model", 7, -10)]
        public void When_CarDataIsInvalid_ShoudThrowExeption(string make, string model, double fuelConsumption, double fuelCapacity)
        {
           
            Assert.Throws<ArgumentException>(() =>  new Car(make, model, fuelConsumption, fuelCapacity));
        }
        [Test]
        public void When_CarMakeIncialized_ShoudBeSetCorrecly()
        {
            Assert.AreEqual(car.Make, make);
        }
        [Test]
        public void When_CarModelIncialized_ShoudBeSetCorrecly()
        {
            Assert.AreEqual(car.Model, model);
        }
        [Test]
        public void When_CarFuelConsumptionInicialized_ShoudBeSetCorrectly()
        {
            Assert.AreEqual(car.FuelConsumption, fuelConsumption);
        }
        [Test]
        public void When_CarFuelCapacityInicialized_ShoudBeSetCorrectly()
        {
            Assert.AreEqual(car.FuelCapacity, fuelCapacity);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-100)]
        public void Refuel_ThrowExeption_WhenFuelIsZeroOrNegative(double fuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(fuel));
        }
        [Test]
        public void Refuel_ShoudIncreaseFuelAmount()
        {
            car.Refuel(car.FuelCapacity / 2);
            
            Assert.That(car.FuelAmount , Is.EqualTo(car.FuelCapacity / 2));
        }
        [Test]
        public void Refuel_IfFuelAmountIsBiggerThanCapacity_ShoudBeEqual()
        {
            car.Refuel(car.FuelCapacity * 1.2);

            Assert.That(car.FuelAmount, Is.EqualTo(car.FuelCapacity));

        }
        [Test]
        public void Drive_ThrowExeption_WhenNotEnoughtFuelAmount()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(100));
        }
        [Test]
        public void Drive_ShoudDecreaseFuelAmount()
        {
            double intialFuel = car.FuelCapacity;
            car.Refuel(intialFuel);
            car.Drive(100);

            Assert.That(car.FuelAmount, Is.EqualTo(intialFuel - fuelConsumption ));
        }
        [Test]
        public void Drive_ShoudDecreaseFuelAmountToZero_WhenRequiredFuelIsEqualtoFuelAmount()
        {
            
            car.Refuel(car.FuelCapacity);

            double distance = car.FuelCapacity * car.FuelConsumption;

            car.Drive(distance);

            Assert.That(car.FuelAmount, Is.EqualTo(0));
           
        }
    }
    
}