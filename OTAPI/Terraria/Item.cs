using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.Xna.Framework;

using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Utilities;

namespace Terraria;

/// <summary>
/// 物品
/// </summary>
public class Item : Entity
{
    /// <summary>
    /// <inheritdoc cref="ItemID.CopperCoin"/> 的价格
    /// </summary>
    public const int copper = 1;
    /// <summary>
    /// <inheritdoc cref="ItemID.SilverCoin"/> 的价格
    /// </summary>
    public const int silver = 100;
    /// <summary>
    /// <inheritdoc cref="ItemID.GoldCoin"/> 的价格
    /// </summary>
    public const int gold = 10000;
    /// <summary>
    /// <inheritdoc cref="ItemID.PlatinumCoin"/> 的价格
    /// </summary>
    public const int platinum = 1000000;
    /// <summary>
    /// 普通物品的最大堆叠，现为9999，旧为999
    /// </summary>
    public static int CommonMaxStack;
    /// <summary>
    /// 使用时生成的npc <see cref="NPCID"/>
    /// </summary>
    public short makeNPC;
    /// <summary>
    /// 是专家物品
    /// </summary>
    public bool expert;
    /// <summary>
    /// id <see cref="ItemID"/>
    /// </summary>
    public int type;
    /// <summary>
    /// 是饰品
    /// </summary>
    public bool accessory;
    /// <summary>
    /// 使用一次的动画时间
    /// </summary>
    public int useAnimation;
    /// <summary>
    /// 使用一次的时间
    /// </summary>
    public int useTime;
    /// <summary>
    /// 堆叠数量
    /// </summary>
    public int stack;
    /// <summary>
    /// 最大堆叠数量
    /// </summary>
    public int maxStack;
    /// <summary>
    /// 镐力
    /// </summary>
    public int pick;
    /// <summary>
    /// 斧力
    /// </summary>
    public int axe;
    /// <summary>
    /// 锤力
    /// </summary>
    public int hammer;
    /// <summary>
    /// 创建的图格ID
    /// </summary>
    public int createTile;
    /// <summary>
    /// 创建的墙ID
    /// </summary>
    public int createWall;
    /// <summary>
    /// 伤害
    /// </summary>
    public int damage;
    /// <summary>
    /// 击退
    /// </summary>
    public float knockBack;
    /// <summary>
    /// 恢复血量
    /// </summary>
    public int healLife;
    /// <summary>
    /// 恢复魔力
    /// </summary>
    public int healMana;
    /// <summary>
    /// 是药水
    /// </summary>
    public bool potion;
    /// <summary>
    /// 是消耗品
    /// </summary>
    public bool consumable;
    /// <summary>
    /// 大小
    /// </summary>
    public float scale;
    /// <summary>
    /// 防御
    /// </summary>
    public int defense;

