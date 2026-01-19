using System.Drawing;
using Terraria.ID;
using Terraria.Utilities;
// ReSharper disable InconsistentNaming

namespace Terraria;

/// <summary>
/// 世界信息
/// </summary>
public class WorldGen
{
    /// <summary>
    /// 世界大小
    /// </summary>
    public static class WorldSize
    {
        /// <summary>
        /// 小
        /// </summary>
        public const int Small = 0;

        /// <summary>
        /// 中
        /// </summary>
        public const int Medium = 1;

        /// <summary>
        /// 大
        /// </summary>
        public const int Large = 2;
    }

    /// <summary>
    /// 存储当前世界中选定的矿物层级 (矿物变体)。
    /// <para/>
    /// 泰拉瑞亚中的矿物通常是成对出现的(例如：铜与锡、铁与铅)。
    /// 此类中的字段存储了世界生成时确定的具体矿物 <see cref="TileID"/> 。
    /// </summary>
    public static class SavedOreTiers
    {
        /// <summary>
        /// 第一层级矿物：铜(7)或锡(166)。
        /// </summary>
        public static int Copper = 7;

        /// <summary>
        /// 第二层级矿物：铁(6)或铅(167)。
        /// </summary>
        public static int Iron = 6;

        /// <summary>
        /// 第三层级矿物：银(9)或钨(168)。
        /// </summary>
        public static int Silver = 9;

        /// <summary>
        /// 第四层级矿物：金(8)或铂金(169)。
        /// </summary>
        public static int Gold = 8;

        /// <summary>
        /// 困难模式第一层级矿物：钴(107)或钯金(221)。
        /// </summary>
        public static int Cobalt = 107;

        /// <summary>
        /// 困难模式第二层级矿物：秘银(108)或山铜(222)。
        /// </summary>
        public static int Mythril = 108;

        /// <summary>
        /// 困难模式第三层级矿物：精金(111)或钛金(223)。
        /// </summary>
        public static int Adamantite = 111;
    }

    /// <summary>
    /// 获取世界大小
    /// </summary>
    /// <returns><see cref="WorldSize"/></returns>
    public static int GetWorldSize() => 0;

    /// <summary>
    /// 在指定的坐标开始放置一小片指定的图格。此方法仅应在世界生成代码的早期使用。<see cref="OreRunner(int, int, double, int, ushort)"/> 是一个更安全的版本，可以随时使用而不会损坏图格。
    /// <para/> 更多详细信息和视频指南可以在 <see href="https://github.com/tModLoader/tModLoader/wiki/World-Generation#terrariaworldgen-public-static-void-tilerunnerint-i-int-j-double-strength-int-steps-int-type-bool-addtile--false-float-speedx--0f-float-speedy--0f-bool-noychange--false-bool-override--true">世界生成维基页面</see> 找到。
    /// </summary>
    public static void TileRunner(int i, int j, double strength, int steps, int type, bool addTile = false,
        double speedX = 0.0, double speedY = 0.0, bool noYChange = false, bool overRide = true, int ignoreTileType = -1)
    {
    }

    /// <summary> 指示选定的世界邪恶。如果为 true，则世界为猩红世界；为 false 时，世界为腐化世界。 </summary>
    public static bool crimson;

    /// <summary>
    /// 如果为 true，被破坏的图格将不会掉落物品。在流星坠落期间使用，以防止产生物品掉落。注意，通过附近图格帧更新(framing)间接破坏的图格(例如)仍会掉落物品，因此这并不能阻止所有掉落。
    /// </summary>
    private static bool stopDrops;

    /// <summary> 当多体图格(multitile)正在被破坏时为 true。 </summary>
    public static bool destroyObject;

    /// <summary> 如果为 true，则世界正在以 <see href="https://terraria.wiki.gg/zh/wiki/Don%27t_dig_up">Don't dig up</see> 秘密世界种子生成。另见 <see cref="Main.remixWorld"/>。 </summary>
    public static bool remixWorldGen = false;

    /// <summary> 如果为 true，则世界正在以 <see href="https://terraria.wiki.gg/zh/wiki/Get_fixed_boi">Get fixed boi (天顶世界)</see> 秘密世界种子生成。此种子结合了多个秘密种子。注意，此种子继承的其他秘密世界种子布尔值也会被设置，因此不需要同时检查那些布尔值和此布尔值。另见 <see cref="Main.zenithWorld"/>。 </summary>
    public static bool everythingWorldGen = false;

