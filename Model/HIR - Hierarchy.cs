//.HIR - Hierarchy / Skeleton
foreach(bone) //20 bytes per bone
{
    4   int     bone.ParentIndex
    2   short   bone.X
    2   short   bone.Y
    2   short   bone.Z
    10  byte[]  bone.reserved   //EMPTY - rotation (quaternion)?
}

//00: Hip
//01: Spine
//02: Head
//03: UpperArm.L
//04: LowerArm.L
//05: Hand.L
//06: UpperArm.R
//07: LowerArm.R
//08: Hand.R
//09: UpperLeg.L
//10: LowerLeg.L
//11: Foot.L
//12: UpperLeg.R
//13: LowerLeg.R
//14: Foot.R