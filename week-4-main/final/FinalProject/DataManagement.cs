using System;

public class DataManagement
{


    public static void Write_to_file(string input, string destination)
    {
        using (StreamWriter write = File.AppendText(destination))
        {
            write.WriteLine(input);
            write.Close();
        }
    }


    public static List<string> Read_from_file_to_list(string file)
    {
        List<string> output = File.ReadAllLines(file).ToList();
        return output;
    }

    public static void Data_edit(string newdata, string file, int line_to_edit)
    {
        string[] line = File.ReadAllLines(file);
        line[line_to_edit - 1] = newdata;
        File.WriteAllLines(file, line);
    }
}