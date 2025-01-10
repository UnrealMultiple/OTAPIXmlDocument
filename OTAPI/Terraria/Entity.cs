using Microsoft.Xna.Framework;

namespace Terraria;

/// <summary>实体基类</summary>
public abstract class Entity
{
    /// <summary>位置</summary>
    public Vector2 position;
    /// <summary>旧位置</summary>
    public Vector2 oldPosition;
    /// <summary>速度</summary>
    public Vector2 velocity;
    /// <summary>旧速度</summary>
    public Vector2 oldVelocity;
    /// <summary>方向</summary>
    public int direction = 1;
    /// <summary>旧方向</summary>
    public int oldDirection;
    /// <summary>宽度</summary>
    public int width;
    /// <summary>高度</summary>
    public int height;
    /// <summary>中心位置</summary>
    public Vector2 Center
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>左边位置</summary>
    public Vector2 Left
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>右边位置</summary>
    public Vector2 Right
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>顶部位置</summary>
    public Vector2 Top
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>左上角位置</summary>
    public Vector2 TopLeft
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>右上角位置</summary>
    public Vector2 TopRight
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>底部位置</summary>
    public Vector2 Bottom
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>左下角位置</summary>
    public Vector2 BottomLeft
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>右下角位置</summary>
    public Vector2 BottomRight
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>大小(width, height)</summary>
    public Vector2 Size
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>碰撞箱</summary>
    public Rectangle Hitbox
    {
        get => throw null;
        set => throw null;
    }
    /// <summary>实体数据</summary>
    public Dictionary<string, object> EntityData { get; } = new();
    /// <inheritdoc cref="Vector2.Distance(Vector2, Vector2)"/>
    public float Distance(Vector2 Other)
    {
        throw null;
    }
}