// .PMG - TiledTerrain ("PigMeshGround")
// 16 * 16 = 256 blocks, 4 * 4 tiles per block width of 512 units per tile
// also used for SKY with 16 * 4 = 64 blocks

for (int yBlock = 0; yBlock < 16; yBlock++)
{
    for (int xBlock = 0; xBlock < 16; xBlock++)
    {
        2   short  block.xOffset                   //
        2   short  block.yOffset                   // unreliable?
        2   short  block.zOffset                   //
        2   short  block.unkShort0
        
        //block.Vertices
        for (int yVertex = 0; yVertex < 5; yVertex++)
        {
            for (int xVertex = 0; xVertex < 5; xVertex++)
            {
                2   short   height
                2   short   unkShort0              // <= 255
            }
        }
        
        4   uint   unkUInt0                        // always 0 -> obsolete tileCount?
        
        for (int yTile = 0; yTile < 4; yTile++)
        {
            for (int xTile = 0; xTile < 4; xTile++)
            {   
                2   short   tile.unkShort0          // always 0 -> xOffset?
                2   short   tile.unkShort1          // always 0 -> yOffset?
                2   short   tile.unkShort2          // always 0 -> zOffset?
                1   byte    tile.Type               // MapTileType (TypeMask = 0x1F, IsWaterMask = 0x20, IsMineMask = 0x40, IsWallMask = 0x80)
                1   byte    tile.Slip               // MapTileSlip
                2   short   tile.unkShort3          // 0
                1   byte    tile.RotationFlip       // MapTileRotateFlip -> Rotation & Flip of tile texture
                4   uint    tile.TextureIndex       // from PTG (PigTextureGround)
                1   byte    tile.unkByte0           // 0
            }
        }
    }
}
