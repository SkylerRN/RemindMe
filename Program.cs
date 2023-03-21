using System.Threading.Channels;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many Reminders would you like to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Reminders>();
        for (int i = 0; i < numberOfRecords; i++)
        {
         //how it takes the information
            var Reminders = new Reminders();
            Console.WriteLine("Please enter a name for the reminder.");
            Reminders.Name = Console.ReadLine();
            Console.WriteLine("Please enter a date for " +  Reminders.Name );
            Reminders.Date = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a brief description for your reminder. ");
            Reminders.Description = Console.ReadLine();
            recordList.Add(Reminders);
        }
       //how it spits the information back out
        foreach (var record in recordList)
        {
            Console.WriteLine($"Product:" + record.Name + " " + record.Date + " " + record.Description);
        }
      
        Console.WriteLine("Please press 0 to exit or 1 to return to start.");
        

    }
}



