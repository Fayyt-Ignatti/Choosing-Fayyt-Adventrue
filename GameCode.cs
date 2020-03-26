namespace Choosing_Fayyt
{
  using System;
  using System.Threading;
  using System.Collections.Generic;

  public static class Game  
  {
    //Character Name
    static string CharacterName;
    static string gender;
    static int morality;
    static readonly int Scenarios = 5;
    static bool school = false;
    static List<string> PlayerInventory = new List<string>();



    //print out title and overview
    public static void StartGame()
    {
      Console.Title = "Choosing Fayyt!";
      Console.Clear(); Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\n\n\n\n\n\n\n\t\t\t\t" +
        "-------------------------------------------");
      Dialog("\t\t\t\t" +
        "Choosing Fayyt!\n", ConsoleColor.Magenta);
      Dialog("\t\t\t\t\t" +
        " a relatively safe adventure game\n", ConsoleColor.DarkGreen);
      Console.WriteLine("\t\t\t\t" +
        "-------------------------------------------\n\n\n");
      Console.ReadKey();
      Console.Clear();
      TwoToneDialog(ConsoleColor.White, "\n\n\n\n\n\n\n\n\n\n\nPlay through this text adventure, and see if you can get all four of the ", ConsoleColor.Green, "\"key item sets\"", ".\n" +
        "\t(Not all sets can be achieved in one play-through.)\n\n\n\n");
      Dialog("\t\t\t Play multiple times, and find out which ending you think is best!", ConsoleColor.Blue);
      Console.ReadKey();
      Console.Clear();
      NameCharacter();
      Choice();
      EndGame();

    }

    //ask player for a name and save it
    static void NameCharacter()
    {
      int NoNameCounter = 0;
      int NoGenderCounter = 0;
      Console.WriteLine("\nEnter a name for your character:"); Console.ForegroundColor = ConsoleColor.Cyan;
      CharacterName = Console.ReadLine(); Console.ForegroundColor = ConsoleColor.White;
      while (CharacterName == "")
      {
        NoNameCounter++;
        if (NoNameCounter == 4)
        {
          var rand = new Random();
          int RandomIndex = rand.Next(Story.GenderNeutralNames.Length);
          var RandomName = Story.GenderNeutralNames[RandomIndex].ToString();
          Console.Clear();
          TwoToneDialog(ConsoleColor.Cyan, "Oh, great indecisive one, I shall choose for you.\n" +
            "Your name will be ", ConsoleColor.DarkYellow, RandomName, ".  Go forth, and prosper.\n\n");
          CharacterName = RandomName;
          PlayerInventory.Add(Story.RawInventory[32]);
          PlayerInventory.Add(Story.RawInventory[33]);
          break;
        }
        Dialog("\nEvery adventurer needs a Nom-de-Plume, as it were.  \n\tJust give us a wee name to put in our ballads, yeah?\n\n" +
          "Please enter a name for your character:\n", ConsoleColor.Yellow); Console.ForegroundColor = ConsoleColor.Cyan;
        CharacterName = Console.ReadLine(); Console.ForegroundColor = ConsoleColor.White;
      }
      Console.WriteLine("\nIs your character male or female?"); Console.ForegroundColor = ConsoleColor.Cyan;
      gender = Console.ReadLine().ToLower(); Console.ForegroundColor = ConsoleColor.White;
      while (gender != "male" || gender != "female")
      {
        if (gender == "male")
        {
          break;
        }
        else if (gender == "female")
        {
          break;
        }
        else
        {
          NoGenderCounter++;
          if (NoGenderCounter == 4)
          {
            Console.Clear();
            TwoToneDialog(ConsoleColor.Cyan, "" +
              "Alright, alright.  I see how it is.  With our sincerest best wishes, \n" +
              "we bestow upon you the gender of ", ConsoleColor.DarkYellow, "63nd3rl355", ".  Be bold, Serah!\n\n");
            gender = "non-binary";
            PlayerInventory.Add(Story.RawInventory[34]);
            PlayerInventory.Add(Story.RawInventory[35]);
            break;

          }
          Console.WriteLine("\n" +
            "The developer deeply regrets that in the world of CHOOSING FAYYT \n" +
            "gender is strictly binary.  Although the developer wishes to \n" +
            "acknowledge the diverse ways that people identify and emote, there are \n" +
            "sadly only two identifications of gender in this game.\n\n" +
            "Please choose either Male or Female."); Console.ForegroundColor = ConsoleColor.Cyan;
          gender = Console.ReadLine().ToLower(); Console.ForegroundColor = ConsoleColor.White;
        }
      }
      Console.Write("\n\nGreat!  From now on I will refer to you only as "); Character(); Console.Write(".");
      Console.ReadKey();
      Console.Clear();
    }

    //Gets a colored input at each branching choice
    static string input = "";
    static void GetInput()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      input = Console.ReadLine().ToUpper();
      Console.ForegroundColor = ConsoleColor.White;
    }

    static void Choice()
    {
      Console.Clear();
      //initialize variables for the case where players don't enter a valid choice.  After three attempts, a "reward" will be given
      int CantReadOne = 0;
      int CantReadTwo = 0;
      int CantReadThree = 0;
      int CantReadFour = 0;

      for (int scenario = 0; scenario < Scenarios; scenario++)
      {
        switch (scenario)
        {
          case 1:
            //starting the main story
            Console.Write(Story.MainStory[0]);
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(Story.MainStory[23]); Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Story.MainStory[24]);
            //display different depending on gender choice made at character creation
            if (gender == "female")
            {
              Console.Write(Story.MainStory[1]);
            }
            else if (gender == "male")
            {
              Console.Write(Story.MainStory[2]);
            }
            else
            {
              Console.Write(Story.MainStory[28]);
            }
            Console.Write(Story.MainStory[3]);

            //first branching choice
            TwoToneDialog(ConsoleColor.White, "\nWill you:\n\n", ConsoleColor.Green, "" +
              "\t|| A: give the girl some coins  ||\n" +
              "\t|| B: ignore the girl           ||\n" +
              "\t|| C: slap the girl's hand away ||\n\n", "Please enter a choice.  Type \"A\", \"B\", or \"C\".\n\t");
            GetInput();
            while (input != "A" || input != "B" || input != "C")
            {
              if (input == "A")
              {
                morality += 2;
                Console.Clear();
                Dialog(Story.GoodChoices[0], ConsoleColor.DarkGreen);
                Console.Write(Story.GoodChoices[1]);
                if (gender == "female")
                {
                  Console.Write(Story.GoodChoices[2]);
                }
                else if (gender == "male")
                {
                  Console.Write(Story.GoodChoices[3]);
                }
                else
                {
                  Console.Write(Story.MainStory[29]);
                }
                Console.Write(Story.GoodChoices[4]);
                PlayerInventory.Add(Story.RawInventory[0]);
                PlayerInventory.Add(Story.RawInventory[1]);
                TwoToneDialog(ConsoleColor.Cyan, "\nYou found a", ConsoleColor.Yellow, " Commemorative Wine Bottle", ".\n");
                break;
              }
              else if (input == "B")
              {
                morality += 4;
                Console.Clear();
                Dialog(Story.AverageChoices[0], ConsoleColor.DarkGreen);
                Console.Write(Story.AverageChoices[1]);
                PlayerInventory.Add(Story.RawInventory[2]);
                PlayerInventory.Add(Story.RawInventory[3]);
                TwoToneDialog(ConsoleColor.Cyan, "\nYou found a", ConsoleColor.Yellow, " Crow brooch", ".\n");
                break;
              }
              else if (input == "C")
              {
                morality += 6;
                Console.Clear();
                Dialog(Story.BadChoices[0], ConsoleColor.DarkGreen);
                Console.Write(Story.BadChoices[1]);
                PlayerInventory.Add(Story.RawInventory[4]);
                PlayerInventory.Add(Story.RawInventory[5]);
                TwoToneDialog(ConsoleColor.Cyan, "\nYou found a", ConsoleColor.Yellow, " Jade Dagger", ".\n");
                break;
              }
              else
              {
                CantReadOne++;
                if (CantReadOne == 3)
                {
                  PlayerInventory.Add(Story.RawInventory[6]);
                  PlayerInventory.Add(Story.RawInventory[7]);
                  TwoToneDialog(ConsoleColor.Cyan, "\nYou are one of a kind.  Have a reward: ", ConsoleColor.Yellow, "A vial of Fairy Tears", ".\n\n");
                }
                TwoToneDialog(ConsoleColor.White, "\nPlease try again.\nWill you:\n\n", ConsoleColor.Green, "" +
              "\t|| A: give the girl some coins  ||\n" +
              "\t|| B: ignore the girl           ||\n" +
              "\t|| C: slap the girl's hand away ||\n\n", "Please enter a choice.  Type only \"A\", \"B\", or \"C\".\n\t");
                GetInput();
              }
            }
            break;
          case 2:
            MoralityScroll();

            //starting the second scenario; a simple choice
            Console.Write(Story.MainStory[4]);
            TwoToneDialog(ConsoleColor.White, "\n", ConsoleColor.Green, "" +
              "\t|| A: helped     ||\n" +
              "\t|| B: ignored    ||\n" +
              "\t|| C: \"educated\" ||", "\nher many times.\n\nPlease enter a choice.  Type \"A\", \"B\", or \"C\".\n\t");
            GetInput();
            while (input != "A" || input != "B" || input != "C")
            {
              if (input == "A")
              {
                morality += 2;
                PlayerInventory.Add(Story.RawInventory[8]);
                PlayerInventory.Add(Story.RawInventory[9]);
                TwoToneDialog(ConsoleColor.Cyan, "In recognition of your humanitarian efforts, your colleagues \n" +
                  "gifted you a", ConsoleColor.Yellow, " candlestick", ".\n");
                break;
              }
              else if (input == "B")
              {
                morality += 4;
                PlayerInventory.Add(Story.RawInventory[10]);
                PlayerInventory.Add(Story.RawInventory[11]);
                TwoToneDialog(ConsoleColor.Cyan, "To honor your dedicated work ethic, the empire sent you \n" +
                  "a", ConsoleColor.Yellow, " Dragon-Fang necklace", ".\n");
                break;
              }
              else if (input == "C")
              {
                morality += 6;
                PlayerInventory.Add(Story.RawInventory[12]);
                PlayerInventory.Add(Story.RawInventory[13]);
                TwoToneDialog(ConsoleColor.Cyan, "The people of Jumdgian Protectorate are so pleased with your \n" +
                  "no-nonsense position on the indigent beggars, they collectively \n" +
                  "present you a", ConsoleColor.Yellow, " Bow and Arrow hat pin", ".\n");
                break;
              }
              else
              {
                CantReadTwo++;
                if (CantReadTwo == 3)
                {
                  PlayerInventory.Add(Story.RawInventory[14]);
                  PlayerInventory.Add(Story.RawInventory[15]);
                  TwoToneDialog(ConsoleColor.Cyan, "\nLooking for a Darwin Award?\nHow about this reward: ", ConsoleColor.Yellow, "A bag of toenail clippings", ".\n\n");
                }
                  TwoToneDialog(ConsoleColor.White, "Please try again\n\n\t Through the years, you have\n", ConsoleColor.Green, "" +
                  "\t|| A: helped     ||\n" +
                  "\t|| B: ignored    ||\n" +
                  "\t|| C: \"educated\" ||", "\nher many times.\n\nPlease enter a choice.  Type only \"A\", \"B\", or \"C\".\n\t");
                GetInput();
              }
            }
            break;
          case 3:
            MoralityScroll();
            Console.Write(Story.MainStory[4]);
            if (input == "A")
            {
              Dialog(Story.GoodChoices[5], ConsoleColor.DarkGreen);
            }
            else if (input == "B")
            {
              Dialog(Story.AverageChoices[2], ConsoleColor.DarkGreen);
            }
            else
            {
              Dialog(Story.BadChoices[2], ConsoleColor.DarkGreen);
            }
            Console.Write(Story.MainStory[5]);
            Character();
            Console.Write(Story.MainStory[6]);

            //third branching choice
            TwoToneDialog(ConsoleColor.White, "\nWhat do you suggest:\n\n", ConsoleColor.Green, "" +
              "\t|| A: Let her in.                       ||\n" +
              "\t|| B: Suggest a conditional admittance. ||\n" +
              "\t|| C: Absolutely refuse her.            ||\n\n", "Please enter a choice.  Type \"A\", \"B\", or \"C\".\n\t");
            GetInput();

            while (input != "A" || input != "B" || input != "C")
            {
              if (input == "A")
              {
                morality += 2;
                Console.Clear();
                school = true;
                Dialog(Story.GoodChoices[6], ConsoleColor.DarkGreen);
                Console.Write(Story.MainStory[7]);
                Console.Write(Story.GoodChoices[7]);
                PlayerInventory.Add(Story.RawInventory[16]);
                PlayerInventory.Add(Story.RawInventory[17]);
                TwoToneDialog(ConsoleColor.Cyan, "\nThe headmaster gave you a", ConsoleColor.Yellow, " Panther Locket", ".\n");
                break;
              }
              else if (input == "B")
              {
                morality += 4;
                Console.Clear();
                school = true;
                Dialog(Story.AverageChoices[3], ConsoleColor.DarkGreen);
                Console.Write(Story.MainStory[7]);
                Console.Write(Story.AverageChoices[4]);
                PlayerInventory.Add(Story.RawInventory[18]);
                PlayerInventory.Add(Story.RawInventory[19]);
                TwoToneDialog(ConsoleColor.Cyan, "\nThe girl gave you a weather-beaten", ConsoleColor.Yellow, " Blockbuster Membership Card", ".\n");
                break;
              }
              else if (input == "C")
              {
                morality += 6;
                Console.Clear();
                Dialog(Story.BadChoices[3], ConsoleColor.DarkGreen);
                Console.Write(Story.MainStory[7]);
                Console.Write(Story.BadChoices[4]);
                Character();
                Console.Write(Story.BadChoices[5]);
                PlayerInventory.Add(Story.RawInventory[20]);
                PlayerInventory.Add(Story.RawInventory[21]);
                TwoToneDialog(ConsoleColor.Cyan, "\nThe headmaster gave you a mint condition,\nfirst edition", ConsoleColor.Yellow, " Artensian Spellbook", ".\n");
                break;
              }
              else
              {
                CantReadThree++;
                if (CantReadThree == 3)
                {
                  PlayerInventory.Add(Story.RawInventory[22]);
                  PlayerInventory.Add(Story.RawInventory[23]);
                  TwoToneDialog(ConsoleColor.Cyan, "\nSome people can, and some people can't.\nAnd some people get a ", ConsoleColor.Yellow, "Taxidermied Rat", ".\n\n");
                }
                TwoToneDialog(ConsoleColor.White, "\nPlease try again.\nWhat do you suggest:\n\n", ConsoleColor.Green, "" +
              "\t|| A: Let her in.                       ||\n" +
              "\t|| B: Suggest a conditional admittance. ||\n" +
              "\t|| C: Absolutely refuse her.            ||\n\n", "Please enter a choice.  Type only \"A\", \"B\", or \"C\".\n\t");
                GetInput();
              }
            }
            break;
          case 4:
            MoralityScroll();

            //starting the fourth and final choice
            Console.Write(Story.MainStory[8]);
            Character();
            Console.Write(Story.MainStory[9]);

            //if Fayyt started school, she finished school
            if (school)
            {
              Console.Write(Story.MainStory[10]);
            }
            else
            {
              Console.Write(Story.MainStory[11]);
            }
            Console.Write(Story.MainStory[12]);

            //Automatic choice based on previous choices
            if (morality >= 6)
            {
              Console.Write(Story.MainStory[13]);
            }
            else if (morality <= 7 && morality <= 17)
            {
              Console.Write(Story.MainStory[14]);
            }
            else
            {
              Console.Write(Story.MainStory[15]);
            }
            Console.Write(Story.MainStory[16]);

            //Do you call out or not; for what reason
            TwoToneDialog(ConsoleColor.White, "\nDo you call out to the girl?\n\n", ConsoleColor.Green, "" +
              "\t|| A: Yes, she's done so well!                 ||\n" +
              "\t|| B: No, this is your interview.              ||\n" +
              "\t|| C: A very public shaming might do her good. ||\n\n", "Please enter a choice.  Type \"A\", \"B\", or \"C\".\n\t");
            GetInput();

            while (input != "A" || input != "B" || input != "C")
            {
              if (input == "A")
              {
                morality += 2;
                Console.Clear();
                Dialog(Story.GoodChoices[8], ConsoleColor.DarkGreen);
                PlayerInventory.Add(Story.RawInventory[24]);
                PlayerInventory.Add(Story.RawInventory[25]);
                TwoToneDialog(ConsoleColor.Cyan, "\nThe videomimeographer's bag fell open, and he dropped \n" +
                  "his backup", ConsoleColor.Yellow, " toupee", ".  You pick it up and put it in your pocket.\n");
                break;
              }
              else if (input == "B")
              {
                morality += 4;
                Console.Clear();
                Dialog(Story.AverageChoices[5], ConsoleColor.DarkGreen);
                PlayerInventory.Add(Story.RawInventory[26]);
                PlayerInventory.Add(Story.RawInventory[27]);
                TwoToneDialog(ConsoleColor.Cyan, "\nYou proudly show off your son's ", ConsoleColor.Yellow, "diploma", ".\n");
                break;
              }
              else if (input == "C")
              {
                morality += 6;
                Console.Clear();
                Dialog(Story.BadChoices[6], ConsoleColor.DarkGreen);
                PlayerInventory.Add(Story.RawInventory[28]);
                PlayerInventory.Add(Story.RawInventory[29]);
                TwoToneDialog(ConsoleColor.Cyan, "\nAs a graduation gift, you gifted yourself a beautiful", ConsoleColor.Yellow, " watch fob", ".\n");
                break;
              }
              else
              {
                CantReadFour++;
                if (CantReadFour == 3)
                {
                  PlayerInventory.Add(Story.RawInventory[30]);
                  PlayerInventory.Add(Story.RawInventory[31]);
                  TwoToneDialog(ConsoleColor.Cyan, "\nDo you know what you deserve, I'll tell you:\n" +
                    "\"special\" people like you deserve ", ConsoleColor.Yellow, "Poltergeist Hair", ".\n\n");
                }
                TwoToneDialog(ConsoleColor.White, "\nPlease try again\nDo you call out to the girl?\n\n", ConsoleColor.Green, "" +
                  "\t|| A: Yes, she's done so well!                 ||\n" +
                  "\t|| B: No, this is your interview.              ||\n" +
                  "\t|| C: A very public shaming might do her good. ||\n\n", "Please enter a choice.  Type only \"A\", \"B\", or \"C\".\n\t");
                GetInput();
              }
            }
            MoralityScroll();
            Console.Write(Story.MainStory[17]);

            //Son addresses parent
            if (gender == "female")
            {
              Console.Write(Story.MainStory[18]);
            }
            else if (gender == "male")
            {
              Console.Write(Story.MainStory[19]);
            }
            else
            {
              Console.Write(Story.MainStory[30]);
            }
            Console.Write(Story.MainStory[20]);

            //consequence of Morality Actions
            //TestMoralCode();
            if (morality <= 8)
            {
              Console.Write(Story.GoodChoices[9]);
            }
            else if (morality >= 9 && morality <= 18)
            {
              Console.Write(Story.AverageChoices[6]);
            }
            else
            {
              Console.Write(Story.BadChoices[7]);
            }
            Console.Write(Story.MainStory[21]);

            //second Morality Consequence
            //TestMoralCode();
            if (morality <= 11)
            {
              Console.Write(Story.GoodChoices[10]);
            }
            else if (morality >= 12 && morality <= 20)
            {
              Console.Write(Story.AverageChoices[7]);
            }
            else
            {
              Console.Write(Story.BadChoices[8]);
            }

            //Third consequence
            //TestMoralCode();
            if (morality <= 18)
            {
              Console.Write(Story.MainStory[25]);
            }
            else
            {
              Console.Write(Story.MainStory[26]);
            }
            Console.Write(Story.MainStory[27]);

            //Fourth consequence
            if (school)
            {
              Console.Write(Story.GoodChoices[11]);
            }
            else
            {
              //TestMoralCode();
              if (morality <= 20)
              {
                Console.Write(Story.AverageChoices[8]);
              }
              else
              {
                Console.Write(Story.BadChoices[9]);
              }
            }
            MoralityScroll();
            Dialog(Story.MainStory[22], ConsoleColor.DarkYellow);
            //TestMoralCode();
            if (morality <= 11)
            {
              Dialog(Story.GoodChoices[12], ConsoleColor.DarkYellow);
            }
            else if (morality >= 12 && morality <= 20)
            {
              Dialog(Story.AverageChoices[9], ConsoleColor.DarkYellow);
            }
            else
            {
              Dialog(Story.BadChoices[10], ConsoleColor.DarkYellow);
            }
            break;
          default:
            break;
        }
      }
    }

    static void EndGame()
    {
      TwoToneDialog(ConsoleColor.DarkBlue, "\nAdventure complete.  Please press ", ConsoleColor.Green, "any key ", "to view your inventory.\n\t");
      Console.ReadKey();
      Console.Clear();
      Console.Write("Congratulations, "); Character(); Console.Write(", you have finished the game.\n" +
        "You have found some items:\n\n");
      Console.ForegroundColor = ConsoleColor.Yellow;
      int counter = 0;
      foreach (string item in PlayerInventory)
      {
        counter++;
        if (counter % 2 == 0)
        {
          Dialog(item, ConsoleColor.Cyan);
        }
        else
        {
          Dialog(item, ConsoleColor.Yellow);
        }
      }
      
      TwoToneDialog(ConsoleColor.DarkBlue, "\nNow, let's see what key sets you were able to acquire (if any).\n" +
        "Press ", ConsoleColor.Green, "any key ", "to view your rewards.\n\t");
      Console.ReadKey();
      Console.Clear();
      if (PlayerInventory.Contains(Story.RawInventory[6]) && (PlayerInventory.Contains(Story.RawInventory[14]) && PlayerInventory.Contains(Story.RawInventory[22]) && (PlayerInventory.Contains(Story.RawInventory[30]) && (PlayerInventory.Contains(Story.RawInventory[32]) && (PlayerInventory.Contains(Story.RawInventory[34]))))))
      {
        Console.ForegroundColor = ConsoleColor.Red; Console.Write(Story.KeyRewards[6]);
        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(Story.KeyRewards[7]);
      }
      if (PlayerInventory.Contains(Story.RawInventory[0]) && (PlayerInventory.Contains(Story.RawInventory[8]) && (PlayerInventory.Contains(Story.RawInventory[20]) && (PlayerInventory.Contains(Story.RawInventory[26])))))
      {
        Console.ForegroundColor = ConsoleColor.Red; Console.Write(Story.KeyRewards[0]);
        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(Story.KeyRewards[1]);
      }
      else if (PlayerInventory.Contains(Story.RawInventory[2]) && (PlayerInventory.Contains(Story.RawInventory[12]) && (PlayerInventory.Contains(Story.RawInventory[16]) && (PlayerInventory.Contains(Story.RawInventory[28])))))
      {
        Console.ForegroundColor = ConsoleColor.Red; Console.Write(Story.KeyRewards[2]);
        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(Story.KeyRewards[3]);
      }
      else if (PlayerInventory.Contains(Story.RawInventory[4]) && (PlayerInventory.Contains(Story.RawInventory[10]) && (PlayerInventory.Contains(Story.RawInventory[18]) && (PlayerInventory.Contains(Story.RawInventory[24])))))
      {
        Console.ForegroundColor = ConsoleColor.Red; Console.Write(Story.KeyRewards[4]);
        Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(Story.KeyRewards[5]);
      }
      else
      {
        Dialog("Although you collected many items through your journey, you did not \n" +
          "complete any sets of key items.  Please feel free to play again.\n\n", ConsoleColor.Red);
      }
      Console.WriteLine();
      Character(); TwoToneDialog(ConsoleColor.White, ", you have completed the game.  Press", ConsoleColor.Green, " any key ", "to end the simulation.\n\n");
    }

    //Useful for complex sentences with keywords.
    static void TwoToneDialog(ConsoleColor FontColor1, string ForeMessage, ConsoleColor FontColor2, string MidMessage, string AftMessage)
    {
      Console.ForegroundColor = FontColor1;
      Console.Write(ForeMessage);
      Console.ForegroundColor = FontColor2;
      Console.Write(MidMessage);
      Console.ForegroundColor = FontColor1;
      Console.Write(AftMessage);
      Console.ForegroundColor = ConsoleColor.White;
    }

    //sets character name to display color according to gender
    static void Character()
    {
      if (gender == "male")
      {
        Console.ForegroundColor = ConsoleColor.Blue;
      }
      else if (gender == "female")
      {
        Console.ForegroundColor = ConsoleColor.Magenta;
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.DarkGray;
      }
      Console.Write(CharacterName);
      Console.ForegroundColor = ConsoleColor.White;
    }

    //Useful for simple sentences with keywords.
    static void Dialog(string Message, ConsoleColor FontColor)
    {
      Console.ForegroundColor = FontColor;
      Console.Write(Message);
      Console.ForegroundColor = ConsoleColor.White;
    }

    //static void TestMoralCode()
    //{
    //  Console.ForegroundColor = ConsoleColor.Magenta;
    //  Console.Write("\n\nThis is the current value of your morality: {0}\n\n", Morality);
    //  Console.ForegroundColor = ConsoleColor.White;
    //}

    static void MoralityScroll()
    {
      Dialog("\nCalculating morality based on choices.  Please wait...", ConsoleColor.DarkMagenta);
      string LoadingText = "Choosing Fayyt: Calculating your morality...  ";
      bool Loading = true;

      Console.Title = LoadingText;

      while (Loading)
      {
        for (int i = 0; i < 30; i++)
        {
          Console.Title = LoadingText;
          string inventory = LoadingText[0].ToString();
          String LoadingTextRemove = LoadingText.Remove(0, 1);
          String LoadingTextInsert = LoadingTextRemove.Insert(LoadingText.Length - 1, inventory);
          LoadingText = LoadingTextInsert;
          Thread.Sleep(240);
        }
        Loading = false;
      }
      Console.Title = "Choosing Fayyt!";
      TwoToneDialog(ConsoleColor.DarkMagenta, "\nMorality calculated.  Please press ", ConsoleColor.Green, "any key ", "to continue.\n\t");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
