namespace Terraria;

/// <summary>标牌</summary>
public class Sign
{
    /// <summary>
    /// 最大标牌数
    /// </summary>
    public const int maxSigns = 1000;
    
    /// <summary>
    /// 图格X坐标
    /// </summary>
    public int x;
    
    /// <summary>
    /// 图格Y坐标
    /// </summary>
    public int y;
    
    /// <summary>
    /// 内容
    /// </summary>
    public string text;

    /// <summary>
    /// 移除的标牌 (不会破坏标牌图格)
    /// </summary>
    /// <param name="x">图格X坐标</param>
    /// <param name="y">图格Y坐标</param>
    public static void KillSign(int x, int y)
    {
    }

    /// <summary>
    /// 获取标牌在<see cref="Main.sign"/>的索引
    /// </summary>
    /// <param name="i">图格X坐标</param>
    /// <param name="j">图格Y坐标</param>
    /// <param name="CreateIfMissing">当位置不存在标牌时,创建新标牌</param>
    /// <returns> 标牌在<see cref="Main.sign"/>的索引 </returns>
    public static int ReadSign(int i, int j, bool CreateIfMissing = true)
    {
        return 0;
    }

    /// <summary>
    /// 修改标牌的内容
    /// </summary>
    /// <param name="i">标牌在<see cref="Main.sign"/>的索引</param>
    /// <param name="text">内容</param>
    public static void TextSign(int i, string text)
    {
    }
    
    /// <summary>
    /// 将标牌信息转为字符串
    /// </summary>
    /// <returns>eg. x233    y233    Koko真可爱</returns>
    public override string ToString()
    {
        return null;
    }
}