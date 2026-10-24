using System;

public class GameCharacter
{
    public string Name;
    public virtual void Attack()
    {
        Console.WriteLine($"{Name} menyerang dengan cara umum.");
    }

    public int Health = 100;
}