    /// <summary> 如果为 true，则世界正在以 <see href="https://terraria.wiki.gg/zh/wiki/No_traps">No traps (陷阱世界)</see> 秘密世界种子生成。另见 <see cref="Main.noTrapsWorld"/>。 </summary>
    public static bool noTrapsWorldGen = false;

    /// <summary> 如果为 true，则世界正在以 <see href="https://terraria.wiki.gg/zh/wiki/Drunk_world">Drunk world (醉酒世界)</see> 秘密世界种子生成。另见 <see cref="Main.drunkWorld"/>。 </summary>
    public static bool drunkWorldGen = false;

    /// <summary> 如果为 true，则世界正在以 <see href="https://terraria.wiki.gg/zh/wiki/For_the_worthy">For the worthy (传奇世界)</see> 秘密世界种子生成。另见 <see cref="Main.getGoodWorld"/>。 </summary>
    public static bool getGoodWorldGen = false;
    

    /// <summary> 如果为 true，则世界正在以 <see href="https://terraria.wiki.gg/zh/wiki/Celebrationmk10">Celebrationmk10 (庆典世界)</see> 秘密世界种子生成。另见 <see cref="Main.tenthAnniversaryWorld"/>。 </summary>
    public static bool tenthAnniversaryWorldGen = false;

    /// <summary> 如果为 true，则世界正在以 <see href="https://terraria.wiki.gg/zh/wiki/The_Constant">The Constant (永恒领域)</see> 秘密世界种子生成。另见 <see cref="Main.dontStarveWorld"/>。 </summary>
    public static bool dontStarveWorldGen = false;

    /// <summary> 如果为 true，则世界正在以 <see href="https://terraria.wiki.gg/zh/wiki/Not_the_bees">Not the bees (蜜蜂世界)</see> 秘密世界种子生成。另见 <see cref="Main.notTheBeesWorld"/>。 </summary>
    public static bool notTheBees = false;

    /// <summary>
    /// 世界生成的随机数生成器。为了使世界种子功能可靠，在所有世界生成随机逻辑中使用此属性而非 <see cref="Main.rand"/> 非常重要。
    /// </summary>
    public static UnifiedRandom genRand
    {
        get => new ();
    }

    /// <summary>
    /// 如果提供的图格坐标在世界边界内，则返回 true。
    /// <para/>当处理与加法或减法结合的随机坐标时，有可能构造出超出世界边界的坐标。这将导致世界生成崩溃，因此在尝试对这些坐标执行操作之前，检查坐标是否合适非常重要。使用此方法检查给定的坐标是否落在世界内部。fluff 参数进一步检查坐标是否距离边缘至少有这么多图格的距离，这对于可能影响大范围图格的世界生成操作非常有用。
    /// </summary>
    /// <param name="x">图格X</param>
    /// <param name="y">图格Y</param>
    /// <param name="fluff"></param>
    /// <returns></returns>
    public static bool InWorld(int x, int y, int fluff = 0)
    {
        return true;
    }

    /// <summary>
    /// 在世界边界内生成一个随机的图格坐标。可选参数定义了额外的填充，用于避开边缘或定义目标区域。
    /// <para/> <c>Point point = WorldGen.RandomWorldPoint((int)Main.worldSurface, 40, 500, 60)</c> 等同于 <code>int x = WorldGen.genRand.Next(60, Main.maxTilesX - 40);
    /// int y = WorldGen.genRand.Next((int)Main.worldSurface, Main.maxTilesY - 500);
    /// </code>
    /// </summary>
    /// <param name="top"></param>
    /// <param name="right"></param>
    /// <param name="bottom"></param>
    /// <param name="left"></param>
    /// <returns></returns>
    public static Point RandomWorldPoint(int top = 0, int right = 0, int bottom = 0, int left = 0) => new();

