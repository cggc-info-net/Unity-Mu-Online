 using UnityEngine;

public class Constants : MonoBehaviour
{
    public const int TERRAIN_SIZE = 256;
    public const int TERRAIN_SIZE_MASK = 255;
    public const float TERRAIN_SCALE = 100f;

    public static bool BACKGROUND_MUSIC = true;
    public static bool SOUND_EFFECTS = true;
    public static bool DRAW_BOUNDING_BOXES = false;
    public static bool DRAW_BOUNDING_BOXES_INTERACTIVES = false;
    public static string DataPath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\User\\Unity\\Mu Online\\Assets\\StreamingAssets\\Data");
}
