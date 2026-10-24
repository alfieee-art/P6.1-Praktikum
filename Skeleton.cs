using System;

public class Skeleton : Enemy
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} menembakkan panah tulang!");
    }
}