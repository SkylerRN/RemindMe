using System.Threading.Channels;

internal class Program
{
    public static void Main(string[] args)
    {
        bool backTop = true;
        while (backTop)
        {
            Start:
            Console.WriteLine("How many Reminders would you like to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Reminders>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                //how it takes the information
                var Reminders = new Reminders();
                Console.WriteLine("Please enter a name for the reminder.");
                Reminders.Name = Console.ReadLine();
                Console.WriteLine("Please enter the day of the month " + Reminders.Name);
                Reminders.Date = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a brief description for your reminder. ");
                Reminders.Description = Console.ReadLine();
                recordList.Add(Reminders);
            }
            //how it spits the information back out
            foreach (var record in recordList)
            {
                Console.WriteLine($"Reminder: we will remind you about " + record.Name + " on the " + record.Date + "th about " + record.Description);
            }

            Console.WriteLine("Please press 1 to exit or 2 to return to start.");
            int choice = 0;

            while (choice != 1)
            {
                Console.WriteLine("1. Quit");
                Console.WriteLine("2. Return to start of program");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Goodbye!");
                        break;

                    case 2:
                        Console.WriteLine("Returning to main");
                        goto  Start;


                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }
            }
        }
                  backTop = false;
    }
}



