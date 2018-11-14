using System;
using System.Collections.Generic;

namespace PingPongGame {

  public class Guess
    {
     static void Main()
    {
      Console.WriteLine("Input a number!");
      string input = Console.ReadLine();
      int realNumber = int.Parse(input);

      Pong numberInput = new Pong(realNumber);

      numberInput.PlayGame();
    }
  }
}
