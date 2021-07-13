using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;
        [SetUp]
        public void Setup()
        {
            raceEntry = new RaceEntry();
        }

        [Test]
        public void Add_ThrowException_WhenDriverIsNull()
        {
            UnitDriver driver = null;
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(driver));
        }
        [Test]
        public void Add_ThrowException_WhenDriverIsAlreadyExist()
        {
            UnitDriver driver = new UnitDriver("Pesho", new UnitCar("Opel", 250, 350));
            raceEntry.AddDriver(driver);

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(driver));
        }
        [Test]
        public void Add_ShoudIncreaseCounter()
        {
            UnitDriver driver = new UnitDriver("gogi", new UnitCar("Ope2l", 241, 350));
            raceEntry.AddDriver(driver);
            UnitDriver driver2 = new UnitDriver("Pesho", new UnitCar("Op1el", 2, 35));
            raceEntry.AddDriver(driver2);
            UnitDriver driver3 = new UnitDriver("Peho", new UnitCar("Ope3l", 250, 3500));
            raceEntry.AddDriver(driver3);

            Assert.AreEqual(raceEntry.Counter, 3);
        }
        [Test]
        public void Add_ShoudReturnCorrectResult()
        {
            string expected = "Driver gogi added in race.";
            UnitDriver driver = new UnitDriver("gogi", new UnitCar("Ope2l", 241, 350));
            string result = raceEntry.AddDriver(driver);

            Assert.That(expected, Is.EquivalentTo(result));
        }
        [Test]
        public void Calculate_ThrowException_WhenParticipantsLestThanTwo()
        {
            UnitDriver driver = new UnitDriver("gogi", new UnitCar("Ope2l", 241, 350));
            raceEntry.AddDriver(driver);

            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }
        [Test]
        public void Calculate_ShoudReturnCorrectAverageHorsePower()
        {
            UnitDriver driver = new UnitDriver("gogi", new UnitCar("Ope2l", 241, 350));
            raceEntry.AddDriver(driver);
            UnitDriver driver2 = new UnitDriver("Pesho", new UnitCar("Op1el", 9, 35));
            raceEntry.AddDriver(driver2);
            double expected = 125;

            double result = raceEntry.CalculateAverageHorsePower();

            Assert.AreEqual(result, expected);
        }
    }
}