    /// <summary>
    /// 尝试放置一个宝箱并根据样式 (<paramref name="Style"/>) 和深度填充典型的战利品。如果不带任何参数，将根据深度创建一个普通、黄金或带锁的暗影箱。你可以传入一个物品类型 (<paramref name="contain"/>)，宝箱中的第一个物品将是该物品。与 <see cref="PlaceChest(int, int, ushort, bool, int)"/> 不同，生成的宝箱将被放置在给定坐标 (<paramref name="i"/>, <paramref name="j"/>) 为右下角的位置。此外，如果给定的 <paramref name="j"/> 坐标不合适，AddBuriedChest 将从给定坐标向下搜索找到它遇到的第一个实心图格并尝试在那里放置。如果成功放置了宝箱，此方法返回 true，但请注意，宝箱可能不会完全位于你提供的坐标处。这使得之后直接调整宝箱内容变得困难。
    /// <para/> 视频指南可以在 <see href="https://github.com/tModLoader/tModLoader/wiki/World-Generation#terrariaworldgen-public-static-void-tilerunnerint-i-int-j-double-strength-int-steps-int-type-bool-addtile--false-float-speedx--0f-float-speedy--0f-bool-noychange--false-bool-override--true">世界生成维基页面</see> 上找到。它展示了一个使用默认参数运行方法的示例 <c>WorldGen.AddBuriedChest(x, y);</c>。注意宝箱样式如何随深度变化，以及宝箱如何在可能的情况下被放置在提供坐标正下方的地面上。
    /// </summary>
    /// <param name="i">图格X</param>
    /// <param name="j">图格Y</param>
    /// <param name="contain">物品类型</param>
    /// <param name="notNearOtherChests"></param>
    /// <param name="Style">宝箱样式</param>
    /// <param name="trySlope"></param>
    /// <param name="chestTileType"></param>
    /// <returns></returns>
    public static bool AddBuriedChest(int i, int j, int contain = 0, bool notNearOtherChests = false, int Style = -1,
        bool trySlope = false, ushort chestTileType = 0)
    {
        return false;
    }

    /// <summary>
    /// 检查是否允许在提供的地点正下方立即生长藤蔓。此方法仅检查附近区域现有藤蔓图格 (<see cref="MountID.Sets.IsVine"/>) 的数量是否未超过允许的最大值。如果该区域允许更多藤蔓，则返回 true。
    /// <para/> 具体来说，此方法检查给定坐标周围 9x17 区域内的藤蔓图格数量是否不超过 60 个。
    /// </summary>
    public static bool GrowMoreVines(int x, int y)
    {
        return false;
    }

    /// <summary>
    /// 放置 <see cref="TileID.SmallPiles"/> 图格。此图格较为特殊，不遵循正常的样式规则，且无法通过 PlaceTile 放置。i 和 j 是坐标。X 和 Y 是纹理文件中特定图格的计数和行索引。索引从左到右从 0 开始计数。例如，蓝宝石藏堆的 Y=1(第二行)且 X=21(第 22 个 2x1 图格)。
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <param name="X"></param>
    /// <param name="Y"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static bool PlaceSmallPile(int i, int j, int X, int Y, ushort type = 185)
    {
        return false;
    }

    /// <summary>
    /// 类似于 <see cref="TileRunner(int, int, double, int, int, bool, double, double, bool, bool, int)"/>，但没有很多选项。OreRunner 在以坐标(以图格坐标表示的 <paramref name="i"/> 和 <paramref name="j"/>)为起始位置的地方放置指定图格 (<paramref name="type"/>) 的小斑块。OreRunner 仅替换满足 <see cref="TileID.Sets.CanBeClearedDuringOreRunner"/> 或为 <see cref="Main.tileMoss"/> 的活动图格 (<see cref="Tile.HasTile"/>)，使其适合在世界中已存在帧重要(FrameImportant)图格 (<see cref="Main.tileFrameImportant"/>) 后使用。
    /// <para/> 原版代码仅在生成困难模式矿石时使用此方法。此方法适合在游戏内和多人游戏中使用，因为它会同时执行帧处理并同步图格更改。
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <param name="strength"></param>
    /// <param name="steps"></param>
    /// <param name="type"></param>
    public static void OreRunner(int i, int j, double strength, int steps, ushort type)
    {
    }

    /// <summary>
    /// 将生物群落变体图格和墙壁转换为目标生物群落。<br/>
    /// 默认转换 9x9 的正方形区域，但可以通过 <paramref name="size"/> 参数进行调整。
    /// </summary>
    /// <remarks>
    /// 有关易于查看的用法示例，请参考弹幕 AI 样式 31 的代码(用于环境改造器的溶液)。
    /// </remarks>
    /// <param name="i">目标图格的 X 坐标。</param>
    /// <param name="j">目标图格的 Y 坐标。</param>
    /// <param name="conversionType">你希望转换成的生物群落。见 <see cref="BiomeConversionID"/>
    /// 将此设置为 0(纯净)会将受影响的图格恢复到其默认状态(例如，黑檀石、猩红石和珍珠石将转换回普通石块)。<br/>
    /// </param>
    /// <param name="size">
    /// 当使用此方法转换图格时，以目标图格为中心的方形区域会被转换为目标生物群落的图格。<br/>
    /// 此可选参数默认为 4，决定了该正方形从中心图格向外计数的“半径”图格数。<br/>
    /// 如果你只想转换单个图格，请设置为 0。在其他情况下，请谨慎使用此参数。
    /// </param>
    /// <param name="tiles">转换是否应影响图格</param>
    /// <param name="walls">转换是否应影响墙壁</param>
    public static void Convert(int i, int j, int conversionType, int size = 4, bool tiles = true, bool walls = true)
    {
    }

