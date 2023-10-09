/* Personal Name Class for C#.NET
 *
 * For more information, please check the Python Reference Implementation
 * at https://github.com/mounaiban/personalname
 *
 * Licensed under the terms and conditions of the GNU
 * Lesser General Public license, version 3 or later.
 *
 * (C)2023 by Moses Chong
 *
 */

namespace personalname;

public class PersonalName
{
	private readonly string CONFIG_SEP = "\u003B";	// ASCII semicolon
	private readonly string CONFIG_KV_SEP = "\u003D";	// ASCII equals
	private readonly Dictionary<string, string> CONFIG_DEFAULT = new Dictionary<string, string>()
	{
		{"ALED", "\u0029"}, // Alt. name list end: )
		{"ALSE", "\u002C"}, // Alt. name list sep.: ,
		{"ALST", "\u0028"}, // Alt. name list start: (
		{"MNSP", "\u0020"}, // Main name space: ASCII Space
		{"MNSU", "\u005F"}  // Main name Space Subst.: _
	};
	private readonly string OUT_DEFAULT = ""; // value for invalid indexes
	private readonly string[] INDEXES_MAIN_NAME = new string[]
	{
		"N1",
		"NM",
		"NS",
        /* */
        "F1",
        "FD",
        "FN",
        "FS",
        "M1",
        "MD",
        "MN",
        "MS",
        "OA",
        "OR",
        "S1",
        "SD",
        "SN",
        "SS",
        "SX"
	};
	private readonly string NICKNAME_PREFIX = "NN";
	private readonly string NICKNAME_NET_DELIM = "\u003A";	// ASCII Colon
	private readonly string NOT_PRESENT = "";

    /* User-configurables */
    private Dictionary<string, string>config;
    private Dictionary<string, string> TranslationDictionary;
    private Dictionary<string, string> TranslationDictionaryInput;
    private int AltNamesStartIndex;
    private int AltNamesEndIndex;
    // TODO: run SetConfig to set the above

    public string ToString()
    {
        throw new NotImplementedException();
    }

    protected void SetConfig(Dictionary<string, string> config)
    {
        throw new NotImplementedException();
    }

    public string GetConfigString()
    {
        throw new NotImplementedException();
    }

    public int CountMainNameElements()
    {
        throw new NotImplementedException();
    }

    public int CountAltNames()
    {
        throw new NotImplementedException();
    }

    public Dictionary<string, string> ParseConfig(string config)
    {
        throw new NotImplementedException();
    }

    public string GetFormattedName(string fmt)
    {
        throw new NotImplementedException();
    }

    public string GetMainNameElement(int i)
    {
        throw new NotImplementedException();
    }

    public string GetMainNameElementsAsString(int s, int e, string sep)
    {
        throw new NotImplementedException();
    }

    public string GetMainNameElementType(string el)
    {
        throw new NotImplementedException();
    }

    public string GetAltName(int i=1)
    {
        throw new NotImplementedException();
    }

    public string GetMainName()
    {
        throw new NotImplementedException();
    }

    public string GetMainNameNosp()
    {
        throw new NotImplementedException();
    }
}
