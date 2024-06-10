using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Enter your message: ");
        string userMessage = Console.ReadLine();

        if (CheckMessageLength(userMessage))
        {
            Console.WriteLine("Posted");
        }
        else
        {
            Console.WriteLine("Rejected");
        }
    }

    static bool CheckMessageLength(string message)
    {
        return message.Length <= 140;
  }
}