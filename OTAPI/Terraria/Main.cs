using System.Diagnostics;
using Terraria.ID;
namespace Terraria;
/// <summary>游戏主类</summary>
public class Main
{
    /// <summary>是白天</summary>
    public static bool dayTime;
    /// <summary>困难模式</summary>
    public static bool hardMode;
    /// <summary>专家模式</summary>
    public static bool expertMode { get; }
    /// <summary>大师模式</summary>
    public static bool masterMode { get; }
    /// <summary>天顶世界</summary>
    public static bool zenithWorld { get; }
    /// <summary>日食</summary>
    public static bool eclipse;
    /// <summary>史莱姆雨</summary>
    public static bool slimeRain;
    /// <summary>游戏的网络模式
    /// 0 本地
    /// 1 客户端
    /// 2 服务端</summary>
    public static int netMode;
    /// <summary>最大玩家数</summary>
    public const int maxPlayers = 255;
    /// <summary>当前游戏中的玩家列表</summary>
    public static Player[] player = new Player[maxPlayers + 1];
    /// <summary>最大物品数</summary>
    public const int maxItems = 400;
    /// <summary>当前游戏中的物品列表</summary>
    public static Item[] item = new Item[maxItems + 1];
    /// <summary>最大射弹数</summary>
    public const int maxProjectiles = 1000;
    /// <summary>当前游戏中的射弹列表</summary>
    public static Projectile[] projectile = new Projectile[maxProjectiles + 1];
    /// <summary>当前游戏中的箱子列表</summary>
    public static Chest[] chest = new Chest[8000];
    /// <summary>当前游戏中的标牌列表</summary>
    public static Sign[] sign = new Sign[1000]; 
    
    /// <summary>
    /// 最大NPC数
    /// </summary>
    public const int maxNPCs = 200;
    /// <summary>当前游戏中的NPC列表</summary>
    public static NPC[] npc = new NPC[maxNPCs + 1];
    /// <summary>
    /// 入侵类型 <see cref="InvasionID"/>
    /// </summary>
    public static int invasionType;
    /// <summary>
    /// 是南瓜月
    /// </summary>
    public static bool pumpkinMoon;
    /// <summary>
    /// 是血月
    /// </summary>
    public static bool bloodMoon;
    /// <summary>
    /// 是霜月
    /// </summary>
    public static bool snowMoon;
    /// <summary>
    /// 世界上的更新
    /// </summary>
    /// <exception cref="System.NullReferenceException"></exception>
    public void DoUpdateInWorld(Stopwatch sw)
    {
        throw null;
    }
}