    /// <summary>
    /// 生成的射弹ID <see cref="ProjectileID"/>
    /// </summary>
    public int shoot;
    /// <summary>
    /// 生成的射弹速度
    /// </summary>
    public float shootSpeed;
    /// <summary>
    /// 作为弹药时的弹药ID <see cref="AmmoID"/>
    /// </summary>
    public int ammo;
    /// <summary>
    /// 是弹药但不显示(钱币)
    /// </summary>
    public bool notAmmo;
    /// <summary>
    /// 使用弹药的弹药ID <see cref="AmmoID"/>
    /// </summary>
    public int useAmmo;
    /// <summary>
    /// 使用时消耗的魔力
    /// </summary>
    public int mana;
    /// <summary>
    /// 价格
    /// </summary>
    public int value;
    /// <summary>
    /// 是材料
    /// </summary>
    public bool material;
    /// <summary>
    /// 使用后添加的buffID<see cref="BuffID"/>
    /// </summary>
    public int buffType;
    /// <summary>
    /// 使用后添加的buff时间
    /// </summary>
    public int buffTime;
    /// <summary>
    /// 使用后召唤的坐骑ID<see cref="MountID"/>
    /// </summary>
    public int mountType;
    /// <summary>
    /// 旧ID，现使用<see cref="type"/>
    /// </summary>
    public int netID;
    /// <summary>
    /// 增加的暴击率，自带4，如果这为7，那暴击率为11
    /// </summary>
    public int crit;
    /// <summary>
    /// 前缀 <see cref="PrefixID"/>
    /// </summary>
    public byte prefix;
    /// <summary>
    /// 是近战
    /// </summary>
    public bool melee;
    /// <summary>
    /// 是魔法
    /// </summary>
    public bool magic;
    /// <summary>
    /// 是远程
    /// </summary>
    public bool ranged;
    /// <summary>
    /// 是召唤
    /// </summary>
    public bool summon;
    /// <summary>
    /// 是哨兵
    /// </summary>
    public bool sentry;
    /// <summary>
    /// 是被微光转换出来的
    /// </summary>
    public bool shimmered;
    /// <summary>
    /// 进入微光的时间
    /// </summary>
    public float shimmerTime;
    /// <summary>
    /// 染料ID
    /// </summary>
    public byte dye;
    /// <summary>
    /// 原始伤害(无前缀和其他加成)
    /// </summary>
    public int OriginalDamage
    {
        get
        {
            throw null;
        }
    }
    /// <summary>
    /// 原始防御(无前缀和其他加成)
    /// </summary>
    public int OriginalDefense
    {
        get
        {
            throw null;
        }
    }
    /// <summary>
    /// 设置物品的属性为默认值
    /// </summary>
    /// <param name="Type"></param>
    public void SetDefaults(int Type = 0)
    {
        throw null;
    }
    /// <summary>
    /// 游戏更新物品使用的方法
    /// </summary>
    /// <param name="i">在<see cref="Main.item"/>中的索引</param>
    public void UpdateItem(int i)
    {
        throw null;
    }
    /// <summary>
    /// 在熔岩时的检测，用于向导巫毒娃娃和物品烧毁
    /// </summary>
    /// <param name="i">在<see cref="Main.item"/>中的索引</param>
    public void CheckLavaDeath(int i)
    {
        throw null;
    }
    /// <summary>
    /// 生成新物品在世界上
    /// </summary>
    /// <param name="source">生成源</param>
    /// <param name="pos"></param>
    /// <param name="randomBox"></param>
    /// <param name="Type">类型(id)</param>
    /// <param name="Stack">数量</param>
    /// <param name="noBroadcast">不广播(发包)</param>
    /// <param name="prefixGiven">前缀</param>
    /// <param name="noGrabDelay"></param>
    /// <param name="reverseLookup"></param>
    /// <returns>在 <see cref="Main.item"/> 中的索引</returns>
    public static int NewItem(IEntitySource source, Vector2 pos, Vector2 randomBox, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
    {
        throw null;
    }

    /// <summary>
    /// 生成新物品在世界上
    /// </summary>
    /// <param name="source">生成源</param>
    /// <param name="pos"></param>
    /// <param name="Width"></param>
    /// <param name="Height"></param>
    /// <param name="Type">类型(id)</param>
    /// <param name="Stack">数量</param>
    /// <param name="noBroadcast">不广播(发包)</param>
    /// <param name="prefixGiven">前缀</param>
    /// <param name="noGrabDelay"></param>
    /// <param name="reverseLookup"></param>
    /// <returns>在 <see cref="Main.item"/> 中的索引</returns>
    public static int NewItem(IEntitySource source, Vector2 pos, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
    {
        throw null;
    }

    /// <summary>
    /// 生成新物品在世界上
    /// </summary>
    /// <param name="source">生成源</param>
    /// <param name="X"></param>
    /// <param name="Y"></param>
    /// <param name="Width"></param>
    /// <param name="Height"></param>
    /// <param name="Type">类型(id)</param>
    /// <param name="Stack">数量</param>
    /// <param name="noBroadcast">不广播(发包)</param>
    /// <param name="pfix">前缀</param>
    /// <param name="noGrabDelay"></param>
    /// <param name="reverseLookup"></param>
    /// <returns>在 <see cref="Main.item"/> 中的索引</returns>
    public static int NewItem(IEntitySource source, int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0, bool noGrabDelay = false, bool reverseLookup = false)
    {
        throw null;
    }
    /// <summary>
    /// 置为空物品
    /// </summary>
    /// <param name="fullReset">完全重置</param>
    public void TurnToAir(bool fullReset = false)
    {
        throw null;
    }
}
