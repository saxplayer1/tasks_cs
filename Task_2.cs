using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace tasks
{
    public class Task_2
    {
        // public static void Main(string[] args)
        // {
        //     StreamReader text = new StreamReader("D:/tasks/Resources/TextFileTask2.txt");
        //     StringBuilder sb = new StringBuilder();
        //     var line = text.ReadLine();
        //     while (line != null)
        //     {
        //         sb.Append(line);
        //         line = text.ReadLine();
        //     }
        //     text.Close();
        //     string pattern = "\\W";
        //     string input = sb.ToString();
        //     
        //     Console.WriteLine(input);
        //     input = Regex.Replace(input, pattern, " ",
        //         RegexOptions.IgnoreCase);
        //     string[] words = input.Split(' ');
        //
        //     var resultMap = new Dictionary<int, ArrayList>();
        //     foreach (var word in words)
        //     {
        //         if (!resultMap.ContainsKey(word.Length))
        //         {
        //             resultMap.Add(word.Length, new ArrayList());
        //         }
        //         resultMap[word.Length].Add(word);
        //         Console.WriteLine($"<{word}>");
        //     }
        //
        //     StreamWriter sw = new StreamWriter("D:/tasks/Resources/ResultFileTask2.txt");
        //     foreach (var key in resultMap.Keys)
        //     {
        //         sw.WriteLine(resultMap[key].Count + " words where length = " + key);
        //         Console.WriteLine(resultMap[key].Count + " words where length = " + key);
        //     }
        //     sw.Close();
        // }
    }
}