using System;

class Program
{
    static void Main(string[] args)
    {
        // Video goes
        // title / author / length / number of comments
        // Comment goes
        // User / user comment
        Video Youtube_1 = new Video();
        Comment Com_1 = new Comment();
        Comment Com_1_1 = new Comment();
        Comment Com_1_2 = new Comment();
        Com_1._user = ""; 
        Com_1_1._user = ""; 
        Com_1_2._user = "";
        Com_1._ucomment = ""; 
        Com_1_1._ucomment = ""; 
        Com_1_2._ucomment = "";
        Youtube_1._title = "";
        Youtube_1._author = "";
        Youtube_1._length = 0.0;
        Youtube_1._comment_num = 1;

        Video Youtube_2 = new Video();
        Comment Com_2 = new Comment();
        Comment Com_2_1 = new Comment();
        Comment Com_2_2 = new Comment();
        Com_2._user = "";
        Com_2_1._user = "";
        Com_2_2._user = "";
        Com_2._ucomment = "";
        Com_2_1._ucomment = "";
        Com_2_2._ucomment = "";
        Youtube_2._title = "";
        Youtube_2._author = "";
        Youtube_2._length = 0.0;
        Youtube_2._comment_num = 1;

        Video Youtube_3 = new Video();
        Comment Com_3 = new Comment();
        Comment Com_3_1 = new Comment();
        Comment Com_3_2 = new Comment();
        Com_3._user = "";
        Com_3_1._user = "";
        Com_3_2._user = "";
        Com_3._ucomment = "";
        Com_3_1._ucomment = "";
        Com_3_2._ucomment = "";
        Youtube_3._title = "";
        Youtube_3._author = "";
        Youtube_3._length = 0.0;
        Youtube_3._comment_num = 1;

        Youtube_1.DisplayVideo();
        Youtube_2.DisplayVideo();
        Youtube_3.DisplayVideo        
    }
}