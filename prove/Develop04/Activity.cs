using System.Diagnostics.Contracts;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    private static int _counter;

    public Activity()
    {
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}");

        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        int.TryParse(Console.ReadLine(), out _duration);

        Console.Clear();
        Console.WriteLine("Get ready...\n");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\n\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i> 0; i--)
        {
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public static void SetCount()
    {
        _counter++;
    }
     public static int GetCount()
    {
        return _counter;
    }

}