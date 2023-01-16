using System;
using System.Numerics;
using LearnCSharp.MyClassLib;
using NUnit.Framework;

namespace LearnCSharp.Tests;


[TestFixture]
public class AdventOfCode2015Tests
{

    [Test]
    [TestCase("(())", ExpectedResult = 0)]
    [TestCase("()()", ExpectedResult = 0)]
    [TestCase("(((", ExpectedResult = 3)]
    [TestCase("(()(()(", ExpectedResult = 3)]
    [TestCase("))(((((", ExpectedResult = 3)]
    [TestCase("())", ExpectedResult = -1)]
    [TestCase("))(", ExpectedResult = -1)]
    [TestCase(")))", ExpectedResult = -3)]
    [TestCase(")())())", ExpectedResult = -3)]
    public static int Day01p1Test(string input)
    {
        return AdventOfCode2015.Day01p1(input);
    }


    [Test]
    [TestCase(")", ExpectedResult = 1)]
    [TestCase("()())", ExpectedResult = 5)]
    public static int Day01p2Test(string input)
    {
        return AdventOfCode2015.Day01p2(input);
    }


    [Test]
    [TestCase("2x3x4", ExpectedResult = 58)]
    [TestCase("1x1x10", ExpectedResult = 43)]
    public static int Day02p1Test(string input)
    {
        return AdventOfCode2015.Day02p1(input);
    }

    [Test]
    [TestCase("2x3x4", ExpectedResult = 34)]
    [TestCase("1x1x10", ExpectedResult = 14)]
    public static int Day02p2Test(string input)
    {
        return AdventOfCode2015.Day02p2(input);
    }

    [Test]
    [TestCase(">", ExpectedResult = 2)]
    [TestCase("><>", ExpectedResult = 2)]
    [TestCase(">>", ExpectedResult = 3)]
    [TestCase(">>>", ExpectedResult = 4)]
    [TestCase("<<<", ExpectedResult = 4)]
    [TestCase("<<<>>>>", ExpectedResult = 5)]
    [TestCase("^>v<", ExpectedResult = 4)]
    [TestCase("^>v<^>v<", ExpectedResult = 4)]
    [TestCase("^>v<^>v<^>v<^>v<^>v<^>v<", ExpectedResult = 4)]
    [TestCase("^v^v^v^v^v", ExpectedResult = 2)]
    [TestCase("^v^^<^<^>>><v>vv>^<<", ExpectedResult = 16)]
    [TestCase(">^^v^<>v<<<v<v^>>v^^^<v<>^^><^<<^vv>>>^<<^>>", ExpectedResult = 28)]
    public static int Day03p1Test(string input)
    {
        return AdventOfCode2015.Day03p1(input);
    }

    [Test]
    [TestCase("^v", ExpectedResult = 3)]
    [TestCase("^>v<", ExpectedResult = 3)]
    [TestCase("^v^v^v^v^v", ExpectedResult = 11)]
    public static int Day03p2Test(string input)
    {
        return AdventOfCode2015.Day03p2(input);
    }

    // [Test]
    // [TestCase("abcdef", "00000", ExpectedResult = 609043)]
    // [TestCase("abcdef", "000000", ExpectedResult = 6742839)]
    // [TestCase("pqrstuv", "00000", ExpectedResult = 1048970 )]
    // public static BigInteger Day04p1Test(string input, string prefix)
    // {
    //     return AdventOfCode2015.Day04p1p2(input, prefix);
    // }

    [Test]
    [TestCase("ugknbfddgicrmopn", ExpectedResult = "nice")]
    [TestCase("aaa", ExpectedResult = "nice")]
    [TestCase("jchzalrnumimnmhp", ExpectedResult = "naughty")]
    [TestCase("haegwjzuvuyypxyu", ExpectedResult = "naughty")]
    [TestCase("dvszwmarrgswjxmb", ExpectedResult = "naughty")]
    public static string Day05p1Test(string input)
    {
        return AdventOfCode2015.Day0501(input);
    }

    [Test]
    [TestCase("qjhvhtzxzqqjkmpb", ExpectedResult = "nice")]
    [TestCase("xxyxx", ExpectedResult = "nice")]
    [TestCase("xyxy", ExpectedResult = "nice")]
    [TestCase("uurcxstgmygtbstg", ExpectedResult = "naughty")]
    [TestCase("ieodomkazucvgmuy", ExpectedResult = "naughty")]
    public static string Day05p2Test(string input)
    {
        return AdventOfCode2015.Day0502(input);
    }
}