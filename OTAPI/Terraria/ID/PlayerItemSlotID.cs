namespace Terraria.ID;

/// <summary>
/// 在发送网络包时使用的槽位ID
/// </summary>
public static class PlayerItemSlotID
{
    /// <summary>
    /// <inheritdoc cref="Player.inventory"/>
    /// </summary>
    public static readonly int Inventory0;
    /// <summary>
    /// 鼠标物品，占位但未使用
    /// </summary>
    public static readonly int InventoryMouseItem;
    /// <summary>
    /// <inheritdoc cref="Player.armor"/>
    /// </summary>
    public static readonly int Armor0;
    /// <summary>
    /// <inheritdoc cref="Player.dye"/>
    /// </summary>
    public static readonly int Dye0;
    /// <summary>
    /// <inheritdoc cref="Player.miscEquips"/>
    /// </summary>
    public static readonly int Misc0;
    /// <summary>
    /// <inheritdoc cref="Player.miscDyes"/>
    /// </summary>
    public static readonly int MiscDye0;
    /// <summary>
    /// <inheritdoc cref="Player.bank"/>
    /// </summary>
    public static readonly int Bank1_0;
    /// <summary>
    /// <inheritdoc cref="Player.bank2"/>
    /// </summary>
    public static readonly int Bank2_0;
    /// <summary>
    /// <inheritdoc cref="Player.trashItem"/>
    /// </summary>
    public static readonly int TrashItem;
    /// <summary>
    /// <inheritdoc cref="Player.bank3"/>
    /// </summary>
    public static readonly int Bank3_0;
    /// <summary>
    /// <inheritdoc cref="Player.bank4"/>
    /// </summary>
    public static readonly int Bank4_0;

    public static readonly int Loadout1_Armor_0;

    public static readonly int Loadout1_Dye_0;

    public static readonly int Loadout2_Armor_0;

    public static readonly int Loadout2_Dye_0;

    public static readonly int Loadout3_Armor_0;

    public static readonly int Loadout3_Dye_0;

    /// <summary>
    /// 可转发，用于<see cref="MessageBuffer.GetData(int, int, out int)"/>的<see cref="MessageID.SyncEquipment"/>
    /// </summary>
    public static bool[] CanRelay;
}
