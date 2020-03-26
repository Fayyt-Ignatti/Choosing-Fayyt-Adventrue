namespace Choosing_Fayyt
{
  using System;

  public class AsciiArt
  {
    public static void SplashScreen()
    {
      Console.WriteLine("\n");
      ColorText(@"               XXXXXXXXXXXXXXXXX                                               
       XXXXXXX~~~~~~~~~~~~~~~~~~XXXXXXX                                        
      X~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~X                                      
     XXXX~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~X                      ", ConsoleColor.DarkYellow); ColorText(@"XXXXXX        
   ", ConsoleColor.Red); ColorText("XX", ConsoleColor.Green); ColorText("====", ConsoleColor.Gray); ColorText("XXXXXXXXXXX~~~~~~~~XXXXXXXXXXXXXXXX                    ", ConsoleColor.DarkYellow); ColorText(@"XXoooooXX       
  ", ConsoleColor.Red); ColorText("OOOX", ConsoleColor.Green); ColorText("===", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.DarkMagenta); ColorText("====", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.Blue); ColorText("=", ConsoleColor.Gray); ColorText("XXXXXXXX", ConsoleColor.DarkYellow); ColorText("==", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.Cyan); ColorText("====", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.Green); ColorText("====", ConsoleColor.Gray); ColorText("XX                  ", ConsoleColor.DarkRed); ColorText(@"XoooooooX       
   ", ConsoleColor.Red); ColorText("XX", ConsoleColor.Green); ColorText("===", ConsoleColor.Gray); ColorText("XOOOX", ConsoleColor.DarkMagenta); ColorText("==", ConsoleColor.Gray); ColorText("XOOOX", ConsoleColor.Blue); ColorText("===", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.DarkRed); ColorText("===", ConsoleColor.Gray); ColorText("XOOOX", ConsoleColor.Cyan); ColorText("==", ConsoleColor.Gray); ColorText("XOOOX", ConsoleColor.Green); ColorText("==", ConsoleColor.Gray); ColorText("XOOO               ", ConsoleColor.DarkRed); ColorText("XXX", ConsoleColor.DarkGray); ColorText(@"XooooooX       
    ", ConsoleColor.Red); ColorText("XXXX", ConsoleColor.Yellow); ColorText("=", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.DarkMagenta); ColorText("====", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.Blue); ColorText("===", ConsoleColor.Gray); ColorText("XOOOX", ConsoleColor.DarkRed); ColorText("===", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.Cyan); ColorText("====", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.Green); ColorText("====", ConsoleColor.Gray); ColorText("XX             ", ConsoleColor.DarkRed); ColorText("XXXX|||", ConsoleColor.DarkGray); ColorText(@"XXXXXX        
     ", ConsoleColor.Red); ColorText("X===XXXXXXXXXXX", ConsoleColor.Yellow); ColorText("===", ConsoleColor.Gray); ColorText("XXX", ConsoleColor.DarkRed); ColorText("===", ConsoleColor.Gray); ColorText("XXXXXXXXXXXXXXX            ", ConsoleColor.Yellow); ColorText(@"XXX\\\\\\X             
     ", ConsoleColor.DarkGray); ColorText("X--------------XXXXXXXXX--------------", ConsoleColor.Yellow); ColorText("X          ", ConsoleColor.DarkBlue); ColorText(@"XXXX|||XXX                
     ", ConsoleColor.DarkGray); ColorText("X------", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("------------------", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("-------", ConsoleColor.Yellow); ColorText("XXX      ", ConsoleColor.DarkBlue); ColorText(@"XXXX||||XX                   
     ", ConsoleColor.DarkGray); ColorText("XX-----", ConsoleColor.Yellow); ColorText("[][]", ConsoleColor.DarkYellow); ColorText("--------------", ConsoleColor.Yellow); ColorText("[][]", ConsoleColor.DarkYellow); ColorText("-------", ConsoleColor.Yellow); ColorText("XXXX  ", ConsoleColor.DarkBlue); ColorText(@"XXXX||||XX                      
      ", ConsoleColor.DarkGray); ColorText("X-----", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("--", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("--", ConsoleColor.Yellow); ColorText("[][][]", ConsoleColor.DarkYellow); ColorText("--", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("--", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("-------", ConsoleColor.Yellow); ColorText("XXXXX", ConsoleColor.DarkBlue); ColorText(@"XX||||XX                         
      ", ConsoleColor.DarkGray); ColorText("X-------", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("----", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("--------", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("----------", ConsoleColor.Yellow); ColorText("XXXXX", ConsoleColor.DarkBlue); ColorText(@"XX|XX                           
      ", ConsoleColor.DarkGray); ColorText("XX--------", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("--", ConsoleColor.Yellow); ColorText("[][]", ConsoleColor.DarkYellow); ColorText("----", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("----------", ConsoleColor.Yellow); ColorText("X//", ConsoleColor.Gray); ColorText("XXXXX", ConsoleColor.DarkBlue); ColorText(@"XX                         
       ", ConsoleColor.DarkGray); ColorText("X------------", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("---------------", ConsoleColor.Yellow); ColorText("XXXX///", ConsoleColor.Gray); ColorText(@"XXXXX                             
        ", ConsoleColor.DarkBlue); ColorText("X-----------", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("------------", ConsoleColor.Yellow); ColorText("XXXX///////", ConsoleColor.Gray); ColorText(@"XXXXX                          
        ", ConsoleColor.DarkBlue); ColorText("XX----------", ConsoleColor.Yellow); ColorText("[]", ConsoleColor.DarkYellow); ColorText("---------", ConsoleColor.Yellow); ColorText("XXXX///////XX ", ConsoleColor.Gray); ColorText(@" XXXX                                 
         ", ConsoleColor.DarkBlue); ColorText("XX-------------------", ConsoleColor.Yellow); ColorText("XX//////XXXX", ConsoleColor.Gray); ColorText(@"     XXX                                     
          ", ConsoleColor.DarkBlue); ColorText("XXX-------------", ConsoleColor.Yellow); ColorText(@"XXX///////XXXX", ConsoleColor.Gray); ColorText(@"        X                                       
            ", ConsoleColor.DarkBlue); ColorText("XXX--------", ConsoleColor.Yellow); ColorText("XXXX//////XXXXX    ", ConsoleColor.Gray); ColorText(@"XXX   X                              
              ", ConsoleColor.Magenta); ColorText("XXXXXX", ConsoleColor.Yellow); ColorText("XXXX///////XXXX      ", ConsoleColor.Gray); ColorText(@"X   X  X     XX   XX   XX X X        
                  ", ConsoleColor.Magenta); ColorText("XXXX///////XX          ", ConsoleColor.Gray); ColorText(@"X      XXX  X  X X  X X     XXX   XX 
                ", ConsoleColor.Magenta); ColorText("XXX/////XXXXX            ", ConsoleColor.Gray); ColorText(@"X      X  X X  X X  X  X  X X  X X  X
             ", ConsoleColor.Magenta); ColorText("XXX/////XXX", ConsoleColor.Gray); ColorText("---X             ", ConsoleColor.Yellow); ColorText(@"X   X  X  X X  X X  X   X X X  X X  X
           ", ConsoleColor.Magenta); ColorText("XXX////XXX", ConsoleColor.Gray); ColorText("------X              ", ConsoleColor.Yellow); ColorText(@"XXX   X  X  XX   XX  XX  X X  X  XXX
         ", ConsoleColor.Magenta); ColorText("XX////XXXX", ConsoleColor.Gray); ColorText("X-------X                                                 ", ConsoleColor.Yellow); ColorText(@"X
      ", ConsoleColor.Magenta); ColorText("XXX////XX    ", ConsoleColor.Gray); ColorText("X-------X                                              ", ConsoleColor.Yellow); ColorText(@"X  X
    ", ConsoleColor.Magenta); ColorText("XX////XX       ", ConsoleColor.Gray); ColorText("X-------X                   ", ConsoleColor.Yellow); ColorText("XXXXXXX                     ", ConsoleColor.Green); ColorText(@"XXX
    ", ConsoleColor.Magenta); ColorText("XXX/           ", ConsoleColor.Gray); ColorText("X-------X                   ", ConsoleColor.Yellow); ColorText(@"X                               
                   ", ConsoleColor.Green); ColorText("X-------X                   ", ConsoleColor.Yellow); ColorText(@"X                               
                  ", ConsoleColor.Green); ColorText("XX-------XX                  ", ConsoleColor.Yellow); ColorText(@"XXXXX   XX                  X   
                ", ConsoleColor.Green); ColorText("XXX----------XXX               ", ConsoleColor.Yellow); ColorText(@"X         X  X   X X   X  XXXXX 
       ", ConsoleColor.Green); ColorText(" XXXXXXXXX--------------XXXXXXXXX       ", ConsoleColor.Yellow); ColorText(@"X      X X X X   X X   X    X   
       ", ConsoleColor.Green); ColorText("X--------------------------------X      ", ConsoleColor.Yellow); ColorText(@"X      X   X  X  X  X  X    X   
      ", ConsoleColor.Green); ColorText("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX     ", ConsoleColor.Yellow); ColorText(@"X       XX X   X X   X X    X   
                                                                X     X    XX  
          ", ConsoleColor.Green); ColorText("Randall Eckstein", ConsoleColor.White); ColorText(@"                                    XXX   XXX

", ConsoleColor.Green);

    }

    static void ColorText(string text, ConsoleColor color)
    {
      Console.ForegroundColor = color;
      Console.Write(text);
    }

  }
}
