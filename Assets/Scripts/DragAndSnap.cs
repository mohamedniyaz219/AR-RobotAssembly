using UnityEngine;

public class DragAndSnap : MonoBehaviour
{
    public Transform snapTarget;
    public float snapRange = 0.5f;

    private Vector3 offset;
    private bool dragging = false;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
#if UNITY_EDITOR
        HandleMouseInput();
#else
        HandleTouchInput();
#endif
    }

    // For Editor Testing
    void HandleMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit) && hit.transform == transform)
            {
                dragging = true;
                offset = transform.position - GetMouseWorldPosition();
            }
        }

        if (Input.GetMouseButton(0) && dragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }

        if (Input.GetMouseButtonUp(0) && dragging)
        {
            dragging = false;
            TrySnap();
        }
    }

    // For Touch Devices
    void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = touch.position;

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = cam.ScreenPointToRay(touchPos);
                if (Physics.Raycast(ray, out RaycastHit hit) && hit.transform == transform)
                {
                    dragging = true;
                    offset = transform.position - GetTouchWorldPosition(touch);
                }
            }

            if (touch.phase == TouchPhase.Moved && dragging)
            {
                transform.position = GetTouchWorldPosition(touch) + offset;
            }

            if (touch.phase == TouchPhase.Ended && dragging)
            {
                dragging = false;
                TrySnap();
            }
        }
    }

    void TrySnap()
    {
        float distance = Vector3.Distance(transform.position, snapTarget.position);
        if (distance < snapRange)
        {
            transform.position = snapTarget.position;
            GetComponent<Collider>().enabled = false;
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        Vector3 screenPos = Input.mousePosition;
        screenPos.z = 1f;
        return cam.ScreenToWorldPoint(screenPos);
    }

    Vector3 GetTouchWorldPosition(Touch touch)
    {
        Vector3 screenPos = touch.position;
        screenPos.z = 1f;
        return cam.ScreenToWorldPoint(screenPos);
    }
}
