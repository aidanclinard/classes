using System;

class Program
{
    static void Main(string[] args)
    {
        bool exitbool = false;
        while (exitbool == false){
          
            Console.WriteLine("Select one of the following options:");
            Console.WriteLine("1:Write");
            Console.WriteLine("2:Display");
            Console.WriteLine("3:Quit");
            
            string optionSelected = Console.ReadLine();
            try
            {
                int revisedoption = Convert.ToInt16(optionSelected);
                if(revisedoption == 1)
                {
                    Write();
                }   
                if(revisedoption == 2)
                {
                    Display();
                }
                if(revisedoption == 3)
                {
                    exitbool = true;
                }
                else
                {
                    Console.WriteLine("You did not input a proper response.");
                }
            }
            catch
            {
                Console.WriteLine("Not a valid input");
            } 
        } 
    }

    static void Write(){
    var prompts = new List<string>{"What did you do today?", "What did you eat today?", "What was the best part of your day?", "If you had one extra thing you could do today, what would it be?"};

    Random rnd = new Random();

    int index = rnd.Next(prompts.Count);

    Console.WriteLine(prompts[index]);
    string input = Console.ReadLine();
        File.AppendAllText("journal.txt", "-----------------------------" + Environment.NewLine);
        File.AppendAllText("journal.txt",DateTime.Now.ToString() + Environment.NewLine);
        File.AppendAllText("journal.txt",prompts[index] + Environment.NewLine);
        File.AppendAllText("journal.txt",input + Environment.NewLine);
        File.AppendAllText("journal.txt","-----------------------------" + Environment.NewLine);
    Console.WriteLine("Thanks for your input! Now returning to the main menu.");
    }

    static void Display(){
        string journallog = File.ReadAllText("journal.txt");
        Console.WriteLine(journallog);
        Console.WriteLine("Journal displayed.");
    }
}