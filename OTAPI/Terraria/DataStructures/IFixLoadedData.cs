namespace Terraria.DataStructures;

/// <summary>
/// 可修复已加载的数据
/// </summary>
public interface IFixLoadedData
{
    /// <summary>
    /// 修复已加载的数据(比如物品堆叠超最大堆叠)
    /// </summary>
    void FixLoadedData();
}
