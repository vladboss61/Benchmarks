namespace Benchmarks;

using System.Text;

public static class StringFunctions
{
    public static string ConcatWithString(int count)
    {
        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += "x";
        }
        return result;
    }

    public static string ConcatWithStringBuilder(int count)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            sb.Append("x");
        }
        return sb.ToString();
    }
}
