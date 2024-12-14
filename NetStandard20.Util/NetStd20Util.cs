using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Global;

public static class NetStd20Util
{
    public static string AdjustStringNewlines(string text)
    {
        return text.Replace("\r\n", "\n").Replace("\r", "\n");
    }
    public static List<string> SplitTextIntoLines(string text)
    {
        //Echo(text);
        text = AdjustStringNewlines(text);
        //Echo(text);
        if (text.EndsWith("\n"))
        {
            text = text.Substring(0, text.Length - 1);
            //Echo(text);
        }
        var result = Regex.Split(text, "\r\n|\r|\n");
        //Echo(result);
        return result.ToList();
    }
}
