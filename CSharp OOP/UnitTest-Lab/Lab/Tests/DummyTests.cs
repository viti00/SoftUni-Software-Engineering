using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private int health = 5000;
    private int exp = 5000;
    private Dummy dummy;
    private Dummy deadDummy;

    [SetUp]
    public void SetUp()
    {
        dummy = new Dummy(health, exp);
        deadDummy = new Dummy(-3, exp);
    }
    [Test]
    public void When_DummyHealthInicialised_ShoudBeSetCorrectly()
    {
        Assert.AreEqual(dummy.Health, health);
    }
    [Test]
    public void When_DummyTakeDamage_ShoudBeDecreaseHisHealth()
    {
        dummy.TakeAttack(12);

        Assert.AreEqual(health - 12, dummy.Health);
    }
    [Test]
    public void When_AttackedDeadDummy_ShoudTrhow()
    {
        Assert.That(() =>
        {
            deadDummy.TakeAttack(3);
        }, Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }
    [Test]
    public void When_DummyIsDead_ShoudGiveExperience()
    {
        Assert.AreEqual(deadDummy.GiveExperience(), exp);
    }
    [Test]
    public void When_DummyIsAllive_ShoudNotGiveExperience()
    {
        Assert.That(() =>
        {
            dummy.GiveExperience();
        }, Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
    [Test]
    public void When_HealthIsPositive_ShouldBeAlive()
    {
        Assert.That(dummy.IsDead(), Is.EqualTo(false));
    }

    [Test]
    public void When_HealthIsZero_ShouldBeDead()
    {
        dummy = new Dummy(0, exp);
        Assert.That(dummy.IsDead(), Is.EqualTo(true));
    }

    [Test]
    public void When_HealthIsNegative_ShouldBeDead()
    {
        Assert.That(deadDummy.IsDead(), Is.EqualTo(true));
    }
}

