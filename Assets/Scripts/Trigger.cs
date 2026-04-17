using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent activate, deactivate;

    private void OnTriggerEnter()
    {
        activate.Invoke();
    }

    private void OnTriggerExit()
    {
        deactivate.Invoke();
    }

}
