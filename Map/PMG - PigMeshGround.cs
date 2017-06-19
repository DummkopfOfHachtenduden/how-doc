//.PMG - TiledTerrain ("PigMeshGround")
//16 * 16 = 64 blocks
//4 * 4 tiles per block

//TileWidth is 512? or 1024?
//Also used for SKY with 4x16 blocks?

for (int yBlock = 0; yBlock < 16; yBlock++)
{
    for (int xBlock = 0; xBlock < 16; xBlock++)
    {
        2   ushort  block.XOffset                   // from center
        2   ushort  block.YOffset                   // -1
        2   ushort  block.ZOffset                   // from center		
        2   ushort  block.unkUShort3
        
        //block.Vertices
        for (int yVertex = 0; yVertex < 5; yVertex++)
        {
            for (int xVertex = 0; xVertex < 5; xVertex++)
            {
                2   ushort  height
                2   ushort  unkUShort4              //<= 255
            }
        }
        
        4	uint    unkUInt0                        //always 0 -> obsolete tileCount?
        
        for (int yTile = 0; yTile < 4; yTile++)
        {
            for (int xTile = 0; xTile < 4; xTile++)
            {
                //16 bytes per tile
                
                6   byte[]  tile.unkBuffer0         //0
                1   byte    tile.Type               //MapTileType.cs -> Logic and walk sound                
                2   ushort  tile.Slip               //MapTileSlip.cs -> Determines slipping for tiles with "IsWall" flag.                
                1   byte    tile.unkByte0           //0
                1   byte    tile.RotationFlip       //MapTileRotateFlip.cs -> Rotation & Flip of tile texture
                4   uint    tile.TextureIndex       //from PTG (PigTextureGround)
                1   byte    tile.unkByte1           //0
            }
        }
    }
}