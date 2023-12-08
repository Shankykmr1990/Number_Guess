Random random = new Random();
bool playAgain = true;
int min = 1;
int max = 10;
int guess;
int number;
int gusses;
String response;

while(playAgain)
{
    guess = 0;
    gusses = 0;
    response = "";
    number = random.Next(min, max + 1);

    while(guess!=number)
    {
        Console.Write("Guess a number between "+ min + " - " + max + " : ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: "+guess);
        if(guess>number)
        {
            Console.WriteLine(guess + " is to high!");
        }
        else if(guess<number)
        {
            Console.WriteLine(guess + " is to low!");
        }
        gusses++;
    }
    Console.WriteLine("Number: " + number);
    Console.WriteLine("You Win");
    Console.WriteLine("Guesses " + gusses);
    Console.WriteLine("Would you like to play again? (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();
    if(response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain= false;
    }
}
Console.WriteLine();
Console.WriteLine("Thanks for playing! ... I guess");
Console.ReadKey();