using System;

namespace PingPongGame
{

  class Pong
  {
    public int RealNumber;


    public Pong(int realNumber)
    {
      RealNumber = realNumber;
    }


    public void PlayGame()
    {
      for (int i = 1; i <= RealNumber; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("ping-pong");
        }
        else if (i % 3==0)
        {
          Console.WriteLine("ping");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("pong");
        }
        else
        {
          Console.WriteLine(i);
        }
      }

    }
  }
}
