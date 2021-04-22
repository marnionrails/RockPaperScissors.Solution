using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {
      bool runGame = true;

      while (runGame)
      {
        Console.WriteLine("Choose rock, scissors or paper");
        string playerAnswer = System.Console.ReadLine();
        Game newGame = new Game(playerAnswer);

        Console.WriteLine("The computer threw " + newGame.ComputerThrow + "!");
        Console.WriteLine(newGame.GetWinMessage());

        if (newGame.Winner != "Draw") {
          runGame = false;
        }
      }
    }
  }
}