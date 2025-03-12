using UnityEngine;

public struct VertexPositionColorTexture
{
    public Vector3 Position;
    public Color Color;
    public Vector2 TextureCoordinate;

    public VertexPositionColorTexture(Vector3 position, Color color, Vector2 textureCoordinate)
    {
        Position = position;
        Color = color;
        TextureCoordinate = textureCoordinate;
    }
}
