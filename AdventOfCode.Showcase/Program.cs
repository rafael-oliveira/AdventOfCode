using LearnCSharp.MyClassLib;
using System.Text;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
         NewMethod();

    }


    private static void NewMethod()
    {
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            BigInteger bigInt_Double = new BigInteger(0);
            
            while(true)
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("abcdef" + bigInt_Double);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                var stringResult = Convert.ToHexString(hashBytes);
                if (stringResult.StartsWith("000000"))
                {
                    System.Console.WriteLine("yzbqklnj" + bigInt_Double);
                    System.Console.WriteLine(stringResult);
                    System.Console.WriteLine(bigInt_Double);
                    break;
                }
                bigInt_Double++;
            }
        }
    }
}
