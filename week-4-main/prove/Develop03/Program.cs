using System;
class Program {
    public static void Main(string[] args)
    {
        List<string> scripturelist = new List<string> {"John 3:16", "Proverbs 3:5", "Numbers 20:24", "Jacob 4:6"};
        List<string> scripturecontent = new List<string> {"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", "Trust in the Lord with all thine heart; and lean not unto thine own understanding.", "Aaron shall be gathered unto his people: for he shall not enter into the land which I have given unto the children of Israel, because ye rebelled against my word at the water of Meribah.", "Wherefore, we search the prophets, and we have many revelations and the spirit of aprophecy; and having all these witnesses we obtain a hope, and our faith becometh unshaken, insomuch that we truly can command in the name of Jesus and the very trees obey us, or the mountains, or the waves of the sea."};
        var random = new Random();
        int selectedscrip = random.Next(scripturelist.Count);
        string selscrip = scripturelist[selectedscrip];
        var selscripcontent = scripturecontent[selectedscrip];
        string continuedialogue = "Would you like to continue? y/n";
        Console.WriteLine(selscrip);
        Console.WriteLine(selscripcontent);
        continuedialogue = "Would you like to continue? y/n";
        Console.WriteLine(continuedialogue);
        string keepgoing = Console.ReadLine();
        List<string> splitscrip = new List<string>(selscripcontent.Split()).Distinct().ToList();
        while(keepgoing == "y")
        {
            var randomword = splitscrip[random.Next(splitscrip.Count)];
            splitscrip.Remove(randomword);
            Console.WriteLine(randomword);
            Console.WriteLine(selscrip);
            var revisedscrip = selscripcontent.Replace(randomword, "____");
            selscripcontent = revisedscrip;
            Console.WriteLine(selscripcontent);
            
            Console.WriteLine(continuedialogue);
            keepgoing = Console.ReadLine();
        }
    }
}