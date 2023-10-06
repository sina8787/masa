using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // The object the camera will follow
    public Vector3 offset = new Vector3(0f, 2f, -5f); // The offset from the target object

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target.position);
        }
    }
}

