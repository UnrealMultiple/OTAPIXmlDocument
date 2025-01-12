using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria;

/// <summary>
/// 箱子
/// </summary>
public class Chest : IFixLoadedData
{
    public const float chestStackRange = 600f;
    public const int maxChestTypes = 52;
    public static int[] chestTypeToIcon = new int[52];
    public static int[] chestItemSpawn = new int[52];
    public const int maxChestTypes2 = 17;
    public static int[] chestTypeToIcon2 = new int[17];
    public static int[] chestItemSpawn2 = new int[17];
    public const int maxDresserTypes = 43;
    public static int[] dresserTypeToIcon = new int[43];
    public static int[] dresserItemSpawn = new int[43];
    
    /// <summary>
    /// 最大箱子物品格数
    /// </summary>
    public const int maxItems = 40;
    
    /// <summary>
    /// 最长箱子名字
    /// </summary>
    public const int MaxNameLength = 20;
    
    /// <summary>
    /// 箱子的物品列表
    /// </summary>
    public Item[] item;
    /// <summary>
    /// 图格X坐标
    /// </summary>
    public int x;
    
    /// <summary>
    /// 图格Y坐标
    /// </summary>
    public int y;
    
    /// <summary>
    /// 是NPC商店
    /// </summary>
    public bool bankChest;
    
    /// <summary>
    /// 箱子名字
    /// </summary>
    public string name;
    public int frameCounter;
    public int frame;
    public int eatingAnimationTime;
    
    /// <summary>
    /// 已被打开的箱子 (被占用)
    /// </summary>
    public static HashSet<int> _chestInUse = new HashSet<int>();

    
    public Chest(bool bank = false)
    {
        this.item = new Item[40];
        this.bankChest = bank;
        this.name = string.Empty;
    }

    /// <summary>
    /// 将箱子信息转为字符串 (Count是已使用的格子数)
    /// </summary>
    /// <returns> eg. {{X: 12, Y: 322, Count: 233}}</returns>
    public override string ToString()
    {
        return null;
    }

    /// <summary>
    /// 初始化箱子系统
    /// </summary>
    public static void Initialize()
    {
    }
    
    /// <summary>
    /// 玩家是否在箱子界面
    /// </summary>
    /// <param name="i">玩家在<see cref="Main.player"/>的索引</param>
    /// <returns> true 玩家在箱子界面; false 玩家不在箱子界面</returns>
    public static bool IsPlayerInChest(int i)
    {
        return false;
    }

    /// <summary>
    /// 获取所有已被打开的箱子
    /// </summary>
    /// <returns> 已被打开的箱子在<see cref="Main.chest"/>的索引列表</returns>
    public static List<int> GetCurrentlyOpenChests()
    {
        return null;
    }

    
    /// <summary>
    /// 检查箱子是否上锁
    /// </summary>
    /// <param name="x">箱子的图格X坐标</param>
    /// <param name="y">箱子的图格Y坐标</param>
    /// <returns> true 箱子已上锁; false 箱子未上锁 </returns>
    public static bool IsLocked(int x, int y) => false;

    /// <summary>
    /// 检查箱子是否上锁
    /// </summary>
    /// <param name="tile">箱子所在的图格</param>
    /// <returns> true 箱子已上锁; false 箱子未上锁 </returns>
    public static bool IsLocked(ITile t)
    {

        return false;
    }
    
    /// <summary>
    /// 将玩家背包指定格位的物品快速堆叠到附近箱子 (slot >= 58 无效) (600像素内,即37.5格)
    /// </summary>
    /// <param name="plr">玩家在<see cref="Main.player"/>的索引</param>
    /// <param name="slot">背包格位索引</param>
    public static void ServerPlaceItem(int plr, int slot)
    {
    }

    /// <summary>
    /// 将玩家背包的物品快速堆叠到附近箱子 (600像素内,即37.5格)
    /// </summary>
    /// <param name="item">快速堆叠的物品</param>
    /// <param name="position">快速堆叠的中心位置</param>
    /// <param name="playerID">玩家在<see cref="Main.player"/>的索引</param>
    /// <returns> 毫无意义的Item,与传入的item一致 </returns>
    public static Item PutItemInNearbyChest(Item item, Vector2 position, int playerID)
    {
        return null;
    }
    
    /// <summary>
    /// 克隆这个箱子实例
    /// </summary>
    /// <returns> 一个完全相同的箱子,但是和原箱子内存地址不同 </returns>
    public object Clone() => this.MemberwiseClone();
    
    
    /// <summary>
    /// 解锁箱子
    /// </summary>
    /// <param name="X">箱子的图格X坐标</param>
    /// <param name="Y">箱子的图格Y坐标</param>
    /// <returns> true 箱子解锁成功; false 箱子解锁失败 </returns>
    public static bool Unlock(int X, int Y)
    {
        return true;
    }

    
    /// <summary>
    /// 给箱子上锁
    /// </summary>
    /// <param name="X">箱子的图格X坐标</param>
    /// <param name="Y">箱子的图格Y坐标</param>
    /// <returns> true 箱子上锁成功; false 箱子上锁失败 </returns>
    public static bool Lock(int X, int Y)
    {
        return true;
    }

