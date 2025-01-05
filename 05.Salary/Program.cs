﻿namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabCount = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tabCount; i++)
            {
                string websiteName = Console.ReadLine();
                switch (websiteName) 
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                   
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
        }
    }
}
