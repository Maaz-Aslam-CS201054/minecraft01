using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class voxelData
{

    public static readonly Vector3[] voxelVertices = new Vector3[8]
    {
        new Vector3(0.0f, 0.0f, 0.0f), //vertice 0
        new Vector3(1.0f, 0.0f, 0.0f), //vertice 1
        new Vector3(1.0f, 1.0f, 0.0f), //vertice 2
        new Vector3(0.0f, 1.0f, 0.0f), //vertice 3
        new Vector3(0.0f, 0.0f, 1.0f), //vertice 4
        new Vector3(1.0f, 0.0f, 1.0f), //vertice 5
        new Vector3(1.0f, 1.0f, 1.0f), //vertice 6
        new Vector3(0.0f, 1.0f, 1.0f), //vertice 7
    };

    public static readonly int[,] voxelTriangles = new int[6, 6]
    {
        {0, 3, 1, 1, 3, 2 }, //Back Face
        {5, 6, 4, 4, 6, 7 }, //Front Face
        {3, 7, 2, 2, 7, 6 }, //Top Face
        {1, 5, 0, 0, 5, 4 }, //Bottom Face
        {4, 7, 0, 0, 7, 3 }, //Left Face
        {1, 2, 5, 5, 2, 6 }  //RightFace
    };
}