    /// <summary>
    /// 查找打开指定箱子的玩家
    /// </summary>
    /// <param name="i">箱子在<see cref="Main.chest"/>的索引</param>
    /// <returns> 存在则返回玩家在<see cref="Main.player"/>的索引; 不存在则返回-1</returns>
    public static int UsingChest(int i)
    {
        return -1;
    }

    /// <summary>
    /// 查找箱子的索引
    /// </summary>
    /// <param name="X">箱子的图格X坐标</param>
    /// <param name="Y">箱子的图格Y坐标</param>
    /// <returns> 存在返回箱子在<see cref="Main.chest"/>的索引; 不存在则返回-1</returns>
    public static int FindChest(int X, int Y)
    {
        return -1;
    }

    /// <summary>
    /// 查找箱子的索引 (扩大范围查找X+2,Y+2)
    /// </summary>
    /// <param name="X">箱子的图格X坐标</param>
    /// <param name="Y">箱子的图格Y坐标</param>
    /// <returns> 存在返回箱子在<see cref="Main.chest"/>的索引; 不存在则返回-1</returns>
    public static int FindChestByGuessing(int X, int Y)
    {
        return -1;
    }

    
    /// <summary>
    /// 查找可用的箱子索引 (只有x,y参数有效)
    /// </summary>
    /// <param name="x">箱子的图格X坐标</param>
    /// <param name="y">箱子的图格Y坐标</param>
    /// <param name="type">无效</param>
    /// <param name="style">无效</param>
    /// <param name="direction">无效</param>
    /// <param name="alternate">无效</param>
    /// <returns> 此位置不存在箱子则返回箱子在<see cref="Main.chest"/>的可用索引; 此位置存在箱子返回-1</returns>
    public static int FindEmptyChest(
        int x,
        int y,
        int type = 21,
        int style = 0,
        int direction = 1,
        int alternate = 0)
    {
        return 0;
    }

    /// <summary>
    /// 检测以(x,y)为中心附近是否有箱子 (推测用于生成地图)
    /// </summary>
    /// <param name="x">中心图格X坐标</param>
    /// <param name="y">中心图格Y坐标</param>
    /// <returns> true 周围存在箱子; false 周围不存在箱子</returns>
    public static bool NearOtherChests(int x, int y)
    {
        return false;
    }
    

    /// <summary>
    /// 创建新的箱子
    /// </summary>
    /// <param name="X">箱子图格X坐标</param>
    /// <param name="Y">箱子图格Y坐标</param>
    /// <param name="id">自定义箱子索引</param>
    /// <returns> 成功则返回箱子在<see cref="Main.chest"/>的索引; 失败则返回-1</returns>
    public static int CreateChest(int X, int Y, int id = -1)
    {
        return 0;
    }

    /// <summary>
    /// 检查箱子能否被破坏
    /// </summary>
    /// <param name="X">箱子图格X坐标</param>
    /// <param name="Y">箱子图格Y坐标</param>
    /// <returns> true 可破坏; false 不可破坏</returns>
    public static bool CanDestroyChest(int X, int Y)
    {
        return true;
    }

    /// <summary>
    /// 破坏箱子 (有检查)
    /// </summary>
    /// <param name="X">箱子图格X坐标</param>
    /// <param name="Y">箱子图格Y坐标</param>
    /// <returns> true 破坏成功; false 破坏失败</returns>
    public static bool DestroyChest(int X, int Y)
    {
        return true;
    }

    /// <summary>
    /// 强制破坏箱子 (无检查) 
    /// </summary>
    /// <param name="X">箱子图格X坐标</param>
    /// <param name="Y">箱子图格Y坐标</param>
    public static void DestroyChestDirect(int X, int Y, int id)
    {
    }

    /// <summary>
    /// 向商店添加售卖物品 (貌似是出售物品后执行的)
    /// </summary>
    /// <param name="newItem">添加的物品/param>
    public void AddItemToShop(Item newItem)
    {
    }


    /// <summary>
    /// 初始化旅行商人商店
    /// </summary>
    public static void SetupTravelShop()
    {
    }

    /// <summary>
    /// 初始化NPC商店 (大部分客户端逻辑)
    /// </summary>
    /// <param name="type">NPC类型 (不是ID)</param>
    public void SetupShop(int type)
    {
    }
    
    /// <summary>
    /// 修复已加载的数据(比如物品堆叠超最大堆叠)
    /// </summary>
    public void FixLoadedData()
    {
    }
}