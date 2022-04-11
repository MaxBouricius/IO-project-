using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    [SerializeField] private UnityEvent buttonPressed;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.name == "HandColliderLeft(Clone)")
        {
            buttonPressed.Invoke();
        }
        if (other.gameObject.name == "HandColliderRight(Clone)")
        {
            buttonPressed.Invoke();
        }
    }

}
