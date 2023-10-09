namespace test;

using System.Text;
using Newtonsoft.Json;
using personalname;

public static class StringHelper
{
    /* Only because of CS0116 */

    public static string ToCSharpStyleName(string name)
    {
        /* Convert lower_case_underscored name to CSharpStyleCamelCaps style */
        var sb = new StringBuilder();
        foreach(var s in name.Split('_', StringSplitOptions.RemoveEmptyEntries))
        {
            if(s == "str") {
                sb.Append("String");
            } else {
                sb.Append($"{s.Substring(0,1).ToUpper()}{s.Substring(1)}");
                // PROTIP: string s[0] returns a char,
                // which is incompatible with String methods.
            }
        }
        return sb.ToString();
    }
}

public static class TestExceptions
{
    public static readonly Dictionary<string,Exception> exceptions = new Dictionary<string, Exception>()
    {
        {"any", new Exception()},
        {"arithmetic", new ArithmeticException()},
        {"index", new IndexOutOfRangeException()},
        {"key", new KeyNotFoundException()},
        {"type", new Exception("Unexpected Type")},
        {"value", new Exception("Invalid Value")},
    };
     // TODO: what's the C# equivalent of Python's TypeError?
     // I don't think there is any due to C#'s type strictness
     // where errors of type are complier, not runtime errors.
}

public class Tests
{
    /* Self Tests */
    [Fact]
    public void ToCSharpStyleNameTests()
    {
        var TEST_DATA = new Dictionary<string, string>()
        {
            {"lower_case_underscore", "LowerCaseUnderscore"},
            {"g_str", "GString"},
            {"render_4K_120fps", "Render4K120fps"},
            {"render_4K_120_fps", "Render4K120Fps"}
        };
        foreach(var k in TEST_DATA.Keys)
        {
            Assert.Equal(TEST_DATA[k], StringHelper.ToCSharpStyleName(k));
        }
    }

    /* PNTK Tests */
    [Fact]
    public void PersonalNameTests()
    {
    }
}
