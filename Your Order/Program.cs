// See https://aka.ms/new-console-template for more information

using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    public static string Order(string words)
    {
        Regex reg = new Regex(@"[0-9]");
        List<string> strings = words.Split(" ").ToList();
        string[] finished = new string[strings.Count]; 


        for(int i = 0; i < strings.Count; i++)
        {
            string word = strings[i];
            
            var mat = Regex.Match(word, @"[0-9]");
            int index = mat.Index;
            char c = word[index];
            int num = (int) Char.GetNumericValue(c);

            finished[num - 1] = word;
        }

        return String.Join(" ", finished);
    }


    static void Main(string[] args)
    {
        string s = "T3est is1 2a Thi4s";
        Console.WriteLine(Order(s));
    }
}