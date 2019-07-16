using System;
using System.Collections.Generic;

namespace higherLower
{
class Program
{
    public static void Main()
    {
    void StartGame(bool firstGame)
    {
    if (firstGame)
    {
        Console.WriteLine("Would you like to play the higher/lower game? (y/n)");
    }
    else
    {
        Console.WriteLine("Wanna play again? (y/n)");
    }
    string userStart = Console.ReadLine();
    if (userStart == "yes")
    {
        Player player = new Player();
        Gameplay(player);
    }
    else if (userStart == "no")
    {
        Console.WriteLine("oh. Alright");
        return;
    }
    else
    {
        Console.WriteLine("I don't understand.");
        StartGame(firstGame);
    }
}


    void Gameplay(Player player)
{
    Console.WriteLine("Think of a number between 1 and 100");
    int Guess = player.GetLowerBound() + (player.GetUpperBound() - player.GetLowerBound())/2;
    Console.WriteLine("is your number higher lower or correct " + Guess + "? (correct/ higher/ lower)");
    string response = Console.ReadLine();
    
    if (response.ToLower() == "higher")
    {
    player.SetLowerBound(Guess);
    Gameplay(player);
    }
else if (response.ToLower() == "lower")
{
    player.SetUpperBound(Guess);
    Gameplay(player);
}
else if (response.ToLower() == "correct")
{
    Console.WriteLine("hurray, I got it");
    StartGame(false);
}
}
}
}
}