using Terraria.Utilities;

namespace Terraria;

/// <summary>
/// 工具类
/// </summary>
public static class Utils
{
    /// <summary>
    /// 计算<paramref name="inv"/>内忽略<paramref name="ignoreSlots"/>索引的钱币值
    /// </summary>
    /// <param name="overFlowing">暂时没用</param>
    /// <param name="inv"></param>
    /// <param name="ignoreSlots"></param>
    /// <returns></returns>
    public static long CoinsCount(out bool overFlowing, Item[] inv, params int[] ignoreSlots)
    {
        throw null;
    }
    /// <summary>
    /// 是有效索引
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    public static bool IndexInRange<T>(this T[] t, int index)
    {
        throw null;
    }
    /// <summary>
    /// 是有效索引
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    public static bool IndexInRange<T>(this List<T> t, int index)
    {
        throw null;
    }
    /// <summary>
    /// 用返回<paramref name="random"/>生成的值返回<paramref name="choices"/>中的一个元素
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="random"></param>
    /// <param name="choices"></param>
    /// <returns></returns>
    public static T SelectRandom<T>(UnifiedRandom random, params T[] choices)
    {
        throw null;
    }
}
