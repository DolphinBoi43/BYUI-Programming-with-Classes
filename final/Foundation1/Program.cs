using System;

class Program
{
    static void Main(string[] args)
    {
        // Video goes
        // title / author / length (enter in secs)
        // Comment goes
        // User / user comment
        
        // Video 1
        Comment Com_1 = new Comment("Sosh","lmoa");
        Comment Com_1_1 = new Comment("Tykk12","sheesh");
        Comment Com_1_2 = new Comment("Yoot","Yeet");
        Video Youtube_1 = new Video("Car Wrecks Compilation (everyone lives)", "fakemarkiplier", 160);
        Youtube_1._comments.Add(Com_1); 
        Youtube_1._comments.Add(Com_1_1); 
        Youtube_1._comments.Add(Com_1_2);
        // Video 2
        Comment Com_2 = new Comment("Goerge68","Omg");
        Comment Com_2_1 = new Comment("Skibadi","Dude got yeti'd");
        Comment Com_2_2 = new Comment("UgandanKnuckles","POV: You ate umixed cement");
        Video Youtube_2 = new Video("AFV Best Moments", "Turbo50man", 200);
        Youtube_2._comments.Add(Com_2); 
        Youtube_2._comments.Add(Com_2_1); 
        Youtube_2._comments.Add(Com_2_2);
        // Video 3
        Comment Com_3 = new Comment("GundamMan2","Get in the robot shinji");
        Comment Com_3_1 = new Comment("AC6Fanboy","Not the laser cannons");
        Comment Com_3_2 = new Comment("HaloMan","Why did it take 3 years for firefight to return to Halo");
        Video Youtube_3 = new Video("Lastest News in Robots Week 46", "RobotNews", 400);
        Youtube_3._comments.Add(Com_3); 
        Youtube_3._comments.Add(Com_3_1); 
        Youtube_3._comments.Add(Com_3_2);
        // Display Videos
        Youtube_1.DisplayVideo();
        Console.WriteLine();
        Youtube_2.DisplayVideo();
        Console.WriteLine();
        Youtube_3.DisplayVideo();        
    }
}