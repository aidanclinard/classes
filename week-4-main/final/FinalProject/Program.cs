using System;

class Program
{
    static void Main()
    {
        //This should run all starting functions and the like
        Text_Events.menu(1);
    }
    static void kill_program(string desired_program)
    {
        //This function will kill whatever program is selected. I need to create exceptions for critical software.
    }

}

class Bar_Graphics
{
    static void bar(int min, int cur, int max)
    {
        //This should take in the minimum, maximum, and current possible values for whatever is being graphed out and then convert
        //those values to a visible graph probably created by ascii trickery. Also needs to include some catches incase conversion breaks.
        //I also need to find a way for it to update live while still waiting for input to turn it off.
    }
}

class Read_Data
{
    static void usage_info()
    {
        //This function needs to take the usage information from the computer. It should be split into disk, cpu, ram, and gpu.
    }
    static void program_usage()
    {
        //This might be redundant based on what usage_info takes in. If not, this function will take in program usage data.
    }
}

class Text_Events
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

