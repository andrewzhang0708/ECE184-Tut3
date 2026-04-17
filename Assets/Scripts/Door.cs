using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    public float openHeight = 3f;
    public float openSpeed = 3f;

    private float closedY;

    private void Awake()
    {
        closedY = transform.position.y;
    }

    public void Open()
    {
        
    }

    public void close()
    {
        
    }

    private IEnumerator OpenCR()
    {
        while(transform.position.y < closedY + openHeight)
        {
            transform.position += openSpeed * Time.deltaTime * Vector3.up;
            yield return null;
        }
        transform.position = new Vector3(transform.position.x, closedY + openHeight, transform.position.z);
    }
}
