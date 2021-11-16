using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VoxelData
{
    public static readonly int NB_FACE_VERTICES = 6; // 2 triangles
    public static readonly int NB_FACES = 6; // because it's a cube
    public static readonly int CHUNK_WIDTH = 16;
    public static readonly int CHUNK_HEIGHT = 128;

    public static readonly int TextureAtlasSizeInBlocks = 32;
    public static float NormalizedBlockTextureSize
    {
        get
        {
            return 1f / (float)TextureAtlasSizeInBlocks;
        }
    }

    // Vertices defining a voxel (cube)
    public static readonly Vector3[] voxelVertices = new Vector3[]
    {
        new Vector3(0.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 1.0f, 1.0f),
        new Vector3(0.0f, 1.0f, 1.0f)
    };

    // Defines faces positions to check for rendering
    public static readonly Vector3[] faceChecks = new Vector3[]
    {
        new Vector3(0.0f, 0.0f, -1.0f), // Back Face
        new Vector3(0.0f, 0.0f, 1.0f), // Front Face
        new Vector3(0.0f, 1.0f, 0.0f), // Top Face
        new Vector3(0.0f, -1.0f, 0.0f), // Bottom Face
        new Vector3(-1.0f, 0.0f, 0.0f), // Left Face
        new Vector3(1.0f, 0.0f, 0.0f) // Right Face
    };

    // Defines each face with vertex indexes defining triangles (2 triangles per face)
    public static readonly int[,] voxelTriangles = 
    {
        // Back, Front, Top, Bottom, Left, Right

        // 0 3 1 1 3 2
        {0, 3, 1, 2}, // Back Face
        {5, 6, 4, 7}, // Front Face
        {3, 7, 2, 6}, // Top Face
        {1, 5, 0, 4}, // Bottom Face
        {4, 7, 0, 3}, // Left Face
        {1, 2, 5, 6}  // Right Face
    };

    // Map texture coordinates on the face of a voxel
    public static readonly Vector2[] voxelUvs = new Vector2[]
    {
        new Vector2(0.0f, 0.0f),
        new Vector2(0.0f, 1.0f),
        new Vector2(1.0f, 0.0f),
        new Vector2(1.0f, 1.0f)
    };
}
