using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    [SerializeField] private UnityEvent buttonPressed;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("hands"))
        {
            buttonPressed.Invoke();
        }
    }

}
