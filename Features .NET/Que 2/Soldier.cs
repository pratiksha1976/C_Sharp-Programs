using System;

class Soldier
{
    private string _soldierNumber;
    private int _coins;

    public Soldier(string soldierNumber, int coins)
    {
        _soldierNumber = soldierNumber;
        _coins = coins;
    }

    public void Playgame(Func<Soldier, int, int> gameAction, int coins)
    {
        _coins = gameAction(this, coins);
    }

    public int CollectCoins(Soldier soldier, int coins)
    {
        return soldier._coins + coins;
    }

    public int AttackEnemies(Soldier soldier, int coins)
    {
        return soldier._coins - coins;
    }
    public override string ToString()
    {
        return  $"{_coins}";
    }
}
