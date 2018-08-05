[Flags]
public enum ObjectFlag : ushort
{
    None = 0,
    Playable = 1 << 0,
    Bit1 = 1 << 1,
    Bit2 = 1 << 2,
    Bit3 = 1 << 3,
    ScriptObj = 1 << 4,
    Inside = 1 << 5,
    Delayed = 1 << 6,
    Bit7 = 1 << 7,    
}
