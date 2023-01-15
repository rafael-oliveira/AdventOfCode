using NUnit.Framework;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
namespace LearnCSharp.MyClassLib;

public static class AdventOfCode2015
{
    //day 1
    public static int Day01p1(string input)
    {
        var floors = input.ToArray();
        var floorNumber = 0;
        for (int i = 0; i < floors.Length; i++)
        {
            if (floors[i] == '(')
                floorNumber++;
            else
                floorNumber--;

        }
        return floorNumber;
    }

    public static int Day01p2(string input)
    {
        var floors = input.ToArray();
        var floorNumber = 0;
        for (int i = 0; i < floors.Length; i++)
        {
            if (floors[i] == '(')
                floorNumber++;
            else
                floorNumber--;

            if (floorNumber == -1)
                return i + 1;
        }
        return 0;
    }

    //day 2
    public static int Day02p1(string input)
    {
        //l*w*h
        //2x3x4
        //2*l*w + 2*w*h + 2*h*l
        int l = 0, w = 0, h = 0;
        l = int.Parse(input.Split("x")[0]);
        w = int.Parse(input.Split("x")[1]);
        h = int.Parse(input.Split("x")[2]);

        var areas = new List<int>();
        var side1 = 2 * l * w;
        var side2 = 2 * w * h;
        var side3 = 2 * h * l;

        areas.Add(side1 / 2);
        areas.Add(side2 / 2);
        areas.Add(side3 / 2);

        var result = side1 + side2 + side3 + areas.Min();
        return result;

    }

    public static int Day02p2(string input)
    {
        //l*w*h
        //2x3x4
        //2*l*w + 2*w*h + 2*h*l
        int l = 0, w = 0, h = 0;
        l = int.Parse(input.Split("x")[0]);
        w = int.Parse(input.Split("x")[1]);
        h = int.Parse(input.Split("x")[2]);

        var areas = new List<int>();
        var dimensions = new List<int>() { l, w, h };
        dimensions.Sort();
        var dim1 = dimensions[0];
        var dim2 = dimensions[1];

        var ribbonLength = 2 * dim1 + 2 * dim2 + (l * w * h);

        return ribbonLength;

    }

    //day 3
    public static int Day03p1(string coordinates)
    {
        var x = 0;
        var y = 0;

        var seen = new HashSet<(int, int)>();
        seen.Add((0, 0));
        for (int i = 0; i < coordinates.Length; i++)
        {
            var direction = coordinates[i].ToString();
            switch (direction)
            {
                case "^":
                    y++;
                    break;
                case "v":
                    y--;
                    break;
                case "<":
                    x--;
                    break;
                case ">":
                    x++;
                    break;
            }
            seen.Add((x, y));
        }
        return seen.Count;
    }

    public static int Day03p2(string coordinates)
    {
        var x = 0;
        var y = 0;

        var x2 = 0;
        var y2 = 0;

        var seen = new HashSet<(int, int)>();
        seen.Add((0, 0));
        for (int i = 0; i < coordinates.Length; i++)
        {
            var direction = coordinates[i].ToString();
            switch (direction)
            {
                case "^":
                    if (i % 2 == 0)
                        y++;
                    else
                        y2++;
                    break;
                case "v":
                    if (i % 2 == 0)
                        y--;
                    else
                        y2--;
                    break;
                case "<":
                    if (i % 2 == 0)
                        x--;
                    else
                        x2--;
                    break;
                case ">":
                    if (i % 2 == 0)
                        x++;
                    else
                        x2++;
                    break;
            }

            if (i % 2 == 0)
                seen.Add((x, y));
            else
                seen.Add((x2, y2));

        }
        return seen.Count;
    }

    public static BigInteger Day04p1p2(string input, string prefix)
    {
        BigInteger reallyBigInt = new BigInteger(0);
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            while (true)
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input + reallyBigInt);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                var stringResult = Convert.ToHexString(hashBytes);
                if (stringResult.StartsWith(prefix))
                    break;

            }
        }
        return reallyBigInt;
    }

    public static string Day0501(string input)
    {
        var threeVowelsPattern = @"[aeiou]";
        var doubleLetterPattern = @"([\D])\1+";
        var stringsToAvoidPattern = @"ab|cd|pq|xy";

        if (Regex.IsMatch(input, threeVowelsPattern) && Regex.Matches(input, threeVowelsPattern).Count >= 3 &&
                Regex.IsMatch(input, doubleLetterPattern) && !Regex.IsMatch(input, stringsToAvoidPattern))

            return "nice";

        return "naughty";
    }

    public static string Day0502(string input)
    {
        var appearsTwice = false;
        var validRepeats = false;

        appearsTwice = Enumerable.Range(0, input.Length - 1).Any(i => input.IndexOf(input.Substring(i, 2), i + 2) >= 0);
        validRepeats = Enumerable.Range(0, input.Length - 2).Any(i => input[i] == input[i + 2]);

        return appearsTwice && validRepeats ? "nice" : "naughty";
    }
}