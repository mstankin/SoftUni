namespace Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Grade:");
            //int grade = int.Parse(Console.ReadLine());
            int grade;
            try 
            {
                grade = int.Parse(Console.ReadLine());
                switch (grade)
                {
                    case 6:
                        Console.WriteLine("Excellent");
                        break;
                    case 5:
                        Console.WriteLine("Very Good");
                        break;
                    case 4:
                        Console.WriteLine("Good");
                        break;
                    case 3:
                        Console.WriteLine("Poor");
                        break;
                    case 2:
                        Console.WriteLine("Fail");
                        break;
                    default:
                        Console.WriteLine("Invalid grade");
                        break;
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine (e);
            }

            
        }
    }
}
