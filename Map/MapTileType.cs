[Flags]
public enum MapTileType : byte
{
    /// <summary>
    /// FT_MUD.wav
    /// </summary>
    Mud = 0,

    /// <summary>
    /// FT_GRASS.wav
    /// </summary>
    Grass = 1,

    /// <summary>
    /// FT_METAL.wav
    /// </summary>
    Metal = 2,

    /// <summary>
    /// FT_WOOD.wav
    /// </summary>
    Wood = 3,

    /// <summary>
    /// FT_WATER.wav
    /// </summary>
    Water = 4,

    /// <summary>
    /// FT_STONE.wav
    /// </summary>
    Stone = 5,

    /// <summary>
    /// FT_ROCK.wav
    /// </summary>
    Rock = 6,

    /// <summary>
    /// FT_SAND.wav
    /// </summary>
    Sand = 7,

    /// <summary>
    /// FT_ICE.wav
    /// </summary>
    Ice = 8,

    /// <summary>
    /// FT_SNOW.wav
    /// </summary>
    Snow = 9,

    /// <summary>
    /// FT_QUAG.wav
    /// </summary>
    Quag = 10,

    /// <summary>
    /// FT_LAVA.wav
    /// </summary>
    Lava = 11,

    IsWatery = 0x20,
    IsMine = 0x40,
    IsWall = 0x80,
}