    /// <summary>
    /// 尝试在给定的图格坐标处放置一个宝箱。如果方法成功，提供的坐标 (<paramref name="x"/>, <paramref name="y"/>) 将是生成的宝箱的左下角。<paramref name="type"/> 是要放置的图格类型，<paramref name="style"/> 是要放置的图格样式。
    /// <para/> 对于原版宝箱，你可以在<see href="https://github.com/tModLoader/tModLoader/wiki/Intermediate-Prerequisites#vanilla-texture-file-reference">提取原版纹理</see>后，从 <c>Tiles_21.png</c> 图像中从左侧起从零开始计数，以找到你想要放置的样式。另一种选择是遵循 <see href="https://github.com/tModLoader/tModLoader/wiki/Vanilla-Content-IDs#tile-ids">图格 ID 维基指南</see> 来寻找样式。
    /// <para/> <paramref name="notNearOtherChests"/> 可以设置为 true，以在左右 25 个图格、上下 8 个图格范围内存在其他宝箱时防止宝箱放置。此方法返回成功放置的宝箱索引(<see cref="Main.chest"/> 中的索引)，如果放置宝箱失败则返回 -1。宝箱放置可能因多种原因失败，例如现有图格阻塞了空间，或者预期位置正下方没有 2 个合适的实心图格。
    /// <para/> 有关使用此方法的方法，请参见世界生成维基指南的 <see href="https://github.com/tModLoader/tModLoader/wiki/World-Generation#try-until-success">“重试直至成功”部分</see>。有关在宝箱中放置物品的信息，请参见世界生成维基指南的 <see href="https://github.com/tModLoader/tModLoader/wiki/World-Generation#try-until-success">“在宝箱中放置物品”部分</see>。
    /// <para/> <see cref="AddBuriedChest(int, int, int, bool, int, bool, ushort)"/> 方法会放置一个宝箱并为其填充该宝箱的默认物品。
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="type"></param>
    /// <param name="notNearOtherChests"></param>
    /// <param name="style"></param>
    /// <returns></returns>
    public static int PlaceChest(int x, int y, ushort type = 21, bool notNearOtherChests = false, int style = 0)
    {
        return 0;
    }

    /// <summary>
    /// 用于网络同步。尝试放置宝箱，应使用 <see cref="PlaceChest(int, int, ushort, bool, int)"/>。
    /// </summary>
    public static void PlaceChestDirect(int x, int y, ushort type, int style, int id)
    {
    }

    /// <summary>
    /// PlaceTile 是在遵循锚点考虑的情况下放置单个图格的主要方式。WorldGen 类中的大多数其他 PlaceX 方法都会调用此方法。i 和 j 是图格坐标。这些坐标与图格的中心点相关，不一定是图格的左上角。阅读 <see href="https://github.com/tModLoader/tModLoader/wiki/Basic-Tile">基础图格维基指南</see> 以熟悉锚点(Anchors)和中心点(Origins)的概念。<paramref name="mute"/> 指示是否应发出声音，这仅适用于游戏内使用，因为在世界生成期间所有声音都会静音。<paramref name="forced"/> 尝试即使坐标处已有其他图格也进行放置，但它并不完全可靠。<paramref name="plr"/> 除了影响浴缸外没有任何作用。<paramref name="style"/> 指的是所提供图格类型的样式。样式在基础图格指南中有说明。
    /// <para/> PlaceTile 返回一个表示放置成功的布尔值。遗憾的是，它并不起作用，请不要使用它。调用 PlaceTile 后检查坐标是检查放置是否成功的好方法：<c>if(Main.tile[x, y].TileType == TileID.Campfire)</c>
    /// <para/> PlaceTile 并没有暴露所有内容。例如，尝试放置具有特定样式的图格会被许多底层方法忽略。另一个问题是，无法放置向右定向的具有左右放置朝向的图格。在这些情况下，你可能需要手动放置多体图格中的每个图格，或者改用 <see cref="PlaceObject(int, int, int, bool, int, int, int, int)"/>。WorldGen.PlaceObject 需要更多输入。例如，使用 PlaceObject 放置珊瑚意味着你必须手动指定样式，因为随机样式 (<see cref="TileObjectData.RandomStyleRange"/>) 选择是 PlaceTile 的一个功能。
    /// <para/> 如果在游戏内调用，如果放置成功，则需要同步更改的图格。更多信息和示例请参见 <see cref="NetMessage.SendTileSquare(int, int, int, int, int, TileChangeType)"/>。
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <param name="Type"></param>
    /// <param name="mute"></param>
    /// <param name="forced"></param>
    /// <param name="plr"></param>
    /// <param name="style"></param>
    /// <returns></returns>
    public static bool PlaceTile(int i, int j, int Type, bool mute = false, bool forced = false, int plr = -1,
        int style = 0)
    {
        return false;
    }

