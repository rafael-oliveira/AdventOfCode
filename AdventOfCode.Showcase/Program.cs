using LearnCSharp.MyClassLib;

class Program
{
    static void Main(string[] args)
    {
        RunDay5();
        System.Console.WriteLine("Finished!");

    }

    private static void RunDay5()
    {
        var input = File.ReadAllLines(@"../../../Desktop/input-5.1.txt");
        int niceWords = 0;

        foreach (var str in input)
        {
            var result = AdventOfCode2015.Day0501(str);
            if (result == "nice")
                niceWords++;
        }

        System.Console.WriteLine(niceWords);
    }
}
