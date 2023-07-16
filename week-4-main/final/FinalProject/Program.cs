using System;
class Program
{

    public static void Main()
    {
        //This should run all starting functions and the like
        TextEvents.Menu(1);
        bool valid_selection = false;
        int select_int = 0;
        while(valid_selection == false)
        {
            string selection = Console.ReadLine();
            try
            {
                select_int = Convert.ToInt16(selection);
                select_int = select_int + 1; 
                valid_selection = true;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Input must be a number.");
            }

        }
        TextEvents.Menu(select_int);
    }
}