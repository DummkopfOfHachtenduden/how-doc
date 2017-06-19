//.POG - MapObjects ("PigObjectGround")
2   ushort  objectCount
foreach(obj) //94 bytes per object
{
    16  char[]  obj.Name				//Model
    16  char[]  obj.Null				//"NULL"
    2   ushort  obj.XOffset
    2   ushort  obj.YOffset
    2   ushort  obj.ZOffset
    
	4	uint	obj.Number
	2	ushort	obj.Rotation
	2	ushort	obj.unkUShort0			//0
	2	ushort	obj.Type				//ID of object?
	
	2	ushort	obj.CollisionX
	2	ushort	obj.CollisionY
	2	ushort	obj.CollisionZ
	
	2	ushort	obj.BridgeFlag			//1 on bridge enter
	
	2	ushort	obj.SpawnDelay			//Delay in turns to spawn (for pickups) otherwise health?
	
	1	byte	obj.Destructability		//63 = destructable?, 127 = not destructable?
	1	byte	obj.Team//				//

	/// <summary>
	/// 1  - Spawns CRATE when killed
	/// 2  - Spawns PROPOINT when killed
	/// 4  - give the medal if the object is not killed
	/// 7  - Triggers Airdrop (CRATE) on ScriptPositon
	/// 8  - Triggers Airdrop (PROPOINT) on ScriptPositon
	/// 13 - drop box, if the group is killed (3 bytes - number of the group)
	/// 14 - falls icon, if a group is killed (3 bytes - number of the group)
	/// 19 - a box with a specified content
	/// 20 - first job
	/// 21 - the last task
	/// 22 - an intermediate reference (object is present from the start of the mission)
	/// 23 - an intermediate job
	/// </summary>
	2	ushort	obj.ScriptType
	
	1	byte	obj.Group
	1	byte	obj.param0
	1	byte	obj.param1
	
	17	byte[]	obj.unkBuffer	//more params?
	
	//Vector3 - Target position for scripts
	2	ushort	obj.ScriptXOffset
	2	ushort	obj.ScriptYOffset
	2	ushort	obj.ScriptZOffset
	
	/// <summary>
	/// 01 - Player Pig
	/// 02 - 
	/// 04 - 
	/// 08 -
	/// 16 - there is a script object
	/// 32 - Pig is in OBJECT
	/// 64 - a pig with the appearance of delay
	/// </summary>
	2	ushort	flags
	2	ushort	PigDelay	//Delay in turns to spawn pig
	2	ushort	unkUShort7
}