namespace DiceGame;

public class DiceTerminal
{
    private int _diceRollResult;

    public DiceTerminal()
    {
        _diceRollResult = Dice.Roll();
        StartGame();
    }
    public void StartGame()
    {
        int tries = 3;
        int guess = 0;
        int tryCount = 0;

        do
        {
            Console.WriteLine($"Dice rolled. Guess what number it shows in {tries} tries.");
            var guessInput = Console.ReadLine();
            tryCount++;

            if (Int32.TryParse(guessInput, out guess) == false)
            {
                continue;
            }
            if (guess == _diceRollResult)
            {
                Console.WriteLine("You Win");
                break;
            }
            else
            {
                if (tryCount < tries)
                {
                    Console.WriteLine("Wrong number");
                    continue;
                }
                else
                {
                    Console.WriteLine("You lose");
                    break;
                }

            }
        }
        while (_diceRollResult != guess);


    }
}
