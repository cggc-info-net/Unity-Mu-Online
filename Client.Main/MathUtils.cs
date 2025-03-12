using System;
using UnityEngine;

public class MathUtils
{
    public static Vector3 FaceNormalize(Vector3 v1, Vector3 v2, Vector3 v3)
    {
        // Minimal optimization by eliminating intermediate variables
        float nx = (v2.y - v1.y) * (v3.z - v1.z) - (v3.y - v1.y) * (v2.z - v1.z);
        float ny = (v2.z - v1.z) * (v3.x - v1.x) - (v3.z - v1.z) * (v2.x - v1.x);
        float nz = (v2.x - v1.x) * (v3.y - v1.y) - (v3.x - v1.x) * (v2.y - v1.y);

        // Use LengthSquared to check for zero length
        float lengthSquared = nx * nx + ny * ny + nz * nz;
        if (lengthSquared == 0) return Vector3.zero;

        float invLength = 1.0f / (float)Math.Sqrt(lengthSquared);
        return new Vector3(nx * invLength, ny * invLength, nz * invLength);
    }
}
