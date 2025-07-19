namespace Terraria;
/// <summary>
/// 世界信息
/// </summary>
public class WorldGen
{
    /// <summary>
    /// 世界大小
    /// </summary>
    public static class WorldSize
    {
        /// <summary>
        /// 小
        /// </summary>
        public const int Small = 0;
        /// <summary>
        /// 中
        /// </summary>
        public const int Medium = 1;
        /// <summary>
        /// 大
        /// </summary>
        public const int Large = 2;
    }
    /// <summary>
    /// 获取世界大小
    /// </summary>
    /// <returns><see cref="WorldSize"/></returns>
    public static int GetWorldSize() => 0;
}
