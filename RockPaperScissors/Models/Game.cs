using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Game 
  {
    public string Player1Throw {get;set;}
    public Game(string playerThrow){
      {
        Player1Throw = playerThrow;
      }
    }
  }
}