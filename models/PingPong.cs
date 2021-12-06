using System;
using System.Collections.Generic;

namespace PingPongModel
{
  public class PingPong
  {
    public PingPong()
    {

    }
    public static List<string> PingPongify(int userInt)
    {
      List<string> outputList = new List<string> {};
      for(int i = 1; i <= userInt; i++)
      {
        if(i % 3 == 0 && i % 5 == 0)
        {
          outputList.Add("Ping Pong");
        }
        else if (i % 3 == 0)
        {
          outputList.Add("Ping");
        } 
        else if (i % 5 == 0)
        {
          outputList.Add("Pong");
        } 
        else
        {
          outputList.Add(i.ToString());
        }
      }
      return outputList;
    }
  }
}