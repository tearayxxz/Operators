using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int passcode;
            string Agent;
            Console.WriteLine("Input your password");
            passcode = int.Parse(Console.ReadLine());

            Console.WriteLine("Who are you?");
            Agent = Console.ReadLine();
            int f = passcode * 100000;
            int e = (passcode * 10000);
            int d = (passcode * 1000);
            int c = (passcode * 100);
            int b = (passcode * 10);
            int a = passcode;

            bool CheckCIA = (Agent == "CIA") && (a % 3 == 0) && ((b != 1) && (b != 3) && (b != 5)) && ((d >= 6) && (d != 8));
            bool CheckFBI = (Agent == "FBI") && (f >= 4 && f <= 7) && (c % 2 == 0 && c != 6) && (e % 2 == 1);
            bool CheckNSA = (Agent == "NSA") && (30 % a == 0) && (c % 3 == 0 && c % 3 == 1) && (a == 6 || b == 7 || c == 7 || d == 7 || e == 7 || f == 7);
            bool CheckAgent = CheckCIA || CheckFBI || CheckNSA;

            Console.WriteLine("Pass : {0}", CheckAgent);
        }
    }
}
