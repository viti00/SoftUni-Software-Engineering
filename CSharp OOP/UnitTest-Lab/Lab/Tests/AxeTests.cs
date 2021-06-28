using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private int attack = 5;
    private int durability = 6;
    private Axe axe;
    private Dummy dummy;
    [SetUp]
    public void SetUp()
    {
        axe = new Axe(attack, durability);
        dummy = new Dummy(150, 150);
    }

    [Test]
    public void When_AxeAttackAndDurabilityWasInicialized_ShoudBeSetCorrectly()
    {

        Assert.AreEqual(axe.AttackPoints, attack);

        Assert.AreEqual(axe.DurabilityPoints, durability);
    }

    [Test]
    public void When_InvokeAttackMethod_ShoudDecreaseAxeDurabilityWithOne()
    {
        axe.Attack(dummy);

        Assert.AreEqual(durability - 1, axe.DurabilityPoints);
    }

    [Test]
    public void When_AxeDurabilityIsNegativeOrZero_ShoudThrow()
    {
        Assert.That(() =>
        {
            for (int i = 0; i < 7; i++)
            {
                axe.Attack(dummy);
            }
        }, Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
    }
}