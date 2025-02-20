﻿using System.Runtime.InteropServices;
using Dalamud.Utility;
using Lumina.Excel.GeneratedSheets;
using Penumbra.GameData.Enums;
using PseudoEquipItem = System.ValueTuple<string, ulong, ushort, ushort, ushort, byte, byte>;

namespace Penumbra.GameData.Structs;

[StructLayout(LayoutKind.Sequential)]
public readonly struct EquipItem
{
    public readonly string        Name;
    public readonly CustomItemId  Id;
    public readonly IconId        IconId;
    public readonly SetId         ModelId;
    public readonly WeaponType    WeaponType;
    public readonly Variant       Variant;
    public readonly FullEquipType Type;

    public ItemId ItemId
        => Id.Item;

    public bool Valid
        => Type != FullEquipType.Unknown;

    public CharacterArmor Armor()
        => new(ModelId, Variant, 0);

    public CharacterArmor Armor(StainId stain)
        => new(ModelId, Variant, stain);

    public CharacterWeapon Weapon()
        => new(ModelId, WeaponType, Variant, 0);

    public CharacterWeapon Weapon(StainId stain)
        => new(ModelId, WeaponType, Variant, stain);

    public EquipItem()
        => Name = string.Empty;

    public EquipItem(string name, CustomItemId id, IconId iconId, SetId modelId, WeaponType weaponType, Variant variant, FullEquipType type)
    {
        Name       = string.Intern(name);
        Id         = id;
        IconId     = iconId;
        ModelId    = modelId;
        WeaponType = weaponType;
        Variant    = variant;
        Type       = type;
    }

    public string ModelString
        => WeaponType == 0 ? $"{ModelId}-{Variant}" : $"{ModelId}-{WeaponType}-{Variant}";

    public static implicit operator EquipItem(PseudoEquipItem it)
        => new(it.Item1, it.Item2, it.Item3, it.Item4, it.Item5, it.Item6, (FullEquipType)it.Item7);

    public static explicit operator PseudoEquipItem(EquipItem it)
        => (it.Name, it.Id.Id, it.IconId.Id, it.ModelId.Id, it.WeaponType.Id, it.Variant.Id, (byte)it.Type);

    public static EquipItem FromArmor(Item item)
    {
        var type    = item.ToEquipType();
        var name    = item.Name.ToDalamudString().TextValue;
        var id      = item.RowId;
        var icon    = item.Icon;
        var model   = (SetId)item.ModelMain;
        var weapon  = (WeaponType)0;
        var variant = (Variant)(item.ModelMain >> 16);
        return new EquipItem(name, id, icon, model, weapon, variant, type);
    }

    public static EquipItem FromMainhand(Item item)
    {
        var type    = item.ToEquipType();
        var name    = item.Name.ToDalamudString().TextValue;
        var id      = item.RowId;
        var icon    = item.Icon;
        var model   = (SetId)item.ModelMain;
        var weapon  = (WeaponType)(item.ModelMain >> 16);
        var variant = (Variant)(item.ModelMain >> 32);
        return new EquipItem(name, id, icon, model, weapon, variant, type);
    }

    public static EquipItem FromOffhand(Item item)
    {
        var type    = item.ToEquipType().ValidOffhand();
        var name    = item.Name.ToDalamudString().TextValue + type.OffhandTypeSuffix();
        var id      = item.RowId;
        var icon    = item.Icon;
        var model   = (SetId)item.ModelSub;
        var weapon  = (WeaponType)(item.ModelSub >> 16);
        var variant = (Variant)(item.ModelSub >> 32);
        return new EquipItem(name, id, icon, model, weapon, variant, type);
    }

    public static EquipItem FromIds(ItemId itemId, IconId iconId, SetId modelId, WeaponType type, Variant variant,
        FullEquipType equipType = FullEquipType.Unknown, string? name = null)
    {
        name ??= $"Unknown ({modelId}-{(type.Id != 0 ? $"{type}-" : string.Empty)}{variant})";
        var fullId = itemId.Id is 0
            ? new CustomItemId(modelId, type, variant, equipType)
            : (CustomItemId)itemId;
        return new EquipItem(name, fullId, iconId, modelId, type, variant, equipType);
    }


    public static EquipItem FromId(CustomItemId id)
    {
        var (setId, weaponType, variant, equipType) = id.Split;
        return new EquipItem($"Unknown ({setId}-{(weaponType.Id != 0 ? $"{weaponType}-" : string.Empty)}{variant})", id, 0, setId, weaponType,
            variant, equipType);
    }

    public override string ToString()
        => Name;
}
