//.MCAP - MotionCapture file
//Extracted mcap.mad (93 files)
foreach(keyframe) //272 bytes per keyframe
{
    2   ushort  unkUShort0     
    foreach(boneTransform) //per bone branch? (none-leaf-bone) = 10
    {
        //Vector3
        1   sbyte   transform.X
        1   sbyte   transform.Y
        1   sbyte   transform.Z
    }
    
    foreach(boneRotation) //per bone = 15
    {        
        //Quaternion
        4   float   rotation.X
        4   float   rotation.Y
        4   float   rotation.Z
        4   float   rotation.W
    }
}
