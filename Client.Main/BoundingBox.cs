using UnityEngine;

public struct BoundingBox
{
    public Vector3 Min { get; set; }
    public Vector3 Max { get; set; }

    public BoundingBox(Vector3 min, Vector3 max)
    {
        Min = min;
        Max = max;
    }

    public Vector3 Center => (Min + Max) * 0.5f;
    public Vector3 Size => Max - Min;

    public bool Contains(Vector3 point)
    {
        return (point.x >= Min.x && point.x <= Max.x) &&
               (point.y >= Min.y && point.y <= Max.y) &&
               (point.z >= Min.z && point.z <= Max.z);
    }
}
