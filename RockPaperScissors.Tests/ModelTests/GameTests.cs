using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System.Collections.Generic;
using System;


namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Throw()
    {
      Game newGame = new Game("test");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GameConstructor_TestsInstanceOfGame_Throw()
    {
      Game newGame = new Game("test");
      Assert.AreEqual(newGame.Player1Throw, "test");
    }
  }
}
