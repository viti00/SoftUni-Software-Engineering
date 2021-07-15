using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bankVault;
        private Item item;
        Dictionary<string, Item> vaultCells;
        [SetUp]
        public void Setup()
        {
            bankVault = new BankVault();
            item = new Item("az", "3");
            vaultCells = new Dictionary<string, Item>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
            };
        }
        [Test]
        public void AddItem_ThrowException_WhenKeyDoesNotContains()
        {

            Assert.Throws<ArgumentException>(() => bankVault.AddItem("vito",item));
        }
        [Test]
        public void AddItem_ThrowException_WhenItemIsNull()
        {
            Item nullItem = null;

            Assert.Throws<ArgumentException>(() => bankVault.AddItem("az", nullItem));
        }
        [Test]
        public void AddItem_ReturnCorectOutput_WhenDataIsValid()
        {
            string result = $"Item:{item.ItemId} saved successfully!";

            string output = bankVault.AddItem("A1", item);

            Assert.That(result, Is.EquivalentTo(output));
        }
        [Test]
        public void AddItem_ThrowException_WhenItemAlreadyExist()
        {
            bankVault.AddItem("A1", item);
            Assert.Throws<InvalidOperationException>(() => bankVault.AddItem("A2", item));
        }
        [Test]
        public void Remove_ThrowException_WhenCellDoesNotExist()
        {

            Assert.Throws<ArgumentException>(() => bankVault.RemoveItem("vito", item));
        }
        [Test]
        public void Remove_ThrowException_WhenItemDoesNotContainsInCell()
        {

            Assert.Throws<ArgumentException>(() => bankVault.RemoveItem("A1", item));
        }
        [Test]
        public void Remove_ReturnCorrectOutput()
        {
            bankVault.AddItem("A1", item);
            string expected = $"Remove item:{item.ItemId} successfully!";

            string output = bankVault.RemoveItem("A1", item);

            Assert.That(output, Is.EquivalentTo(expected));
        }
    }
}