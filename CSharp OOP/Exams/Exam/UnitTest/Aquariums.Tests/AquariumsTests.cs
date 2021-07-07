namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    public class AquariumsTests
    {
        Aquarium aquarium;

        [SetUp]
        public void SetUp()
        {
            aquarium = new Aquarium("Pesho", 1);
        }
        [Test]
        public void ThrowException_NameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium("", 1));
        }
        [Test]
        public void ThrowException_CapacityIs0()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("Georgi", -1));
        }

        [Test]
        public void Add_ThrowException()
        {
            Fish fish = new Fish("Gogi");

            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish("Pepi")));
        }
        [Test]
        public void Add_AddCorectly()
        {
            Fish fish = new Fish("Gogi");
            aquarium.Add(fish);

            int expected = 1;
            Assert.AreEqual(expected, aquarium.Count);
        }
        [Test]
        public void Remove_ThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish("Pepi"));
        }
        [Test]
        public void Remove_RemoveCorectly()
        {
            Fish fish = new Fish("Gogi");
            aquarium.Add(fish);

            int expected = 0;

            aquarium.RemoveFish("Gogi");

            Assert.AreEqual(expected, aquarium.Count);
        }
        [Test]
        public void SellFish_ThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish("Pepi"));
        }
        [Test]
        public void SellFish_ReturnCorectly()
        {
            Fish fish = new Fish("Gogi");
            aquarium.Add(fish);

            Fish expected = fish;

            Fish result = aquarium.SellFish("Gogi");

            Assert.AreEqual(expected.Name, result.Name);
        }
        [Test]
        public void Report_ReturnCorectly()
        {
            Fish fish = new Fish("Gogi");
            aquarium.Add(fish);

            string expected = $"Fish available at Pesho: Gogi";

            string result = aquarium.Report();

            Assert.That(expected, Is.EquivalentTo(result));
        }
    }
}
