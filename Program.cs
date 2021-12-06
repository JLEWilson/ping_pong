using System;
using System.Collections.Generic;
using PingPongModel;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a number and we will PingPongify the numbers divisible by 5's and 3's for you!");
    string userNumberString = Console.ReadLine();
    int userNumber = int.Parse(userNumberString);
    List<string> outputList = PingPong.PingPongify(userNumber);

    foreach (string element in outputList)
    {
        Console.WriteLine(element);
    }
  }
}