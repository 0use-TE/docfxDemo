namespace ClassLibrary1;

/// <summary>
/// 提供数学计算相关的实用方法。
/// </summary>
public class MathHelper
{
    /// <summary>
    /// 将两个数相加。
    /// </summary>
    /// <param name="a">第一个加数</param>
    /// <param name="b">第二个加数</param>
    /// <returns>两个数的和</returns>
    public static int Add(int a, int b) => a + b;

    /// <summary>
    /// 计算两个数的乘积。
    /// </summary>
    /// <param name="a">第一个因数</param>
    /// <param name="b">第二个因数</param>
    /// <returns>两个数的乘积</returns>
    public static int Multiply(int a, int b) => a * b;
}
