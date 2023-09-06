namespace Penumbra.GameData;

public static class Sigs
{
    // ResourceLoader.Debug
    public const string ResourceManager = "48 8B 05 ?? ?? ?? ?? 33 ED F0";

    // ResourceLoader.Replacement
    public const string GetResourceSync  = "E8 ?? ?? 00 00 48 8D 8F ?? ?? 00 00 48 89 87 ?? ?? 00 00";
    public const string GetResourceAsync = "E8 ?? ?? ?? 00 48 8B D8 EB ?? F0 FF 83 ?? ?? 00 00";
    public const string ReadFile         = "E8 ?? ?? ?? ?? 84 C0 0F 84 ?? 00 00 00 4C 8B C3 BA 05";
    public const string ReadSqPack       = "E8 ?? ?? ?? ?? EB 05 E8 ?? ?? ?? ?? 84 C0 0F 84 ?? 00 00 00 4C 8B C3";

    // ResourceLoader.TexMdl
    public const string CheckFileState    = "E8 ?? ?? ?? ?? 48 85 c0 74 ?? 45 0f b6 ce 48 89 44 24";
    public const string LoadTexFileLocal  = "48 89 5C 24 08 48 89 6C 24 10 48 89 74 24 18 57 48 83 EC 30 49 8B F0 44 88 4C 24 20";
    public const string LoadMdlFileLocal  = "40 55 53 56 57 41 56 41 57 48 8D 6C 24 D1 48 81 EC 98 00 00 00";
    public const string LoadTexFileExtern = "E8 ?? ?? ?? ?? 0F B6 E8 48 8B CB E8";
    public const string LoadMdlFileExtern = "E8 ?? ?? ?? ?? EB 02 B0 F1";

    // GameEventManager
    public const string ResourceHandleDestructor = "48 89 5C 24 ?? 57 48 83 EC ?? 48 8D 05 ?? ?? ?? ?? 48 8B D9 48 89 01 B8";
    public const string CopyCharacter            = "E8 ?? ?? ?? ?? 0F B6 9F ?? ?? ?? ?? 48 8D 8F";

    public const string CharacterDestructor =
        "48 89 5C 24 ?? 48 89 74 24 ?? 57 48 83 EC ?? 48 8D 05 ?? ?? ?? ?? 48 8B D9 48 89 01 48 8D 05 ?? ?? ?? ?? 48 89 81 ?? ?? ?? ?? 48 8D 05";

    // PathResolver.AnimationState
    public const string LoadCharacterSound         = "4C 89 4C 24 ?? 55 57 41 56";
    public const string LoadTimelineResources      = "E8 ?? ?? ?? ?? 83 7F ?? ?? 75 ?? 0F B6 87";
    public const string CharacterBaseLoadAnimation = "E8 ?? ?? ?? ?? BA ?? ?? ?? ?? 48 8B CF 44 8B C2 E8 ?? ?? ?? ?? 48 8B 05";
    public const string LoadSomePap                = "48 89 5C 24 ?? 48 89 6C 24 ?? 48 89 74 24 ?? 57 41 56 41 57 48 83 EC ?? 41 8B D9 89 51";
    public const string LoadSomeAction             = "E8 ?? ?? ?? ?? C6 83 ?? ?? ?? ?? ?? 8B 8E";
    public const string LoadCharacterVfx           = "E8 ?? ?? ?? ?? 48 8B F8 48 8D 93";
    public const string LoadAreaVfx                = "48 8B C4 53 55 56 57 41 56 48 81 EC";
    public const string ScheduleClipUpdate         = "40 53 55 56 57 41 56 48 81 EC ?? ?? ?? ?? 48 8B F9";

    // PathResolver.DrawObjectState
    public const string CharacterBaseCreate = "E8 ?? ?? ?? ?? 48 85 C0 74 21 C7 40";

    public const string CharacterBaseDestructor =
        "E8 ?? ?? ?? ?? 40 F6 C7 01 74 3A 40 F6 C7 04 75 27 48 85 DB 74 2F 48 8B 05 ?? ?? ?? ?? 48 8B D3 48 8B 48 30";

    public const string EnableDraw   = "E8 ?? ?? ?? ?? 48 8B 8B ?? ?? ?? ?? 48 85 C9 74 33 45 33 C0";
    public const string WeaponReload = "E8 ?? ?? ?? ?? 33 DB BE";

    // PathResolver.Meta
    public const string UpdateModel       = "48 8B ?? 56 48 83 ?? ?? ?? B9";
    public const string GetEqpIndirect    = "40 ?? 48 83 ?? ?? ?? 81 ?? ?? ?? ?? ?? 48 8B ?? 74 ?? ?? 83 ?? ?? ?? ?? ?? ?? 74 ?? 4C";
    public const string SetupVisor        = "48 8B ?? 53 55 57 48 83 ?? ?? 48 8B";
    public const string RspSetupCharacter = "48 89 5C 24 ?? 48 89 6C 24 ?? 48 89 74 24 ?? 88 54 24 ?? 57 41 56";
    public const string ChangeCustomize   = "E8 ?? ?? ?? ?? 41 0F B6 C5 66 41 89 86";

    // PathResolver.PathState
    public const string HumanVTable = "48 8D 05 ?? ?? ?? ?? 48 89 03 48 B8 ?? ?? ?? ?? ?? ?? ?? ?? 89 8B";

    public const string WeaponVTable =
        "48 8D 05 ?? ?? ?? ?? 48 89 03 B8 ?? ?? ?? ?? 66 89 83 ?? ?? ?? ?? 48 8B C3 48 89 8B ?? ?? ?? ?? 48 89 8B";

    public const string DemiHumanVTable = "48 8D 05 ?? ?? ?? ?? 48 89 03 48 8B C3 89 8B";
    public const string MonsterVTable   = "48 8D 05 ?? ?? ?? ?? 48 89 03 33 C0 48 89 83 ?? ?? ?? ?? 48 89 83 ?? ?? ?? ?? C7 83";

    // PathResolver.Subfiles
    public const string LoadMtrlTex = "4C 8B DC 49 89 5B ?? 49 89 73 ?? 55 57 41 55";

    public const string LoadMtrlShpk =
        "48 89 5C 24 ?? 57 48 81 EC ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 84 24 ?? ?? ?? ?? 44 0F B7 89";

    public const string ApricotResourceLoad = "48 89 74 24 ?? 57 48 83 EC ?? 41 0F B6 F0 48 8B F9";

    // CharacterUtility
    public const string CharacterUtility       = "48 8B 05 ?? ?? ?? ?? 83 B9";
    public const string LoadCharacterResources = "E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? E8 ?? ?? ?? ?? 33 D2 45 33 C0";

    // MetaFileManager
    public const string GetFileSpace = "E8 ?? ?? ?? ?? 41 B9 ?? ?? ?? ?? 4C 8B C0";

    // ResidentResourceManager
    public const string ResidentResourceManager = "0F 44 FE 48 8B 0D ?? ?? ?? ?? 48 85 C9 74 05";

    public const string LoadPlayerResources =
        "E8 ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? BA ?? ?? ?? ?? 41 B8 ?? ?? ?? ?? 48 8B 48 30 48 8B 01 FF 50 10 48 85 C0 74 0A";

    public const string UnloadPlayerResources =
        "41 55 48 81 EC ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 84 24 ?? ?? ?? ?? 4C 8B E9 48 83 C1 08";

    // ActorManager
    public const string InspectTitleId = "0F B7 0D ?? ?? ?? ?? C7 85";
    public const string InspectWorldId = "0F B7 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8B D0";
}
