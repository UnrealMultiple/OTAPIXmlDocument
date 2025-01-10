using Terraria.DataStructures;

namespace Terraria;

/// <summary>玩家实体</summary>
public class Player : Entity, IFixLoadedData
{
    /// <summary>已死亡</summary>
    public bool dead;
    /// <summary>
    /// 难度
    /// 0 软核
    /// 1 中核
    /// 2 硬核
    /// 3 旅途
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

    public void FixLoadedData()
    {
        throw null;
    }
}
