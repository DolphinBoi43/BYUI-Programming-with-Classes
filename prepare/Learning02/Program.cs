using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Scream Engineer";
        job1._company = "Monster Inc";
        job1._startYear = 2016;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Mech Pilot";
        job2._company = "Gundam Corp";
        job2._startYear = 1956;
        job2._endYear = 2014;

        Resume myResume = new Resume();
        myResume._name = "Fuji Mochi";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);



    }
}