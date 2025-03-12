using UnityEngine;

public abstract class GameControl : MonoBehaviour
{
    public GameControlStatus Status { get; private set; } = GameControlStatus.NonInitialized;

}
