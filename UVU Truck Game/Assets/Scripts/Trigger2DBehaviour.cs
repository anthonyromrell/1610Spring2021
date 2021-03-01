using UnityEngine;
using UnityEngine.Events;

public class Trigger2DBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;
    private void OnTriggerEnter2D(Collider2D other)
    {   
        triggerEvent.Invoke();
    }
}
