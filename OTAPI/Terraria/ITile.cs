using System.Numerics;

using Microsoft.Xna.Framework;

using Terraria.ID;

namespace Terraria;
/// <summary>
/// 图格接口
/// </summary>
public interface ITile
{
    int collisionType { get; }
    /// <summary>
    /// 图格id <see cref="TileID"/>
    /// </summary>
    ushort type { get; set; }
    /// <summary>
    /// 墙ID  <see cref="WallID"/>
    /// </summary>
    ushort wall { get; set; }
    /// <summary>
    /// 液体数量
    /// </summary>
    byte liquid { get; set; }
    /// <summary>
    /// 二进制数据
    /// </summary>
    ushort sTileHeader { get; set; }
    /// <summary>
    /// 二进制数据
    /// </summary>
    byte bTileHeader { get; set; }
    /// <summary>
    /// 二进制数据
    /// </summary>
    byte bTileHeader2 { get; set; }
    /// <summary>
    /// 二进制数据
    /// </summary>
    byte bTileHeader3 { get; set; }
    /// <summary>
    /// 帧(图片)x
    /// </summary>
    short frameX { get; set; }
    /// <summary>
    /// 帧(图片)y
    /// </summary>
    short frameY { get; set; }
    /// <summary>
    /// 克隆
    /// </summary>
    /// <returns></returns>
    object Clone();

    void ClearEverything();

    void ClearTile();
    /// <summary>
    /// 复制自 <paramref name="from"/>
    /// </summary>
    /// <param name="from"></param>
    void CopyFrom(ITile from);
    /// <summary>
    /// 相似于
    /// </summary>
    /// <param name="compTile"></param>
    /// <returns></returns>
    bool isTheSameAs(ITile compTile);

    int blockType();
    /// <summary>
    /// 设置液体类型 <see cref="LiquidID"/>
    /// </summary>
    /// <param name="liquidType"></param>
    void liquidType(int liquidType);
    /// <summary>
    /// 液体类型 <see cref="LiquidID"/>
    /// </summary>
    /// <returns></returns>
    byte liquidType();

    bool nactive();

    void ResetToType(ushort type);

    void ClearMetadata();

    Color actColor(Color oldColor);

    void actColor(ref Vector3 oldColor);

    bool topSlope();

    bool bottomSlope();

    bool leftSlope();

    bool rightSlope();

    bool HasSameSlope(ITile tile);
    /// <summary>
    /// 墙颜色 <see cref="PaintID"/>
    /// </summary>
    /// <returns></returns>
    byte wallColor();
    /// <summary>
    /// 设置墙颜色 <see cref="PaintID"/>
    /// </summary>
    /// <param name="wallColor"></param>
    void wallColor(byte wallColor);
    /// <summary>
    /// 是熔岩
    /// </summary>
    /// <returns></returns>
    bool lava();
    /// <summary>
    /// 设置熔岩
    /// </summary>
    /// <param name="lava"></param>
    void lava(bool lava);
    /// <summary>
    /// 是蜂蜜
    /// </summary>
    /// <returns></returns>
    bool honey();
    /// <summary>
    /// 设置蜂蜜
    /// </summary>
    /// <param name="honey"></param>
    void honey(bool honey);
    /// <summary>
    /// 是微光
    /// </summary>
    /// <returns></returns>
    bool shimmer();
    /// <summary>
    /// 设置微光
    /// </summary>
    /// <param name="shimmer"></param>
    void shimmer(bool shimmer);

    bool wire4();

    void wire4(bool wire4);

    int wallFrameX();

    void wallFrameX(int wallFrameX);

    byte frameNumber();

    void frameNumber(byte frameNumber);

    byte wallFrameNumber();

    void wallFrameNumber(byte wallFrameNumber);

    int wallFrameY();

    void wallFrameY(int wallFrameY);

    bool checkingLiquid();

    void checkingLiquid(bool checkingLiquid);

    bool skipLiquid();

    void skipLiquid(bool skipLiquid);

    bool invisibleBlock();

    void invisibleBlock(bool invisibleBlock);

    bool invisibleWall();

    void invisibleWall(bool invisibleWall);

    bool fullbrightBlock();

    void fullbrightBlock(bool fullbrightBlock);
    /// <summary>
    /// 图格颜色 <see cref="PaintID"/>
    /// </summary>
    /// <returns></returns>
    byte color();
    /// <summary>
    /// 设置图格颜色 <see cref="PaintID"/>
    /// </summary>
    /// <param name="color"></param>
    void color(byte color);
    /// <summary>
    /// 是活动的
    /// </summary>
    /// <returns></returns>
    bool active();
    /// <summary>
    /// 设置活动状态
    /// </summary>
    /// <param name="active"></param>
    void active(bool active);
    /// <summary>
    /// 是虚化的
    /// </summary>
    /// <returns></returns>
    bool inActive();
    /// <summary>
    /// 设置虚化
    /// </summary>
    /// <param name="inActive"></param>
    void inActive(bool inActive);

    bool wire();

    void wire(bool wire);

    bool wire2();

    void wire2(bool wire2);

    bool wire3();

    void wire3(bool wire3);

    bool halfBrick();

    void halfBrick(bool halfBrick);
    /// <summary>
    /// 有制动器
    /// </summary>
    /// <returns></returns>
    bool actuator();
    /// <summary>
    /// 设置制动器
    /// </summary>
    /// <param name="actuator"></param>
    void actuator(bool actuator);

    byte slope();

    void slope(byte slope);

    bool fullbrightWall();

    void fullbrightWall(bool fullbrightWall);

    void ClearBlockPaintAndCoating();

    void ClearWallPaintAndCoating();
}
