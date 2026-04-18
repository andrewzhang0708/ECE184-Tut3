using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float xOffset, yOffset, lerp;

    private void LateUpdate()
    {
        Vector3 lerpPos = target.position - xOffset * target.forward + yOffset * target.up;

        transform.position = Vector3.Lerp(transform.position, lerpPos, lerp);
        transform.LookAt(target);
    }
}
