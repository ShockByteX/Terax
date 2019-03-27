namespace Tera.Core.Game
{
    public enum MovementKind : uint { Run = 0, Walk = 1, Fall = 2, Jump = 5, JumpSteep = 6, Stop = 7, HeavyFall = 10 }
    public enum ChatChannel : uint
    {
        Say = 0, Party = 1, Guild = 2, Area = 3, Trade = 4,
        Greeting = 9, Private1 = 11, Private2 = 12, Private3 = 13, Private4 = 14, Private5 = 15, Private6 = 16, Private7 = 17, Private8 = 18,
        PartyNotice = 21, Emote = 26, Global = 27, RaidNotice = 25, Raid = 32, Megaphone = 213, GuildAdvertising = 214
    }
}