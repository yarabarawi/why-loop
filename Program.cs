using System;

namespace why_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string inmatat = string.Empty;

            while (inmatat != "hej")
            {
                 Console.Write("mata in något: ");
                 inmatat = Console.ReadLine();
                 
                 Console.WriteLine("Du skrev:" + inmatat);
            }
             Console.WriteLine("Nu är programet slut!");

        }
    }
}
