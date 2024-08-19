namespace DiceGame;

public static class Dice
{
    public static int Roll()
    {
        return new Random().Next(1, 7);
    }
}
