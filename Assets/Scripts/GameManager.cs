//using System.Diagnostics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator robotAnimator;
    private float lastTapTime = 0f;
    private float doubleTapThreshold = 0.3f; // Seconds between taps

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended)
            {
                float timeSinceLastTap = Time.time - lastTapTime;

                if (timeSinceLastTap <= doubleTapThreshold)
                {
                    Debug.Log("Double tap detected!");
                    if (robotAnimator != null)
                        robotAnimator.SetTrigger("AssembleComplete");
                }

                lastTapTime = Time.time;
            }
        }
    }
}