    /// <summary> 如果给定一个树木图格坐标，将输出该树木底部图格的坐标。 </summary>
    public static void GetTreeBottom(int i, int j, out int x, out int y)
    {
        x = 0;
        y = 0;
    }

    /// <summary>
    /// 尝试破坏提供图格坐标处的图格。<para/>
    /// 调用者可以使用 <paramref name="fail"/>、<paramref name="effectOnly"/> 和 <paramref name="noItem"/> 来指示意图是不真正杀死图格、仅生成破坏图格特效，还是不掉落物品。例如，蠕虫通常使用 <c>fail: true, effectOnly: true</c> 来生成表示蠕虫在地下挖掘的粉尘。<para/>
    /// <see cref="ModTile.KillTile(int, int, ref bool, ref bool, ref bool)"/> 和 <see cref="GlobalTile.KillTile(int, int, int, ref bool, ref bool, ref bool)"/> 将被调用以修改这些值。<para/>
    /// 注意此方法将破坏单个图格，然后调用图格帧处理(framing)代码。<paramref name="noItem"/> 参数仅对 1x1 图格相关，对多体图格不相关。图格帧处理代码是触发多体图格破坏其所有剩余图格并掉落其放置物品的原因。如果意图是防止多体图格掉落物品，调用者必须使用 <see cref="GlobalTile.Drop(int, int, int)"/>。<para/>
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <param name="fail">防止图格被破坏，但仍播放击打声</param>
    /// <param name="effectOnly">防止图格被破坏，但仍生成击打粉尘并阻止击打声。</param>
    /// <param name="noItem">防止物品掉落。仅与 1x1 图格相关。</param>
    public static void KillTile(int i, int j, bool fail = false, bool effectOnly = false, bool noItem = false)
    {
    }

    /// <summary>
    /// 获取距离提供的图格坐标最近的玩家。通常用于确定哪个玩家挖掘了图格。
    /// <br/><br/> 从技术上讲，如果有多个玩家距离很近，这可能是错误的，但由于图格操作不跟踪是哪个玩家触发的，这是一种合理的方法。
    /// </summary>
    public static Player GetPlayerForTile(int x, int y) => Main.player[0];

    /// <summary>
    /// 当邪恶生物群落或神圣图格尝试蔓延到某个图格，但附近发现了叶绿(矿石或砖块)时调用。如果被蔓延生物群落锁定的图格恰好已经被转换，此代码会将其净化回常规变体。<br/>
    /// 此代码与常规净化转换(如环境改造器的绿色溶液)不同，它会将受感染的草地转换为丛林草，而非普通草地。<br/>
    /// 欲了解更多信息，请参阅 <see href="https://terraria.wiki.gg/zh/wiki/Biome_spread#Notes">生物群落蔓延维基页面</see>。
    /// </summary>
    public static void ChlorophyteDefense(int x, int y)
    {
    }

    /// <summary>
    /// 如果在提供坐标周围 11x11 区域内有 3 个或更多叶绿矿或叶绿砖图格，则返回 true。有时如果少于 3 个但多于 0 个也会返回 true。用于实现叶绿图格限制附近邪恶生物群落蔓延的功能(<see href="https://terraria.wiki.gg/zh/wiki/Biome_spread#Notes">生物群落蔓延维基页面</see>)。
    /// </summary>
    public static bool nearbyChlorophyte(int i, int j)
    {
        return false;
    }

    /// <summary>
    /// 如果提供的图格坐标处有一个适合在上方锚定图格的实心图格，则返回 true。
    /// <br/><br/> 具体来说，这会检查图格是否处于活动状态、未被虚化、属于 <see cref="Main.tileSolid"/> 或 <see cref="Main.tileSolidTop"/>、不是半块，且具有实心的顶边(顶部未倾斜)。
    /// </summary>
    public static bool SolidTileAllowBottomSlope(int i, int j)
    {
        return false;
    }
}