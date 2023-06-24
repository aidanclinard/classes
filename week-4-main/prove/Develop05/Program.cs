using System;

class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.Write("Welcome to the Goal Trackerthon 5000!");
        Console.WriteLine("");
        dot_loading_anim(3);
        Console.Clear();
        Console.WriteLine("What would you like to do today?");
        Thread.Sleep(50);
        Console.WriteLine("1. Manage existing goals");
        Thread.Sleep(50);
        Console.WriteLine("2. Add new goals");
        Thread.Sleep(50);
                string strchoice = Console.ReadLine();
        int choice = 123;
        try{
            choice = Convert.ToInt32(strchoice);
        }
        catch{
            Console.WriteLine("Incorrect selection");
        }
        if(choice == 1){
            ManageGoals.ReadGoals();
        }
        else if(choice == 2){
            ManageGoals.AddGoal(true);
        }
        else
        {
            Console.WriteLine("Incorrect selection");
        }
    }

    public static void dot_loading_anim(int count){
    for(int i = 0; i < count; i++){
        Console.Write(".");
        Thread.Sleep(500);
        ClearLine();
        Console.Write("..");
        Thread.Sleep(500);
        ClearLine();
        Console.Write("...");
        Thread.Sleep(500);
        ClearLine();
        }
    }
    public static void ClearLine()
    {
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop);
    }
}

class ManageGoals
{
    public static void AddGoal(bool first_time){
        if(first_time)
        {
           Console.Write("Adding another one huh?");
            Thread.Sleep(1500); 
        }
        Console.Clear();
        Console.Write("Go ahead and type whatever goal you have in mind.");
        string new_goal = Console.ReadLine();
        Console.WriteLine("Is this goal repeatable, as in you are trying to get something done a certain number of times? y/n");
        string is_repeatable_yn = Console.ReadLine();
        bool is_repeatable = false;
        if(is_repeatable_yn == "y")
        {
            is_repeatable = true;
        }
        else if(is_repeatable_yn == "n")
        {
            is_repeatable = false;
        }
        else
        {
            Console.Write("This is a yes or no question.");
            Thread.Sleep(1000);
            AddGoal(false);
        }
        SaveGoal(new_goal, is_repeatable);
        Console.Clear();
        Console.WriteLine("Heading back to main menu.");
        Program.Main();
    }

    public static void SaveGoal(string new_goal, bool is_repeatable)
    {
        if (File.Exists("goalsaves.txt"))
        {
            Console.Clear();
            Console.Write("Save file found, will continue saving as normal.");
        }
        else
        {
            Console.Clear();
            Console.Write("The save file is missing, creating a new one.");
            File.Create("goalsaves.txt");
        }
        Thread.Sleep(200);
        Program.dot_loading_anim(3);
        
        string is_repeatable_string = ManageGoals.is_repeatable_to_string(is_repeatable);
        try
        {
            using(StreamWriter writetext = new StreamWriter("goalsaves.txt", true))
            {
                writetext.WriteLine(new_goal);
                writetext.WriteLine("Goal is repeatable: " + is_repeatable_string);
                writetext.WriteLine("Not completed.");
            }
        }
        catch
        {
            Console.WriteLine("File failed to load, this is some bug with creating a file and then saving to it in the same session. I don't think there is a way to solve it without full restart of program.");
            Thread.Sleep(1000);
        }
        
    }

    public static string is_repeatable_to_string(bool x)
    {
        if(x) return "True";
        return "False";
    }

    public static void ReadGoals()
    {
        Console.Clear();
        Console.WriteLine("Let's take a look at some of your past goals.");
        Program.dot_loading_anim(3);
        try
        {
            using(StreamReader readtext = new StreamReader("goalsaves.txt"))
            {
                string entire_document = readtext.ReadToEnd();
                Console.Clear();
                if(string.IsNullOrEmpty(entire_document))
                {
                    Console.WriteLine("The save file exists, but it is empty. Did you create any goals yet?");
                }
                else
                {
                    Console.WriteLine("Document successfully read.");
                }
            }
            MarkGoals("didn't need a string arg after all");
        }
        catch
        {
            Console.WriteLine("No goals created yet, create some first.");
            Thread.Sleep(5000);
            Program.Main();
        }
    }
    public static void MarkGoals(string entire_document)
    {
        Console.Clear();
        var savefile = File.ReadAllLines("goalsaves.txt");
        var saveinfolist = new List<string>(savefile);
        var goalinfo = new List<string>();
        var goaltype = new List<string>();
        var goalstatus = new List<string>();
        var iterate = 1;
        for(var i = 0; i < saveinfolist.Count; i++)
        {
            if(iterate == 1)
            {
                goalinfo.Add(saveinfolist[i]);
            }
            else if(iterate == 2)
            {
                goaltype.Add(saveinfolist[i]);
            }
            else
            {
                goalstatus.Add(saveinfolist[i]);
            }
            Thread.Sleep(20);
            iterate++;
            if(iterate == 4)
            {
                iterate = 1;
            }
        }
        for(var i = 0; i < goaltype.Count; i++)
        {
            int goalnum = i + 1;
            Console.WriteLine(goalnum.ToString() + " " + goalinfo[i] + " | " + goaltype[i] + " | " + goalstatus[i] + Environment.NewLine);
        }
        int inputint = 0;
        try
        {
            Console.WriteLine("Select goal");
            string inputvar = Console.ReadLine();
            inputint = Int32.Parse(inputvar);
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Invalid Selection");
            ManageGoals.MarkGoals(entire_document);
            MarkGoals(entire_document);
        }
        Console.Clear();
        Console.WriteLine(inputint.ToString() + " " + goalinfo[inputint] + " | " + goaltype[inputint] + " | " + goalstatus[inputint] + Environment.NewLine);
        Console.WriteLine("What would you like to do with this goal?");
        Console.WriteLine("1: Mark as completed");
        Console.WriteLine("2: Go back");
        string selectionvar = Console.ReadLine();
        if(selectionvar == "1")
        {
            LineEdit("Completed", "goalsaves.txt", inputint * 3);
            Program.Main();
        }
        else if(selectionvar == "2")
        {
            Console.WriteLine("Goal marked as complete.");
            Thread.Sleep(100);
            MarkGoals(entire_document);
        }
        else
        {
            Console.WriteLine("Invalid selection.");
            Thread.Sleep(100);
            MarkGoals(entire_document);
        }
    }

    static void LineEdit(string newText, string fileName, int line_to_edit)
    {
        string[] arrline = File.ReadAllLines(fileName);
        arrline[line_to_edit - 1] = newText;
        File.WriteAllLines(fileName, arrline);
    }
}
