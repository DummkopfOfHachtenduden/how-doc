16  byte[]  header  //Reserved for name?
4   uint    triangleCount
foreach(triangle)   //32 bytes per triangle
{
	1	sbyte	triangle.U_A //U component for Vertex_A
	1	sbyte	triangle.V_A //U component for Vertex_A

	1	sbyte	triangle.U_B //U component for Vertex_B
	1	sbyte	triangle.V_B //V component for Vertex_B
	 
	1	sbyte	triangle.U_C //U component for Vertex_C	
	1	sbyte	triangle.V_C //V component for Vertex_C
	    
    2   ushort  triangle.Vertex_A
    2   ushort  triangle.Vertex_B
    2   ushort  triangle.Vertex_C
    
    2   ushort  triangle.Normal_A
    2   ushort  triangle.Normal_B
    2   ushort  triangle.Normal_C 
    
    2   ushort  triangle.unkUShort0
    
    4   uint    triangle.TextureIndex    

    2   ushort  triangle.unkUShort1
    2   ushort  triangle.unkUShort2
    2   ushort  triangle.unkUShort3
    2   ushort  triangle.unkUShort4
}

4   uint    planeCount
foreach(plane)   //36 bytes per plane
{	
	1	sbyte	plane.U_A //U component for Vertex_A
	1	sbyte	plane.V_A //U component for Vertex_A

	1	sbyte	plane.U_B //U component for Vertex_B
	1	sbyte	plane.V_B //V component for Vertex_B
	 
	1	sbyte	plane.U_C //U component for Vertex_C	
	1	sbyte	plane.V_C //V component for Vertex_C
	
	1	sbyte	plane.U_D //U component for Vertex_D
	1	sbyte	plane.V_D //V component for Vertex_D
    
    2   ushort  plane.Vertex_A //Index from .VTX
    2   ushort  plane.Vertex_B //Index from .VTX
    2   ushort  plane.Vertex_C //Index from .VTX
    2   ushort  plane.Vertex_D //Index from .VTX
    
    2   ushort  plane.Normal_A //Index from .NO2
    2   ushort  plane.Normal_B //Index from .NO2
    2   ushort  plane.Normal_C //Index from .NO2
    2   ushort  plane.Normal_D //Index from .NO2
    
	//unkUShort0 as in triangle does not exist here
	
    4   uint    plane.TextureIndex     
	
    2   ushort  plane.unkUShort1
    2   ushort  plane.unkUShort2
    2   ushort  plane.unkUShort3
    2   ushort  plane.unkUShort4
}