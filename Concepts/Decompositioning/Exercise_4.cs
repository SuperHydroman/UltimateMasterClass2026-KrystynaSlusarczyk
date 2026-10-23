namespace Decompositioning;

public class Exercise_4 : Exercise
{
    protected override void Demonstrate()
    {
        var warrior = new Warrior();
        warrior.Attack();
        
        var mage = new Mage();
        mage.Attack();
        
        var assassin = new Assassin();
        assassin.Attack();
    }
}

public abstract class Character
{
    private const int BaseDamage = 5;
    protected virtual int BaseMultiplier { get; } = 1;
    private const int BaseStrength = 10;
    
    public int Attack()
    {
        int damage = CalculateClassSpecificDamage();
        damage += BaseDamage;

        Console.WriteLine($"Damage dealt: {damage}");

        return damage;
    }

    protected virtual int CalculateClassSpecificDamage()
        => BaseStrength * BaseMultiplier;
}

public class Warrior : Character
{
    protected override int BaseMultiplier { get; } = 2;
}

public class Mage : Character
{
    protected override int BaseMultiplier { get; } = 3;
}

public class Assassin : Character
{
    protected override  int BaseMultiplier { get; } = 2;
    private int FlatDamage { get; } = 15;

    protected override int CalculateClassSpecificDamage()
    {
        return base.CalculateClassSpecificDamage() + FlatDamage;
    }
}