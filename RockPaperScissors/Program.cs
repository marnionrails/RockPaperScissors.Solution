using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Choose rock, scissors or paper");
      string playerAnswer = System.Console.ReadLine();
      Game newGame = new Game(playerAnswer);
    }
  }
}