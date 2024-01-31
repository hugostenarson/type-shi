public class Fighter
{
    public string name;
    public int hp = 100;
    public int weaponDamage = 10;

    public int Attack()
    {
        return Random.Shared.Next(weaponDamage);
    }

    public void IsDead()
    {
        if (hp <= 0)
        {
            Console.WriteLine($"{name} is dead!");
        }
    }
}