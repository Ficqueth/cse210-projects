public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        // when timer reaches the end of the _duration seconds it stops( it still finishes the cycle)
        for (int i = 0; i< _duration; i+=8)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nNow breathe out...");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
}