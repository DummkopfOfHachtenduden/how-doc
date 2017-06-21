//.POG - MapObjects ("PigObjectGround")

2   ushort  objectCount
foreach(obj) //94 bytes per object
{
    16  char[]  obj.Name                //Model name
    16  char[]  obj.NULL                //"NULL"
    2   ushort  obj.XOffset
    2   ushort  obj.YOffset
    2   ushort  obj.ZOffset
    
    2   ushort  obj.ID
    2   ushort  obj.unkUShort0          //4095 on Chimney (CHIM) and Snowman (SNOWH, SNOWB), otherwise 0
    2   ushort  obj.Rotation
    2   ushort  obj.unkUShort1          //0
    2   ushort  obj.TypeID              //type of object
    
    2   ushort  obj.CollisionX
    2   ushort  obj.CollisionY
    2   ushort  obj.CollisionZ
    
    2   ushort  obj.BridgeFlag          //1 on bridge enter
    
    2   ushort  obj.SpawnDelay          //SpawnDelay on CRATEs. Overrides health for Pigs/Objects
    
    1   byte    obj.unkByte0            //Bitflag destruct-/damageabiltiy?
    1   byte    obj.Team                //01, 02, 04, 08, 16, 32
    
    2   ushort  obj.ScriptType    
    1   byte    obj.ScriptGroup
    1   byte    obj.ScriptParam0
    1   byte    obj.ScriptParam1    
    17  byte[]  obj.ScriptReserved      //more params?   
    2   ushort  obj.ScriptXOffset
    2   ushort  obj.ScriptYOffset
    2   ushort  obj.ScriptZOffset
    
    2   ushort  obj.Flag
    2   ushort  obj.PigSpawnDelay       //Delay in turns 
    2   ushort  obj.unkUShort2          //0
}