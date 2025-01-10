namespace Terraria.GameContent.Events;
/// <summary>
/// 灯笼夜
/// </summary>
public class LanternNight
{
    /// <summary>
    /// 手动灯笼夜
    /// </summary>
    public static bool ManualLanterns;
    /// <summary>
    /// 自然灯笼夜
    /// </summary>
    public static bool GenuineLanterns;
    /// <summary>
    /// 下一晚是灯笼夜
    /// </summary>
    public static bool NextNightIsLanternNight;
    /// <summary>
    /// 灯笼夜冷却
    /// </summary>
    public static int LanternNightsOnCooldown;
    /// <summary>
    /// 
    /// </summary>
    public static bool _wasLanternNight;
    /// <summary>
    /// 已开启
    /// </summary>
    public static bool LanternsUp
    {
        get
        {
            throw null;
        }
    }
    /// <summary>
    /// 早上的检查(停止)
    /// </summary>
    public static void CheckMorning()
    {
        throw null;
    }
    /// <summary>
    /// 灯笼夜可继续
    /// </summary>
    /// <returns></returns>
    public static bool LanternsCanPersist()
    {
        throw null;
    }
    /// <summary>
    /// 可开启灯笼夜
    /// </summary>
    /// <returns></returns>
    public static bool LanternsCanStart()
    {
        throw null;
    }
    /// <summary>
    /// 有boss活动
    /// </summary>
    /// <returns></returns>
    public static bool BossIsActive()
    {
        throw null;
    }
}