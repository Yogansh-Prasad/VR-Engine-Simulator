using UnityEngine;

public class EnginePart : MonoBehaviour
{
    public int partIndex; // Index of the engine part

    private EngineGame gameManager; // Reference to the game manager script

    private void Start()
    {
        // Find the game manager script
        gameManager = FindObjectOfType<EngineGame>();
    }

    public void PartChoosen()
    {
        gameManager.OnPartSelected(partIndex);
    }
}
