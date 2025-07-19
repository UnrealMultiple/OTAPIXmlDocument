namespace Terraria.ID;
/// <summary>
/// 图格ID
/// </summary>
public class TileID
{
    /// <summary>
    /// 集合
    /// </summary>
    public static class Sets
    {
        /// <summary>
        /// 基础箱子(箱子样式 只有<see cref="Containers"/>和<see cref="Containers2"/>)
        /// </summary>
        public static bool[] BasicChest;
    }
    /// <summary>
    /// 容器(箱子)
    /// </summary>
    public const ushort Containers = 21;
    /// <summary>
    /// <inheritdoc cref="Containers"/>2
    /// </summary>
    public const ushort Containers2 = 467;
}
