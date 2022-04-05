using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other == gameObject.CompareTag("hands"))
        {

        }
    }

}
