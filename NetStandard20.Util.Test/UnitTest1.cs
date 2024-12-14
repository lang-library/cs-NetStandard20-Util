using System;
using System.Collections.Generic;
using System.Linq;
using Global;
using static Global.EasyObject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setup() called");
        ClearSettings();
    }

    [Test]
    public void Test01()
    {
        ShowDetail = true;
        string text = "abc\ndef\r\nghi\r\n";
        var result = NetStd20Util.SplitTextIntoLines(text);
        Echo(result);
        Assert.That(EasyObject.FromObject(result).ToJson(), Is.EqualTo(
            """
            ["abc","def","ghi"]
            """
            ));
    }
}