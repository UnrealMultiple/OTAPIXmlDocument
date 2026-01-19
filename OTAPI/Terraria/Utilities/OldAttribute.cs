using System;

namespace Terraria.Utilities;

/// <summary>
/// 旧代码标记
/// </summary>
[AttributeUsage(AttributeTargets.All)]
public sealed class OldAttribute : Attribute
{
	/// <summary>
	/// 消息
	/// </summary>
	public string Message
	{
		get
		{
			throw null;
		}
	}
	/// <summary>
	/// 
	/// </summary>
	public OldAttribute()
	{
		throw null;
	}
	/// <summary>
	/// 
	/// </summary>
	/// <param name="message"></param>
	public OldAttribute(string message)
	{
		throw null;
	}
}
