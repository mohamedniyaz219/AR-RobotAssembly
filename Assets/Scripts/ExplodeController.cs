using UnityEngine;

public class ExplodeController : MonoBehaviour
{
    public Transform[] robotParts;
    public Vector3[] explodedOffsets;
    private Vector3[] originalPositions;
    private bool isExploded = false;

    void Start()
    {
        originalPositions = new Vector3[robotParts.Length];
        for (int i = 0; i < robotParts.Length; i++)
        {
            originalPositions[i] = robotParts[i].localPosition;
        }
    }

    public void ToggleExplode()
    {
        for (int i = 0; i < robotParts.Length; i++)
        {
            if (isExploded)
                robotParts[i].localPosition = originalPositions[i];
            else
                robotParts[i].localPosition = originalPositions[i] + explodedOffsets[i];
        }

        isExploded = !isExploded;
    }
}
