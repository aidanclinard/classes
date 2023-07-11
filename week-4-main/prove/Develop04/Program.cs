using System;

class Program
{
        static void Main(){
        Console.Clear();
        Console.WriteLine("Welcome, your activities will be laid out here.");
        Animations.dot_loaidng_anim(3);
        Console.Clear();
        Console.WriteLine("Where would you like to start?");
        Thread.Sleep(500);
        Console.WriteLine("1: Breathing excercises");
        Thread.Sleep(100);
        Console.WriteLine("2: Reflection");
        Thread.Sleep(100);
        Console.WriteLine("3: Funny Math Game");
        Thread.Sleep(100);
        Console.WriteLine(":)");
        string strchoice = Console.ReadLine();
        int choice = 123;
        try{
            choice = Convert.ToInt32(strchoice);
        }
        catch{
            Console.WriteLine("Incorrect selection");
        }
        if(choice == 1){
            Games.breathing_exercises();
        }
        if(choice == 2){
            Games.reflection();
        }
        if(choice == 3){
            Games.math_game();
        }
        if(choice != 1 && choice != 2 && choice != 3){
            Console.WriteLine("Incorrect selection");
        }
    }
}
class Games
{
   public static void math_game(){
        Console.Clear();
        Console.WriteLine("Let's work our math skills.");
        Thread.Sleep(1000);
        Console.WriteLine("I will ask you twenty math questions, try to answer as fast as possible. There is no time limit, so try to get them correct.");
        Animations.dot_loaidng_anim(4);
        for(int i = 0; i < 20; i++)
        {
            Random rnd = new Random();
            int mathoperationint = rnd.Next(1, 5);
            int firstnum = rnd.Next(1, 13);
            int lastnum = rnd.Next(1, 13);
            string question = "Something went wrong";
            int answer = 333333333;
            if(mathoperationint == 1){
                answer = firstnum + lastnum;
                question = firstnum + " + " + lastnum;
            }
            if(mathoperationint == 2){
                answer = firstnum - lastnum;
                question = firstnum + " - " + lastnum;
            }
            if(mathoperationint == 3){
                answer = firstnum / lastnum;
                question = firstnum + " / " + lastnum;
            }
            if(mathoperationint == 4){
                answer = firstnum * lastnum;
                question = firstnum + " * " + lastnum;
            }
            Console.Clear();
            Console.WriteLine(question);
            string numstring = Console.ReadLine();
            int userresponse = 5252;
            try{
                userresponse = Convert.ToInt32(numstring);
                if(answer == userresponse){
                    Console.WriteLine("That is correct!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else{
                    Console.WriteLine("Whoops, that was incorrect. Keep going!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            catch{
                Console.WriteLine("Not even close.");
                Thread.Sleep(1000);
                Console.Clear();
            }
            
        }
        Console.WriteLine("Excellent work! When you are ready, you can press any key to exit. See you next time!");
        Console.ReadKey();
    }  
    public static void reflection(){
        Console.Clear();
        Console.WriteLine("Welcome to reflection, I will ask you a question about your day so I can log it for you. Don't think too hard about it.");
        Animations.dot_loaidng_anim(3);
        Console.Clear();
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
        Console.WriteLine("Thanks for your response! Here are your previous responses:");
        string journallog = File.ReadAllText("journal.txt");
        Console.WriteLine(journallog);
        Animations.dot_loaidng_anim(4);
        Console.WriteLine("When you are ready, you can press any key to exit. See you next time!");
        Console.ReadKey();
    }    
    public static void breathing_exercises(){
        Console.Clear();
        Console.WriteLine("Welcome to the breathing exercises activity.");
        Thread.Sleep(1000);
        Console.WriteLine("I will tell you to either inhale or exhale. This will help you calm down.");
        Animations.dot_loaidng_anim(3);
        Console.Clear();
        Console.WriteLine("Let's begin.");
        Thread.Sleep(1000);
        Console.Clear();
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Inhale");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("Exhale");
            Thread.Sleep(4000);
            Console.Clear();
        }
        Console.WriteLine("Excelent work, press any key when you are ready to exit.");     
        Console.ReadKey();   
    }
}

class Animations
{

    public static void dot_loaidng_anim(int count){
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