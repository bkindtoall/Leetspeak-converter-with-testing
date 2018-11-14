using System;
using System.Linq;
using System.Collections.Generic;


namespace LeetspeakA
{
  public static class LeetspeakClass
  {
    public static char CheckNumber(char letter)
    {
       if (letter=='e')
       {
           return '3';
       }
       else if (letter=='o')
       {
           return '0';
       }
       else if (letter=='I')
       {
           return '1';
       }
       else if (letter=='t')
       {
           return '7';
       }
       else if (letter=='s')
       {
           return 'z';
       }
       {
           return letter;
       }
    //User Enters Number

    //Given a list of all numbers beginning at 1 and counting up to the inputted number

    //Replace some numbers with wordßs.
    // - All numbers divisible by BOTH 3 and 5 are replaced by "ping-pong".
    // - All numbers in the list that are divisible by 3 are replaced by "ping".
    // - All numbers divisible by 5 are replaced by "pong".

    }

    public static void Main()
    {
      Console.WriteLine("Please enter a sentence: ");
      string userInput = Console.ReadLine();
      char[] array = userInput.ToCharArray();
      for(int i=0;i<userInput.Length;i++)
      {
          array[i] = CheckNumber(array[i]);
          // Console.WriteLine(userOutput);
          // leet.Add(userOutput);
      }
      string result = string.Join("", array);

      Console.WriteLine(result);

    }
  }
}
