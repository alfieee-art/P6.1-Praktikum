using System;

public class Mage : GameCharacter
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} melontarkan fireball!");
    }
}