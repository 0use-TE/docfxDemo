namespace ClassLibrary2;

/// <summary>
/// 字符串处理的工具类，提供各种字符串操作方法。
/// </summary>
public class StringHelper
{
    /// <summary>
    /// 将给定字符串反转后返回。
    /// </summary>
    /// <param name="input">要反转的输入字符串</param>
    /// <returns>反转后的字符串。如果输入为 null，则返回空字符串。</returns>
    /// <example>
    /// <code>Reverse("hello") // 返回 "olleh"</code>
    /// </example>
    public static string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    /// <summary>
    /// 判断字符串是否为回文（正读和反读都相同）。
    /// </summary>
    /// <param name="input">要检查的字符串</param>
    /// <returns>如果字符串是回文返回 true，否则返回 false</returns>
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        string reversed = Reverse(input);
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}
