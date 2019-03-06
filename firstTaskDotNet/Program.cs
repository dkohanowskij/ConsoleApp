using System;
using TestLib;

namespace firstTaskDotNet
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.WriteLine("Enter you name:");
      var name = Console.ReadLine();

      UserManager userManager = new UserManager(name);

      Console.WriteLine(userManager.GetGreeting());
      Console.ReadKey();
    }
  }
}
