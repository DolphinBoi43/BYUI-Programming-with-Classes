using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Event: Title | Description | Date | Time | Address 
        Lecture: Event | Speaker | Capacity
        Reception: Event
        Outdoor: Event | Weather

        Details
        - Standard: Title | Description | Date | Time | Address
        - Full: Standard | (Lecture/Reception/Outdoor)
        - Short: Type | Title | Date
        */

        // Creating Events
        Lecture lecture = new Lecture("TEDTalk","This weeks TEDTalk will go over the use of AI in silly string application", "11/11/2024", "11:00 am", "Trump Tower", "Buddy the Elf", "150");
        Outdoor outdoor = new Outdoor("Disc Golf Tournament", "A Tournament for the best Disc Golfer in the Tri-State Area", "6/2/2024", "9:00 am", "Daytona Beach", "Sunny");
        Reception reception = new Reception("Mr. & Mrs. Beans Wedding", "This is not the Wedding Singer", "2/15/2024", "12:00am");

        // Printing Details
        Console.WriteLine(lecture.Standard() + lecture.Full() + lecture.Short());
        Console.WriteLine(outdoor.Standard() + outdoor.Full() + outdoor.Short());
        Console.WriteLine(reception.Standard() + reception.Full() + reception.Short());        
    }
}