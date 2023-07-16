using System;

public class Text_Events
{
    public static void menu(int menuselect)
    {
        //This will include the primary menu where you can be directed to different views or funcitons.
        if(menuselect == 1)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the performance tracker, designed to help you optimise your processes!");
            Console.WriteLine("1: View Performance Bars");
            Console.WriteLine("2: View Power Hungry Software");
            Console.WriteLine("3: End Processes");
        }
        else
        {
            Console.WriteLine("You're out of luck");
        }
        
    }
    static void errors()
    {
        //idk if I will use this one, just in case.
    }
    static void loading_screens(int numberofrepeats)
    {
        //put a goofy little loading screen here.
    }
}