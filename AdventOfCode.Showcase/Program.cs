using LearnCSharp.MyClassLib;

class Program
{
    static void Main(string[] args)
    {

        var input = File.ReadAllLines(@"../../../Desktop/input-5.1.txt");
        int i = 0;
        int j = 0;
        foreach (var str in input)
        {
            var result = AdventOfCode2015.Day0502(str);
            if (result == "nice")
                {
                    i++;
                }
                j++;
        }

        System.Console.WriteLine(i);
        System.Console.WriteLine(j);
        System.Console.WriteLine("Finished!");

    }
}
