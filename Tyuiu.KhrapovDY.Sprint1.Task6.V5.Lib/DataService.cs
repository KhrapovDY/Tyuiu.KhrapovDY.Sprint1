using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhrapovDY.Sprint1.Task6.V5.Lib;

public class DataService : ISprint1Task6V5
{
    public string CheckSymmetricalWords(string value)
    {
        value = value.ToLower();
        value = Regex.Replace(value, "[-.?!)(,:;'[0-9\\]]", "");
        string[] words = value.Split(' ');
        string res = new string(" ");
        foreach (string word in words)
        {
            string reverse = new string(word.Reverse().ToArray());
            if (string.Compare(word, reverse) == 0)
            {
                res = res + string.Concat(", ", word);
            }
        }
        return res == " " ? "Симметричных слов нет" : res.Remove(0, 3);
    }
}