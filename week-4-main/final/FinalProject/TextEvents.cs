using System;

public class TextEvents
{
    public static void Menu(int menuselect)
    {

        if(menuselect == 1)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the character profiler.");
            Thread.Sleep(3000);
            Console.Clear();
            Load_anim(10);
            Console.WriteLine("What would you like to do?");
            Indent(3);
            Console.WriteLine("Add a new character to the database   :|:    1");
            Thread.Sleep(100);
            Indent(1);
            Thread.Sleep(100);
            Console.WriteLine("View existing characters              :|:    2");
            Thread.Sleep(100);
            Indent(1);
            Thread.Sleep(100);
            Console.WriteLine("Modify character data                 :|:    3");
            Thread.Sleep(100);
            Indent(1);
            Thread.Sleep(100);
            Console.WriteLine("Exit                                  :|:    4");
        }
        else if(menuselect == 2)
        {
            Console.Clear();
            Console.WriteLine("Adding a new character to the database.");
            Thread.Sleep(1000);
            Console.Clear();
            Load_anim(10);
            Console.WriteLine("First, put the character's name here:");
            string char_name = Console.ReadLine();
            DataManagement.Write_to_file(char_name, "char_name.txt");
            Console.WriteLine("Now, where do they live?");
            string char_place = Console.ReadLine();
            DataManagement.Write_to_file(char_place, "char_place.txt");
            Console.WriteLine("Lastly, put any more information here:");
            string char_bio = Console.ReadLine();
            DataManagement.Write_to_file(char_bio, "char_bio.txt");
            Console.WriteLine("Character info successfully added to the database! Returning to main menu.");
            Thread.Sleep(1000);
            Program.Main();
        }
        else if(menuselect == 3)
        {
            Console.Clear();
            Console.WriteLine("Viewing existing characters in the database.");
            Thread.Sleep(1000);
            Console.Clear();
            List<string> char_names = DataManagement.Read_from_file_to_list("char_name.txt");
            List<string> char_places = DataManagement.Read_from_file_to_list("char_place.txt");
            List<string> char_bios = DataManagement.Read_from_file_to_list("char_bio.txt");
            for(var i = 0; i < char_names.Count; i++)
            {
                Console.WriteLine(char_names[i]);
                Console.WriteLine(char_places[i]);
                Console.WriteLine(char_bios[i]);
                Indent(1);
            }
            Console.ReadLine();
            Program.Main();
        }
        else if(menuselect == 4)
        {
            Console.WriteLine("Modifying character data.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Which entry do you want to edit?");
            List<string> char_names = DataManagement.Read_from_file_to_list("char_name.txt");
            bool correct_selection = false;
            for(var i = 0; i < char_names.Count; i++)
            {
            Console.WriteLine(char_names[i] + i.ToString());
            Indent(1);
            }
            int selection_int = 0;
            while(correct_selection == false)
            {
                try
                {
                string selection = Console.ReadLine();
                selection_int = Convert.ToInt16(selection);
                correct_selection = true;
                }   
                catch
                {
                Console.WriteLine("Incorrect selection.");
                Thread.Sleep(2000);
                }
            }
            Console.WriteLine("First, put the character's name here:");
            string char_name = Console.ReadLine();
            DataManagement.Data_edit(char_name, "char_name.txt", selection_int);
            Console.WriteLine("Now, where do they live?");
            string char_place = Console.ReadLine();
            DataManagement.Data_edit(char_place, "char_place.txt", selection_int);
            Console.WriteLine("Lastly, put any more information here:");
            string char_bio = Console.ReadLine();
            DataManagement.Data_edit(char_bio, "char_bio.txt", selection_int);
            Console.WriteLine("Character info successfully edited in the database! Returning to main menu.");
            Thread.Sleep(1000);
            Program.Main();
        }
        else if(menuselect == 5)
        {
            Console.WriteLine("Bye Bye");
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("No menu under this ID.");
            Program.Main();
        }


    }

    public static void Load_anim(int repeats)
    {
        for (int i = 0; i < repeats; i++)
        {
            Console.WriteLine("/");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("-");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("\\");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("|");
            Thread.Sleep(100);
            Console.Clear();
        }
    }

    public static void Indent(int repeats)
    {
        for (int i = 0; i < repeats; i++)
        {
            Console.WriteLine(".");
        }
    }
}