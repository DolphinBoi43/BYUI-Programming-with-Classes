using System;
public class Resume
{
    string _name;
    List<Job> _jobs;
    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }

}