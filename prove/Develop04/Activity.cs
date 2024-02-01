using System.Diagnostics.Contracts;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!\n\nYou have completed another {_duration} of the {_name}");
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
        
    }

}