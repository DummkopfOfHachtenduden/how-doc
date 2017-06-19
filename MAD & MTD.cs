//.MAD - MapAssetData
//.MTD - MapTextureData

//Most archives are NAMED and follow this structure:
foreach(namedEntry) //24 bytes per namedEntry
{
    16  char[]  entry.Name
    4   int     entry.Position  //within this file.
    4   int     entry.Length
}

//-----------------------------------------------------

//mcap.mad is RAW and follows this structure:
foreach(namedEntry) //8 bytes per namedEntry
{
    4   int     entry.Position  //within this file.
    4   int     entry.Length
}