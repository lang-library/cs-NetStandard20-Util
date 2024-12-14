using Global;
using static Global.EasyObject;

class Program
{
    static void Main()
    {
        ShowDetail = true;
        string text = "abc\ndef\r\nghi\r\n";
        var result = Util.SplitTextIntoLines(text);
        Echo(result);

    }
}