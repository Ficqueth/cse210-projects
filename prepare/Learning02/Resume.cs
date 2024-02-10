using System;

public class Resume
{
    public string _shortName;


    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_shortName}");
        Console.WriteLine("Jobs:");


        foreach (Job job in _jobs)
        {

            job.Display();
        }
    }
}