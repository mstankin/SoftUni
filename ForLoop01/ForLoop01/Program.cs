using System;
using System.Diagnostics.Metrics;

namespace ForLoop01
{
    internal class Program
    {

        //static void Main(string[] args)
        //{

        //}

        // Първа задача 
        //static void Main(string[] args)
        //{
        //    for (int i = 7; i <= 1000; i++)
        //    {
        //        if (i % 10 == 7)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int sum = 0;
        //    int maxNum = int.MaxValue;
        //    int n = int.Parse(Console.ReadLine());
        //    for (int i = 0; i <= n; i++)
        //    {
        //        int num = int.Parse(Console.ReadLine());
        //        sum += num;

        //        if (num > maxNum)
        //        {
        //            maxNum = num;
        //        }
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    int p1 = 0;
        //    int p2 = 0;
        //    int p3 = 0;
        //    int p4 = 0;
        //    int p5 = 0;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        int num = int.Parse(Console.ReadLine());

        //        if (num < 200)
        //        {
        //            p1++;
        //        }
        //        else if (num >= 200 && num <= 399)
        //        {
        //            p2++;
        //        }
        //        else if (num >= 400 && num <= 599)
        //        {
        //            p3++;
        //        }
        //        else if (num >= 600 && num <= 799)
        //        {
        //            p4++;
        //        }
        //        else if (num >= 800)
        //        {
        //            p5++;
        //        }
        //    }

        //    double resultOfP1 = (double)p1 / n * 100;
        //    double resultOfP2 = (double)p2 / n * 100;
        //    double resultOfP3 = (double)p3 / n * 100;
        //    double resultOfP4 = (double)p4 / n * 100;
        //    double resultOfP5 = (double)p5 / n * 100;

        //    Console.WriteLine($"{resultOfP1:F2}%");
        //    Console.WriteLine($"{resultOfP2:F2}%");
        //    Console.WriteLine($"{resultOfP3:F2}%");
        //    Console.WriteLine($"{resultOfP4:F2}%");
        //    Console.WriteLine($"{resultOfP5:F2}%");
        //}


        //static void Main(string[] args)
        //{
        //    int age = int.Parse(Console.ReadLine());
        //    double washingMachinePrice = double.Parse(Console.ReadLine());
        //    int toyPrice = int.Parse(Console.ReadLine());
        //    int money = 0;
        //    int toys = 0;

        //    for (int i = 1; i <= age; i++)
        //    {
        //        if (i % 2 == 0)
        //        {

        //            money += (i / 2 * 10) - 1;
        //        }
        //        else
        //        {
        //            toys++;
        //        }
        //    }
        //    money += toyPrice * toys;

        //    if (money >= washingMachinePrice)
        //    {
        //        double moneyLeft = money - washingMachinePrice;
        //        Console.WriteLine($"Yes! {moneyLeft:F2}");
        //    }
        //    else
        //    {
        //        double moneyNeeded = washingMachinePrice - money;
        //        Console.WriteLine($"No! {moneyNeeded:F2}");
        //    }

        //}


        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    int salary = int.Parse(Console.ReadLine());
        //    int facebookFine = 150;
        //    int InstagramFine = 100;
        //    int RedditFine = 50;

        //    for (int i = 0; i <= n; i++)
        //    {
        //        string webSite = Console.ReadLine();

        //        if (webSite == "Facebook")
        //        {
        //            salary -= facebookFine;
        //        }
        //        else if (webSite == "Instagram")
        //        {
        //            salary -= InstagramFine;
        //        }
        //        else if (webSite == "Reddit")
        //        {
        //            salary -= RedditFine;
        //        }

        //        if (salary <= 0)
        //        {
        //            Console.WriteLine("You have lost your salary.");
        //            return;
        //        }
        //    }
        //    Console.WriteLine(salary);
        //}


        //static void Main(string[] args)
        //{
        //    string actorName = Console.ReadLine();
        //    double startingPoints = double.Parse(Console.ReadLine());
        //    int judgeCount = int.Parse(Console.ReadLine());
        //    double totalPoints = startingPoints;

        //    for (int i = 0; i < judgeCount; i++)
        //    {
        //        string judgeName = Console.ReadLine();
        //        double judgePoints = double.Parse(Console.ReadLine());

        //        totalPoints += (judgeName.Length * judgePoints) / 2;

        //        if (totalPoints > 1250.5)
        //        {
        //            Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:F1}!");
        //            return;
        //        }
        //    }

        //    double neededPoints = 1250.5 - totalPoints;
        //    Console.WriteLine($"Sorry, {actorName} you need {neededPoints:F1} more!");

        //}


        //static void Main(string[] args)
        //{
        //    int groupsCount = int.Parse(Console.ReadLine());
        //    int mussalaClimbers = 0;
        //    int monblanClimbers = 0;
        //    int kilimindjaroClimbers = 0;
        //    int k2Climbers = 0;
        //    int everestClimbers = 0;

        //    int totalClimbers = 0;

        //    for (int i = 0; i < groupsCount; i++)
        //    {
        //        int peoplePerGroup = int.Parse(Console.ReadLine());
        //        totalClimbers += peoplePerGroup;


        //        if (peoplePerGroup <= 5)
        //        {
        //            mussalaClimbers += peoplePerGroup;
        //        }
        //        else if (peoplePerGroup <= 12)
        //        {
        //            monblanClimbers += peoplePerGroup;
        //        }
        //        else if (peoplePerGroup <= 25)
        //        {
        //            kilimindjaroClimbers += peoplePerGroup;
        //        }
        //        else if (peoplePerGroup <= 40)
        //        {
        //            k2Climbers += peoplePerGroup;
        //        }
        //        else 
        //        {
        //            everestClimbers += peoplePerGroup;
        //        }
        //    }

        //    double percentageOfMussala = (double)mussalaClimbers / totalClimbers * 100;
        //    double percentageOfMonblan = (double)monblanClimbers / totalClimbers * 100;
        //    double percentageOfKilimindjaro = (double)kilimindjaroClimbers / totalClimbers * 100;
        //    double percentageOfK2 = (double)k2Climbers / totalClimbers * 100;
        //    double percentageOfEverest = (double)everestClimbers / totalClimbers * 100;

        //    Console.WriteLine($"{percentageOfMussala:F2}%");
        //    Console.WriteLine($"{percentageOfMonblan:F2}%");
        //    Console.WriteLine($"{percentageOfKilimindjaro:F2}%");
        //    Console.WriteLine($"{percentageOfK2:F2}%");
        //    Console.WriteLine($"{percentageOfEverest:F2}%");

        //}

        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int winnerPoints = 2000;
            int finalistPoints = 1200;
            int semiFinalistPoints = 720;
            int gamesWonCount = 0;
            int pointsWon = 0;

            for (int i = 0; i < tournamentsCount; i++)
            {
                string result = Console.ReadLine();
                if (result == "W")
                {
                    gamesWonCount++;
                    pointsWon += winnerPoints;
                }
                else if (result == "F")
                {
                    pointsWon += finalistPoints;
                }
                else if (result == "SF")
                {
                    pointsWon += semiFinalistPoints;
                }
            }

            double averagePointsPerTournament = pointsWon / tournamentsCount;
            double percentageOfGamesWon = (double)gamesWonCount / tournamentsCount * 100;
            double totalPoints = pointsWon + startingPoints;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points:{averagePointsPerTournament}");
            Console.WriteLine($"{percentageOfGamesWon:F2}%");
        }

    }
}
