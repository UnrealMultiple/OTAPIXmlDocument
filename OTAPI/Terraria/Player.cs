using Terraria.ID;
using Terraria.DataStructures;

namespace Terraria;

/// <summary>玩家实体</summary>
public class Player : Entity, IFixLoadedData
{
    /// <summary>已死亡</summary>
    public bool dead;
    /// <summary>
    /// 玩家难度 <see cref="PlayerDifficultyID"/>
    /// </summary>
    public byte difficulty;
    /// <summary>当前生命值</summary>
    public int statLife;
    /// <summary>玩家生命上限(不包括生命力药水、饰品等额外增加的生命)</summary>
    public int statLifeMax;
    /// <summary>玩家生命上限(包括生命力药水、饰品等额外增加的生命)</summary>
    public int statLifeMax2;
    /// <summary>玩家当前魔力值</summary>
    public int statMana;
    /// <summary>玩家魔力上限(不包括水晶球、饰品等额外增加的魔力)</summary>
    public int statManaMax;
    /// <summary>玩家魔力上限(包括水晶球、饰品等额外增加的魔力)</summary>
    public int statManaMax2;
    /// <summary>
    /// 最大增益数量
    /// </summary>
    public static readonly int maxBuffs = 44;
    /// <summary>
    /// 免疫增益信息
    /// </summary>
    public bool[] buffImmune = new bool[BuffID.Count];
    /// <summary>
    /// 增益时间
    /// </summary>
    public int[] buffTime = new int[maxBuffs];
    /// <summary>
    /// 增益ID <see cref="BuffID"/>
    /// </summary>
    public int[] buffType = new int[maxBuffs];
    /// <summary>
    /// 垃圾桶物品
    /// </summary>
    public Item trashItem;
    /// <summary>
    /// <inheritdoc cref="ItemID.PiggyBank"/>
    /// </summary>
    public Chest bank;
    /// <summary>
    /// <inheritdoc cref="ItemID.Safe"/>
    /// </summary>
    public Chest bank2;
    /// <summary>
    /// <inheritdoc cref="ItemID.DefendersForge"/>
    /// </summary>
    public Chest bank3;
    /// <summary>
    /// <inheritdoc cref="ItemID.VoidLens"/>
    /// </summary>
    public Chest bank4;
    /// <summary>
    /// 背包
    /// </summary>
    public Item[] inventory;
    /// <summary>
    /// 盔甲和时装
    /// </summary>
    public Item[] armor;
    /// <summary>
    /// <see cref="armor"/>的染料
    /// </summary>
    public Item[] dye;
    /// <summary>
    /// 杂项(宠物 照明宠物 矿车 坐骑 钩爪)
    /// </summary>
    public Item[] miscEquips;
    /// <summary>
    /// <see cref="miscEquips"/>的染料
    /// </summary>
    public Item[] miscDyes;
    /// <summary>
    /// 附近的城镇NPC数量(虽然加的是<see cref="NPC.npcSlots"/>, 但是都是1)
    /// </summary>
    public float townNPCs;
    /// <inheritdoc cref="IFixLoadedData.FixLoadedData"/>
    public void FixLoadedData()
    {
        throw null;
    }
    /// <summary>
    /// 计算buff数量
    /// </summary>
    /// <returns></returns>
    public int CountBuffs()
    {
        throw null;
    }
    /// <summary>
    /// 计算<see cref="inventory"/>内的指定物品数量
    /// </summary>
    /// <param name="type"></param>
    /// <param name="stopCountingAt">最小数量(超过就return)</param>
    /// <returns></returns>
    public int CountItem(int type, int stopCountingAt = 0)
    {
        throw null;
    }
    /// <summary>
    /// 在<see cref="inventory"/>查找物品索引，找不到返回-1
    /// </summary>
    /// <param name="netid"></param>
    /// <returns></returns>
    public int FindItem(int netid)
    {
        throw null;
    }
    /// <summary>
    /// 在<see cref="inventory"/>查找任一物品索引，找不到返回-1
    /// </summary>
    /// <param name="netids"></param>
    /// <returns></returns>
    public int FindItem(List<int> netids)
    {
        throw null;
    }
    /// <summary>
    /// 在<see cref="inventory"/>查找任一物品索引，类似<see cref="FindItem(List{int})"/>，不过传的是 <see langword="bool"/>[<see cref="ItemID.Count"/>]
    /// </summary>
    /// <param name="validtypes"></param>
    /// <returns></returns>
    public int FindItem(bool[] validtypes)
    {
        throw null;
    }
    /// <summary>
    /// 有指定物品在<see cref="inventory"/>
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public bool HasItem(int type)
    {
        throw null;
    }
    /// <summary>
    /// 在<paramref name="collection"/>内有指定物品
    /// </summary>
    /// <param name="type"></param>
    /// <param name="collection"></param>
    /// <returns></returns>
    public bool HasItem(int type, Item[] collection)
    {
        throw null;
    }
    /// <summary>
    /// 有指定物品(查找全部个人存储和装备染料等)
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public bool HasItemInAnyInventory(int type)
    {
        throw null;
    }
    /// <summary>
    /// 有虚空袋(打开)
    /// </summary>
    /// <returns></returns>
    public bool useVoidBag()
    {
        throw null;
    }
    /// <summary>
    /// 在背包和虚空袋内查找物品索引
    /// </summary>
    /// <param name="type"></param>
    /// <param name="inVoidBag">在虚空袋</param>
    /// <returns>找到的索引，找不到返回-1，如何<paramref name="inVoidBag"/>是<see langword="true"/>，那是<see cref="bank4"/>内的索引</returns>
    public int FindItemInInventoryOrOpenVoidBag(int type, out bool inVoidBag)
    {
        throw null;
    }
    /// <summary>
    /// 有指定<paramref name="type"/>的npc在附近，受制于<see cref="NPC.npcsFoundForCheckActive"/>
    /// </summary>
    /// <param name="type"></param>
    /// <param name="range">搜范围，-1时为<see cref="NPC.sWidth"/></param>
    /// <returns></returns>
    public bool isNearNPC(int type, float range = -1f)
    {
        throw null;
    }
}
