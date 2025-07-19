using Terraria.ID;

namespace Terraria;

/// <summary>
/// 网络消息缓冲
/// </summary>
public class MessageBuffer
{
    /// <summary>
    /// 索引
    /// </summary>
    public int whoAmi;
    /// <summary>
    /// 获取数据
    /// </summary>
    /// <param name="start"></param>
    /// <param name="length"></param>
    /// <param name="messageType"><see cref="MessageID"/></param>
    public void GetData(int start, int length, out int messageType)
    {
        throw null;
    }
}
