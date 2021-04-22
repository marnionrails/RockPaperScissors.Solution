using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Game 
  {
    public string PlayerThrow { get; }
    public string ComputerThrow { get; }

    public string Winner { get; }

    private string[] _possibleThrows = { "rock", "paper", "scissors" };
    public Game(string playerThrow){
      {
        PlayerThrow = playerThrow;
        ComputerThrow = GenerateRandomThrow();
        Winner = DetermineWinner();
      }
    }

    public string GetWinMessage()
    {
      string winMessage = "";

      if (Winner == "Draw")
      {
        winMessage = "It's a draw!";
      }
      else if (Winner == "Error!")
      {
        winMessage = "There was an error...";
      }
      else
      {
        winMessage = Winner + " is the winner!";
      }

      return winMessage;
    }
    
    private string GenerateRandomThrow()
    {
      Random rand = new Random();
      int index = rand.Next(_possibleThrows.Length);
      string randomThrow = _possibleThrows[index];
      return randomThrow;
    }

    private string DetermineWinner()
    {
      if ((PlayerThrow == "rock" && ComputerThrow == "scissors") || (PlayerThrow == "paper" && ComputerThrow == "rock") || (PlayerThrow == "scissors" && ComputerThrow == "paper")) 
      {
        return "Player 1";
      }      
      else if ((ComputerThrow == "rock" && PlayerThrow == "scissors") || (ComputerThrow == "paper" && PlayerThrow == "rock") || (ComputerThrow == "scissors" && PlayerThrow == "paper"))
      {
        return "Computer";   
      }
      else if (PlayerThrow == ComputerThrow)
      {
        return "Draw";
      }
      else {
        return "Error";
      }
    }  
  }
}