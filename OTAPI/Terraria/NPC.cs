using Terraria.ID;

namespace Terraria;
/// <summary>NPC实体类</summary>
public class NPC : Entity
{
    /// <summary>NPC当前仇恨玩家在 <see cref="Main.player"/> 中的索引</summary>
    public int target;
    /// <summary>alpha 值，决定透明度</summary>
    public int alpha;
    /// <summary>不受到伤害</summary>
    public bool dontTakeDamage;
    /// <summary>血量</summary>
    public int life;
    /// <summary>最大血量</summary>
    public int lifeMax;
    /// <summary>伤害</summary>
    public int damage;
    /// <summary>防御</summary>
    public int defense;
    /// <summary>已击败 <inheritdoc cref="NPCID.EyeofCthulhu"/></summary>
    public static bool downedBoss1;
    /// <summary>已击败 腐化Boss <inheritdoc cref="NPCID.EaterofWorldsHead"/> 或 <inheritdoc cref="NPCID.BrainofCthulhu"/></summary>
    public static bool downedBoss2;
    /// <summary>已击败 <inheritdoc cref="NPCID.SkeletronHead"/></summary>
    public static bool downedBoss3;
    /// <summary>已击败 <inheritdoc cref="NPCID.QueenBee"/></summary>
    public static bool downedQueenBee;
    /// <summary>已击败 <inheritdoc cref="NPCID.KingSlime"/></summary>
    public static bool downedSlimeKing;
    /// <summary>已击败 哥布林军团</summary>
    public static bool downedGoblins;
    /// <summary>已击败 霜月</summary>
    public static bool downedFrost;
    /// <summary>已击败 海盗入侵</summary>
    public static bool downedPirates;
    /// <summary>已击败 <inheritdoc cref="NPCID.Clown"/></summary>
    public static bool downedClown;
    /// <summary>已击败 <inheritdoc cref="NPCID.Plantera"/></summary>
    public static bool downedPlantBoss;
    /// <summary>已击败 <inheritdoc cref="NPCID.Golem"/></summary>
    public static bool downedGolemBoss;
    /// <summary>已击败 火星暴乱</summary>
    public static bool downedMartians;
    /// <summary>已击败 <inheritdoc cref="NPCID.DukeFishron"/></summary>
    public static bool downedFishron;
    /// <summary>已击败 <inheritdoc cref="NPCID.MourningWood"/></summary>
    public static bool downedHalloweenTree;
    /// <summary>已击败 <inheritdoc cref="NPCID.Pumpking"/></summary>
    public static bool downedHalloweenKing;
    /// <summary>已击败 <inheritdoc cref="NPCID.IceQueen"/></summary>
    public static bool downedChristmasIceQueen;
    /// <summary>已击败 <inheritdoc cref="NPCID.Everscream"/></summary>
    public static bool downedChristmasTree;
    /// <summary>已击败 <inheritdoc cref="NPCID.SantaNK1"/></summary>
    public static bool downedChristmasSantank;
    /// <summary>已击败 <inheritdoc cref="NPCID.CultistBoss"/></summary>
    public static bool downedAncientCultist;
    /// <summary>已击败 <inheritdoc cref="NPCID.MoonLordCore"/></summary>
    public static bool downedMoonlord;
    /// <summary>已击败 <inheritdoc cref="NPCID.LunarTowerSolar"/></summary>
    public static bool downedTowerSolar;
    /// <summary>已击败 <inheritdoc cref="NPCID.LunarTowerVortex"/></summary>
    public static bool downedTowerVortex;
    /// <summary>已击败 <inheritdoc cref="NPCID.LunarTowerNebula"/></summary>
    public static bool downedTowerNebula;
    /// <summary>已击败 <inheritdoc cref="NPCID.LunarTowerStardust"/></summary>
    public static bool downedTowerStardust;
    /// <summary>已击败 <inheritdoc cref="NPCID.HallowBoss"/></summary>
    public static bool downedEmpressOfLight;
    /// <summary>已击败 <inheritdoc cref="NPCID.QueenSlimeBoss"/></summary>
    public static bool downedQueenSlime;
    /// <summary>已击败 <inheritdoc cref="NPCID.Deerclops"/></summary>
    public static bool downedDeerclops;
    /// <summary>已击败 任意机械Boss</summary>
    public static bool downedMechBossAny;
    /// <summary>已击败 <inheritdoc cref="NPCID.TheDestroyer"/></summary>
    public static bool downedMechBoss1;
    /// <summary>已击败 <inheritdoc cref="NPCID.Retinazer"/> 和 <inheritdoc cref="NPCID.Spazmatism"/></summary>
    public static bool downedMechBoss2;
    /// <summary>已击败 <inheritdoc cref="NPCID.SkeletronPrime"/></summary>
    public static bool downedMechBoss3;
    /// <summary>已击败 <inheritdoc cref="NPCID.LunarTowerSolar"/> 和 <inheritdoc cref="NPCID.LunarTowerVortex"/> 和 <inheritdoc cref="NPCID.LunarTowerNebula"/> 和 <inheritdoc cref="NPCID.LunarTowerStardust"/></summary>
    public static bool downedTowers
    {
        get => throw null;
    }
}
