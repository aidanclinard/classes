using system;
using System.Collections.Generic;

class program{


    var prompts = new List<string>{"What did you do today?", "What did you eat today?", "What was the best part of your day?", "If you had one extra thing you could do today, what would it be?"};

    int index = random.Next(prompts.Count);

    static void promptselect(prompts index){
        Console.WriteLine(prompts[index]);
    }

    static void inputs()
    {
        var time = DateTime.TimeOfDay;
        string response;
        cout << "Response here:";
        cin >> response;
        cout << "Your response and time logged here:" << response << time;
    }
}