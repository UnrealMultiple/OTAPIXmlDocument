using Terraria.ID;

namespace Terraria;
/// <summary>NPC实体类</summary>
public class NPC : Entity
{
    /// <summary>
    /// ID <see cref="NPCID"/>
    /// </summary>
    public int type;
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
    /// <summary>
    /// 是boss
    /// </summary>
    public bool boss;
    /// <summary>
    /// 最大增益数量
    /// </summary>
    public static readonly int maxBuffs = 20;
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
    /// ai类型
    /// </summary>
    public int aiStyle;
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
    /// <summary>
    /// 屏幕宽度，默认1920
    /// </summary>
    public static int sWidth = 1920;

    /// <summary>
    /// 指定id是有活动的npc，被一些自带方法使用
    /// <list type="bullet">
    /// <item><see cref="Player.isNearNPC(int, float)"/></item>
    /// </list>
    /// </summary>
    public static bool[] npcsFoundForCheckActive;
    /// <summary>
    /// 把<see cref="npcsFoundForCheckActive"/>全设为<see langword="false"/>, 由<see cref="Main.DoUpdateInWorld(System.Diagnostics.Stopwatch)"/>调用
    /// </summary>
    public static void ClearFoundActiveNPCs()
    {
        throw null;
    }
    /// <summary>
    /// 更新<see cref="npcsFoundForCheckActive"/>, 由<see cref="Main.DoUpdateInWorld(System.Diagnostics.Stopwatch)"/>调用
    /// </summary>
    /// <exception cref="System.NullReferenceException"></exception>
    public static void UpdateFoundActiveNPCs()
    {
        throw null;
    }


    /// <summary>
    /// 用来设置游戏事件清理
    /// </summary>
    /// <param name="eventFlag">修改的字段</param>
    /// <param name="gameEventId">事件ID <see cref="GameEventClearedID"/></param>
    public static void SetEventFlagCleared(ref bool eventFlag, int gameEventId)
    {
        throw null;
    }
    /// <summary>
    /// 有指定<paramref name="Type"/>的活动npc
    /// </summary>
    /// <param name="Type"></param>
    /// <returns></returns>
    public static bool AnyNPCs(int Type)
    {
        throw null;
    }
    /// <summary>
    /// 计算指定<paramref name="Type"/>的活动npc数量
    /// </summary>
    /// <param name="Type"></param>
    /// <returns></returns>
    public static int CountNPCS(int Type)
    {
        throw null;
    }
}
