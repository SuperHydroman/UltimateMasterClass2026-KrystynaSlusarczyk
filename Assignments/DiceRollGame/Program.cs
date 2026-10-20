using DiceRollGame;

int randomNumber = Dice.Roll();
const int chances = 3;
int guessCount = 0;
bool isGuessed;

Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
Console.WriteLine();

do
{
    string? input = Console.ReadLine() ?? "";
    isGuessed = InputValidator.Validate(input, randomNumber);
    
    guessCount++;
} while (guessCount < chances && !isGuessed);

if (isGuessed)
    Console.WriteLine("You win");
else Console.WriteLine("You lose");
