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
    /// <inheritdoc cref="IFixLoadedData.FixLoadedData"/>
    public void FixLoadedData()
    {
        throw null;
    }
}
