/* 

 * Choosing Fayyt
 * by Randall Eckstein
 * Created March 17, 2020
 *  Yes, it's Saint Patrick's Day.  No, I'm not wearing any green.
 *  It's the year of the coronavirus.  Go figure.
 *  
 *  This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

namespace Choosing_Fayyt
{
  using System;
  class Program
  {

    static void Main()
    {
      Console.SetWindowSize(100, 42);
      Console.Title = "Choosing Fayyt!";

      AsciiArt.SplashScreen();
      Console.ReadKey();
      Game.StartGame();
      Console.ReadKey();

    }

    class Item { }

  }
  //internal struct ColoredString
  //{
  //  public ColoredString(string text, ConsoleColor color)
  //  {
  //    this.text = text;
  //    this.color = color;
  //  }

  //  public string text { get; }
  //  public ConsoleColor color { get; }
  //}

}

